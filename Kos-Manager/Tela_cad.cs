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
        private string erro;


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

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string email;
                string senha;

                email = Txt_email_cad.Text;
                senha = Txt_senha_cad.Text;



                string sql_insert = @"insert into TB_OPERADOR_PRINCIPAL
                                                        (
                                                      TB_OPERADOR_PRINCIPAL_EMAIL, TB_OPERADOR_PRINCIPAL_SENHA
                                                         )

                                                      values 
                                                        (
                                                       @OPERADOR_PRINCIPAL_EMAIL, @OPERADOR_PRINCIPAL_SENHA
                                                        )";

                MySqlCommand executacmdMysql_insert = new MySqlCommand(sql_insert, con);

                executacmdMysql_insert.Parameters.AddWithValue("@OPERADOR_PRINCIPAL_EMAIL", email);
                executacmdMysql_insert.Parameters.AddWithValue("@OPERADOR_PRINCIPAL_SENHA", senha);
                con.Open();
                executacmdMysql_insert.ExecuteNonQuery();

                con.Close();
                //_ = MessageBox.Show("TA CADASTRADO VADIA");

            }

            catch (Exception erro)
            {

                MessageBox.Show("BURRO EM PAULO, ERRADO: " + erro);
            }

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
    }
}
