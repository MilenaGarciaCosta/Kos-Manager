using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kos_Manager
{
    public partial class Tela_login : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;


        public Tela_login()
        {
            InitializeComponent();
        }

        private void Link_nao_tem_cad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_cad tcad = new Tela_cad();
            tcad.Show();
            this.Close();
        }

        private void Btn_logar_Click(object sender, EventArgs e)
        {
            string email = Txt_email_login.Text;
            string senha = Txt_senha_login.Text;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM TB_OPERADOR_PRINCIPAL WHERE TB_OPERADOR_PRINCIPAL_EMAIL = @Email AND TB_OPERADOR_PRINCIPAL_SENHA = @Senha";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {


                        Usuario.email = email;
                        Usuario.senha = senha;

                        Tela_inicial tinc = new Tela_inicial();
                        tinc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                    }
                }
            }

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

        private void Link_esqueceu_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}