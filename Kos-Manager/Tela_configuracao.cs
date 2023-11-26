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
using Kos_Manager.Notificação;

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
            txt_senha.PasswordChar = txt_senha.PasswordChar == '*' ? '\0' : '*';
        }
        //Public de notificação
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void Btn_atualizar_Click(object sender, EventArgs e) //botão atualizar senha
        {
            try { 
            MySqlConnection con = new MySqlConnection(conexao);

            string id = this.id;
            string email = txt_email.Text;
            string nome = this.nome;
            string senha = txt_senha.Text;

            string sql_update_operador = @"UPDATE tb_operador_principal 
                                           SET tb_operador_principal_nome = @nome,
                                               tb_operador_principal_email = @email,
                                               tb_operador_principal_senha = @senha
                                           WHERE tb_operador_principal_id = @id";

            MySqlCommand executacmdMySql_update_operador = new MySqlCommand(sql_update_operador, con);

            executacmdMySql_update_operador.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_operador.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_operador.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_operador.Parameters.AddWithValue("@senha", senha);


            con.Open(); 
            executacmdMySql_update_operador.ExecuteNonQuery();

            Usuario.email = email;
            Usuario.senha = senha;

                //notificação
                this.Alert("Atualizado com sucesso", Form_Alert.enmType.Update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a atualização: " + ex.Message);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e) //botão de atualiar email
        {
            try
            {

            
            MySqlConnection con = new MySqlConnection(conexao);

            string id = this.id;
            string email = txt_email.Text;
            string nome = this.nome;
            string senha = txt_senha.Text;

            string sql_update_operador = @"UPDATE tb_operador_principal 
                                           SET tb_operador_principal_nome = @nome,
                                               tb_operador_principal_email = @email,
                                               tb_operador_principal_senha = @senha
                                           WHERE tb_operador_principal_id = @id";

            MySqlCommand executacmdMySql_update_operador = new MySqlCommand(sql_update_operador, con);

            executacmdMySql_update_operador.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_operador.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_operador.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_operador.Parameters.AddWithValue("@senha", senha);


            con.Open();
            executacmdMySql_update_operador.ExecuteNonQuery();

             Usuario.email = email;
             Usuario.senha = senha;

                //notificação
                this.Alert("Atualizado com sucesso", Form_Alert.enmType.Update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a atualização: " + ex.Message);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login tlgn = new Tela_login();
            this.Close();
            tlgn.Show();
        }
    }
}