using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager
{
    public partial class Tela_cad : Form
    {
        public Tela_cad()
        {
            InitializeComponent();
        }

        private void Tela_cad_Load(object sender, EventArgs e)
        {

        }

        private void Txt_nome_cad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Link_ja_tem_cad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_login tlgn = new Tela_login();
            tlgn.Show();
            this.Hide();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            Tela_inicial tinc = new Tela_inicial();
            tinc.Show();
            this.Hide();
        }
    }
}
