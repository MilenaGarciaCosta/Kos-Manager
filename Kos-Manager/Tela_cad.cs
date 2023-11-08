using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kos_Manager
{
    public partial class Tela_cad : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

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

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);


                string email = Txt_email_cad.Text;
                string senha = Txt_senha_cad.Text;

                // Verifica se a senha contém pelo menos um caractere especial
                if (SenhaContemCaracterEspecial(senha) && EmailArroba(email) && senha.Length >= 8 && senha.Length == 8)
                {
                    string sql_insert = @"insert into TB_OPERADOR_PRINCIPAL
                                  (TB_OPERADOR_PRINCIPAL_EMAIL, TB_OPERADOR_PRINCIPAL_SENHA)
                                  values 
                                  (@OPERADOR_PRINCIPAL_EMAIL, @OPERADOR_PRINCIPAL_SENHA)";

                    MySqlCommand executacmdMysql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMysql_insert.Parameters.AddWithValue("@OPERADOR_PRINCIPAL_EMAIL", email);
                    executacmdMysql_insert.Parameters.AddWithValue("@OPERADOR_PRINCIPAL_SENHA", senha);

                    con.Open();
                    executacmdMysql_insert.ExecuteNonQuery();
                    con.Close();


                    Tela_inicial tinc = new Tela_inicial();
                    tinc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("A senha precisa ter 8 caracteries e um deles precisa ser especial, ex: -/:;.,?!$&@“‘#");
                }
            }

            catch (Exception erro)
            {

                MessageBox.Show("Erro de conexão: " + erro);
            }

        }

        static bool SenhaContemCaracterEspecial(string senha)
        {
            // Lista de caracteres especiais permitidos
            string caracteresEspeciais = "-/:;.,?!$&@“‘#";

            // Verifica se pelo menos um dos caracteres especiais está presente na senha
            return senha.Any(c => caracteresEspeciais.Contains(c));
        }

        static bool EmailArroba(string email)
        {
            // Lista de domínios permitidos
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@outlook.com" };

            // Verifica se o email termina com um dos domínios permitidos
            return dominiosPermitidos.Any(dominio => email.EndsWith(dominio));
        }

        private void Txt_rep_senha_cad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_ver_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_ver_senha.Checked)
            {
                Txt_senha_cad.PasswordChar = '\0';     
            }
            else
            {
                Txt_senha_cad.PasswordChar = '*';
            }
        }

        private void Lbl_caracteres_min_Click(object sender, EventArgs e)
        {

        }

        private void Txt_senha_cad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
