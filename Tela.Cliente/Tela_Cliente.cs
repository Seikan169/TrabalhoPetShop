using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela.Cliente
{
    public partial class Tela_Cliente : Form
    {
        public Tela_Cliente()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0; // Vai para a primeira aba
        }

        private void BtnMeusPets_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1; // Vai para a segunda aba
        }
    }
}
