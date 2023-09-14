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
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        private void Link_nao_tem_cad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_cad tcad = new Tela_cad();
            tcad.Show();
            this.Hide();
        }

        private void Btn_logar_Click(object sender, EventArgs e)
        {
            Tela_inicial tinc = new Tela_inicial();
            tinc.Show();
            this.Hide();
        }

        private void Check_ver_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_ver_senha.Checked)
            {
                Txt_senha_login.PasswordChar = '\0';
            }
            else
            {
                Txt_senha_login.PasswordChar = '*';
            }
        }
    }
}
