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
    public partial class Tela_requisicao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_requisicao()
        {
            InitializeComponent();
            ListarRequisicao();
        }

        public void ListarRequisicao()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_requisicao = @"
                           SELECT
                     r.tb_requisicao_id AS Id,
                     r.tb_requisicao_quantidade as Quantidade,
                     s.tb_requisicao_status_nome as Status,
                     p.TB_PRODUTO_MANU_NOME AS Nome
                    FROM
                     tb_requisicao r
                     INNER JOIN
                     TB_PRODUTO_MANU p ON p.TB_PRODUTO_MANU_id = r.TB_PRODUTO_MANU_id
                        INNER JOIN
                     tb_requisicao_status s ON s.tb_requisicao_status_id = r.tb_requisicao_status_id ";

            con.Open();

            DataTable tabela_requisicao = new DataTable();

            MySqlDataAdapter da_requisicao = new MySqlDataAdapter(sql_select_requisicao, con);
            da_requisicao.Fill(tabela_requisicao);

            Dgv_requisita.DataSource = tabela_requisicao;

            con.Close();


        }


        private Form FormAtivo = null;
        private void abrirChildForm(Form ChildForm)
        {
            if (FormAtivo != null)
                FormAtivo.Close();
            FormAtivo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Child_panel.Controls.Add(ChildForm);
            Child_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Btn_requisitar_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_add_req());
        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                int cmb_Status = Convert.ToInt32(cmb_status_requisicao.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
                int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);

                string sql_insert = @"insert into TB_REQUISICAO
                (  
                 
                   TB_REQUISICAO_QUANTIDADE,
                   TB_REQUISICAO_STATUS_ID,
                   TB_PRODUTO_MANU_ID,
                   TB_FUNCIONARIO_ID
            
                 )
                values
                (
                   @REQUISICAO_QUANTIDADE, @REQUISICAO_STATUS, @PRODUTO_MANU_ID, @FUNCIONARIO_ID
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@REQUISICAO_QUANTIDADE", quantidade);
                executacmdMySql_insert.Parameters.AddWithValue("@REQUISICAO_STATUS", cmb_Status);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_ID", cmb_Produto);
                executacmdMySql_insert.Parameters.AddWithValue("@FUNCIONARIO_ID", cmb_Funcionario);


                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarRequisicao();
                con.Close();
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string id = txt_cod.Text;
            int quantidade = Convert.ToInt32(Txt_quantidade.Text);
            int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
            int cmb_Status = Convert.ToInt32(cmb_status_requisicao.SelectedValue);
            int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string sql_update_tb_requisicao = @"UPDATE tb_requisicao
            SET tb_requisicao_quantidade = @quantidade,
                tb_requisicao_status_id = @status,
                tb_produto_manu_id = @produto,
                tb_funcionario_id = @funcionario
            WHERE tb_requisicao_id = @id";

                MySqlCommand executacmdMySql_update_tb_requisicao = new MySqlCommand(sql_update_tb_requisicao, con);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@quantidade", quantidade);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@status", cmb_Status);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@produto", cmb_Produto);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@funcionario", cmb_Funcionario);

                con.Open();
                executacmdMySql_update_tb_requisicao.ExecuteNonQuery();
                ListarRequisicao();
                con.Close();
                MessageBox.Show("Cadastrado com Sucesso!"); ;
            }
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID da solicitação que deseja excluir
                string id = txt_cod.Text;

                MySqlConnection con = new MySqlConnection(conexao);

                // Define a consulta SQL para exclusão
                string sql_delete_tb_requisicao = "DELETE FROM tb_requisicao WHERE tb_requisicao_id = @id";

                MySqlCommand executacmdMySql_delete_tb_requisicao = new MySqlCommand(sql_delete_tb_requisicao, con);
                executacmdMySql_delete_tb_requisicao.Parameters.AddWithValue("@id", id);

                con.Open();
                executacmdMySql_delete_tb_requisicao.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Exclusão realizada com sucesso");

                // Atualize a exibição da lista de solicitações
                ListarRequisicao();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
