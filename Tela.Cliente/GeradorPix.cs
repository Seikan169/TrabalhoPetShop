using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela.Cliente
{
    public class GeradorPix
    {
        private string _chave;
        private string _nomeRecebedor;
        private string _cidade;
        private string _valor;
        private string _txtId;

        public GeradorPix(string chavePix, string nome, string cidade, decimal valor, string txtId = "***")
        {
            _chave = chavePix;
            _nomeRecebedor = nome.Length > 25 ? nome.Substring(0, 25) : nome; // Limita tamanho
            _cidade = cidade.Length > 15 ? cidade.Substring(0, 15) : cidade; // Limita tamanho

            // O SEGREDO ESTÁ AQUI: Força o uso de PONTO para decimais
            _valor = valor.ToString("F2", CultureInfo.InvariantCulture);
            _txtId = txtId;
        }

        public string GerarPayload()
        {
            StringBuilder payload = new StringBuilder();

            // 1. Formato (00)
            payload.Append("000201");

            // 2. Merchant Account Information (26)
            string gui = "0014br.gov.bcb.pix";
            string chaveInfo = $"01{_chave.Length:D2}{_chave}";
            string merchantAccount = $"{gui}{chaveInfo}";
            payload.Append($"26{merchantAccount.Length:D2}{merchantAccount}");

            // 3. Merchant Category Code (52) - 0000 Geral
            payload.Append("52040000");

            // 4. Transaction Currency (53) - 986 = Real
            payload.Append("5303986");

            // 5. Transaction Amount (54)
            if (!string.IsNullOrEmpty(_valor))
            {
                payload.Append($"54{_valor.Length:D2}{_valor}");
            }

            // 6. Country Code (58)
            payload.Append("5802BR");

            // 7. Merchant Name (59)
            payload.Append($"59{_nomeRecebedor.Length:D2}{_nomeRecebedor}");

            // 8. Merchant City (60)
            payload.Append($"60{_cidade.Length:D2}{_cidade}");

            // 9. Additional Data Field (62) - ID da Transação
            string txid = $"05{_txtId.Length:D2}{_txtId}";
            payload.Append($"62{txid.Length:D2}{txid}");

            // 10. CRC16 (63)
            payload.Append("6304"); // Adiciona o ID e tamanho do CRC, mas o valor vem depois

            // Calcula o CRC final
            string crc16 = CalcularCRC16(payload.ToString());
            return payload.ToString() + crc16;
        }

        // Essa é a matemática que valida o Pix (Polinômio 0x1021)
        private static string CalcularCRC16(string data)
        {
            int crc = 0xFFFF;
            int polynomial = 0x1021;
            byte[] bytes = Encoding.ASCII.GetBytes(data);

            foreach (byte b in bytes)
            {
                for (int i = 0; i < 8; i++)
                {
                    bool bit = ((b >> (7 - i) & 1) == 1);
                    bool c15 = ((crc >> 15 & 1) == 1);
                    crc <<= 1;
                    if (c15 ^ bit) crc ^= polynomial;
                }
            }

            crc &= 0xFFFF;
            return crc.ToString("X4"); // Retorna em Hexadecimal Maiúsculo (Ex: A3F5)
        }
    }
}
