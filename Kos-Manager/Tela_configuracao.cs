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
using System.Globalization;

namespace Kos_Manager
{
    public partial class Tela_configuracao : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

        public Tela_configuracao()
        {
            InitializeComponent();
        }


        private void Tela_configuracao_Load(object sender, EventArgs e)
        {

            txt_email.Text = Usuario.email;
            txt_senha.Text = Usuario.senha;

        }

        private void txt_atualizar_nivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_visivel_Click(object sender, EventArgs e)
        {
           
            
                txt_senha.PasswordChar = '\0';

               //txt_senha.PasswordChar = '*';

    
        }

        private void Btn_atualizar_Click(object sender, EventArgs e) //botão atualizar senha
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string senha = txt_senha.Text;

            string sql_update_operador = @"update tb_operador_principal
                                           set 
                                            tb_operador_principal_senha = @senha
                                           where
                                            tb_operador_pricipal_id";

            MySqlCommand executacmdMySql_update_operador = new MySqlCommand(sql_update_operador, con);
            executacmdMySql_update_operador.Parameters.AddWithValue("@senha", senha );

            con.Open();
                executacmdMySql_update_operador.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");

           

            con.Close();
        }


        private void guna2Button1_Click(object sender, EventArgs e) //botão de atualiar email
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string email = txt_email.Text;

            string sql_update_operador = @"update tb_operador_principal
                                           set 
                                            tb_operador_principal_email = @email
                                           where
                                            tb_operador_pricipal_id";

            MySqlCommand executacmdMySql_update_operador = new MySqlCommand(sql_update_operador, con);
            executacmdMySql_update_operador.Parameters.AddWithValue("@senha", email);

            con.Open();
            executacmdMySql_update_operador.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");
        }
    }
}