using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela.Cliente
{
    public class GeradorPix
    {
        private string _chave;
        private string _nome;
        private string _cidade;
        private string _valor;
        private string _txtId;

        public GeradorPix(string chave, string nome, string cidade, decimal valor, string txtId = "***")
        {
            _chave = chave;
            _nome = nome.Length > 25 ? nome.Substring(0, 25) : nome; // Máximo 25 chars
            _cidade = cidade.Length > 15 ? cidade.Substring(0, 15) : cidade; // Máximo 15 chars
            _valor = valor.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            _txtId = txtId;
        }

        public string GerarPayload()
        {
            string payload =
                $"00020126580014br.gov.bcb.pix0136{_chave}52040000530398654{_valor.Length:D2}{_valor}5802BR59{_nome.Length:D2}{_nome}60{_cidade.Length:D2}{_cidade}62070503{_txtId}6304";

            payload += CalcularCRC16(payload);
            return payload;
        }

        private string CalcularCRC16(string data)
        {
            int crc = 0xFFFF;
            byte[] bytes = Encoding.ASCII.GetBytes(data);

            foreach (byte b in bytes)
            {
                crc ^= (b << 8);
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x8000) != 0)
                        crc = (crc << 1) ^ 0x1021;
                    else
                        crc <<= 1;
                }
            }
            return (crc & 0xFFFF).ToString("X4");
        }
    }
}
