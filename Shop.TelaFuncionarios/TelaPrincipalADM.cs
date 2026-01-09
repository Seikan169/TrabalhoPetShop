using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop.TelaFuncionarios
{
    public partial class TelaPrincipalADM : Form
    {
        private readonly string _baseUrl = "https://localhost:7214";

        public TelaPrincipalADM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       

        private void BtnControleFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void BtnSairADM_Click(object sender, EventArgs e)
        {
            TelaLogin sairlogin = new TelaLogin();
            sairlogin.Show();
        }

        private void BtnBuscarADM_Click(object sender, EventArgs e)
        {
             
        }

    }
}
