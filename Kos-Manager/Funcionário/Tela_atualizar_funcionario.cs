using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Kos_Manager
{
    public partial class Tela_atualizar_funcionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_funcionario()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        { 
            //atualizando apartir do id
            string id = txt_cod.Text;
            string nome = Txt_nome_funcionario.Text;
            string email = Txt_email_funcionario.Text;
            string senha = Txt_senha_funcionario.Text;
            int cmb_Nivel = Convert.ToInt32(cmb_nivel_funcionario.SelectedValue);
            int cmb_Status = Convert.ToInt32(cmb_status_funcionario.SelectedValue);

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_update_venda = @"update tb_funcionario
    set tb_funcionario_nome = @nome,
        tb_funcionario_email = @email,
        tb_funcionario_senha = @senha,
        tb_status_id = @status,
        tb_nivel_acesso_id = @nivel
    where tb_funcionario_id = @id";

            MySqlCommand executacmdMySql_update_venda = new MySqlCommand(sql_update_venda, con);
            executacmdMySql_update_venda.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_venda.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_venda.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_venda.Parameters.AddWithValue("@senha", senha);
            executacmdMySql_update_venda.Parameters.AddWithValue("@status", cmb_Status);
            executacmdMySql_update_venda.Parameters.AddWithValue("@nivel", cmb_Nivel);
            con.Open();
            executacmdMySql_update_venda.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");

            //ListarFuncionario();

            con.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            //dletando apartir do id

            // Declarando variável e inserindo conteúdo do textbox nela
            int codigo = int.Parse(txt_cod.Text);

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_funcionario = @"DELETE FROM tb_funcionario WHERE tb_funcionario_id = @codigo";

            MySqlCommand executarcmdMySql_delete_funcionario = new MySqlCommand(sql_delete_funcionario, con);

            executarcmdMySql_delete_funcionario.Parameters.AddWithValue("@codigo", codigo);

            executarcmdMySql_delete_funcionario.ExecuteNonQuery();

            MessageBox.Show("Registro deletado com sucesso");
            //ListarFuncionario();

            // Fechando conexão
            con.Close();

        }
    }
}
