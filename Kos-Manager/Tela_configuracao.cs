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

        string nome;
        string senha;
        string id;

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

               txt_senha.PasswordChar = '*';

    
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

            string id = this.id;
            string email = txt_email.Text;
            string nome = this.nome;
            string senha = this.senha;

            string sql_update_operador = @"UPDATE tb_operador_principal 
                                           SET tb_operador_principal_nome = @nome,
                                            tb_operador_principal_email = @email,
                                            tb_operador_principal_senha = @senha
                                           WHERE tb_operador_pricipal_id";

            MySqlCommand executacmdMySql_update_operador = new MySqlCommand(sql_update_operador, con);

            executacmdMySql_update_operador.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_operador.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_operador.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_operador.Parameters.AddWithValue("@senha", senha);


            con.Open();
            executacmdMySql_update_operador.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login tlgn = new Tela_login();
            this.Close();
            tlgn.Show();
        }
    }
}