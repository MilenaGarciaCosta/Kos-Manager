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
        string id;
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
            this.id = id;
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
            

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_funcionario = @"DELETE FROM tb_funcionario WHERE tb_funcionario_id = @codigo";

            MySqlCommand executarcmdMySql_delete_funcionario = new MySqlCommand(sql_delete_funcionario, con);

            executarcmdMySql_delete_funcionario.Parameters.AddWithValue("@codigo", this.id);

            executarcmdMySql_delete_funcionario.ExecuteNonQuery();

            MessageBox.Show("Registro deletado com sucesso");
            //ListarFuncionario();

            // Fechando conexão
            con.Close();

        }

        private void Tela_atualizar_funcionario_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_funcionario = @"SELECT 
				f.tb_funcionario_id AS Id,
                 f.tb_funcionario_nome AS Nome,
                 f.tb_funcionario_email AS Email,
                 f.tb_funcionario_senha AS Senha,
                 s.tb_status_nome AS Status,
                 n.tb_nivel_acesso_nome AS Nivel_de_Acesso

            FROM
                tb_funcionario f
            INNER JOIN
                tb_status s ON f.tb_status_id = f.tb_status_id
                INNER JOIN
                tb_nivel_acesso n ON n.tb_nivel_acesso_id = f.tb_nivel_acesso_id ";
            string sql_select_nivel = "select * from tb_nivel_acesso";
            string sql_select_status = "select * from tb_status";

            //Execute o cargo e funcionario
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            MySqlCommand executacmdMySql_select_nivel = new MySqlCommand(sql_select_nivel, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            con.Open();

            executacmdMySql_select_funcionario.ExecuteNonQuery();
            executacmdMySql_select_nivel.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();
            DataTable tabela_nivel = new DataTable();
            DataTable tabela_status = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            MySqlDataAdapter da_nivel = new MySqlDataAdapter(executacmdMySql_select_nivel);
            da_nivel.Fill(tabela_nivel);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);



            cmb_nivel_funcionario.DataSource = tabela_nivel;

            cmb_nivel_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nivel_funcionario.DisplayMember = "TB_NIVEL_ACESSO_NOME"; //Exibe os dados para o usuário
            cmb_nivel_funcionario.ValueMember = "TB_NIVEL_ACESSO_ID";  //Pega os dados     

            cmb_nivel_funcionario.SelectedItem = null;

            cmb_status_funcionario.DataSource = tabela_status;

            cmb_status_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_funcionario.DisplayMember = "TB_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_funcionario.ValueMember = "TB_STATUS_ID";  //Pega os dados            
            cmb_status_funcionario.SelectedItem = null;
        }
    }
}
