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

        string id;

        public void ListarRequisicao()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_requisicao = @"
                           SELECT
                     r.tb_requisicao_id AS Id,
                     p.TB_PRODUTO_MANU_NOME AS Nome,
                     r.tb_requisicao_quantidade as Quantidade,
                     s.tb_requisicao_status_nome as Status
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


        private void LimparDados()
        {
            // Limpar TextBox
            Txt_quantidade.Clear();

            // Limpar ComboBox
        }
        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                int cmb_Status = Convert.ToInt32(cmb_status_requisicao.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);

                string sql_insert = @"insert into TB_REQUISICAO
                (  
                 
                   TB_REQUISICAO_QUANTIDADE,
                   TB_REQUISICAO_STATUS_ID,
                   TB_PRODUTO_MANU_ID
            
                 )
                values
                (
                   @REQUISICAO_QUANTIDADE, @REQUISICAO_STATUS, @PRODUTO_MANU_ID
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@REQUISICAO_QUANTIDADE", quantidade);
                executacmdMySql_insert.Parameters.AddWithValue("@REQUISICAO_STATUS", cmb_Status);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_ID", cmb_Produto);


                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarRequisicao();
                con.Close();
                LimparDados();
                //notificação aqui
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string id = Txt_id.Text;
            int quantidade = Convert.ToInt32(Txt_quantidade.Text);
            int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
            int cmb_Status = Convert.ToInt32(cmb_status_requisicao.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                

                string sql_update_tb_requisicao = @"UPDATE tb_requisicao
            SET tb_requisicao_quantidade = @quantidade,
                tb_requisicao_status_id = @status,
                tb_produto_manu_id = @produto
            WHERE tb_requisicao_id = @id";

                MySqlCommand executacmdMySql_update_tb_requisicao = new MySqlCommand(sql_update_tb_requisicao, con);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@quantidade", quantidade);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@status", cmb_Status);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@produto", cmb_Produto);

                con.Open();
                executacmdMySql_update_tb_requisicao.ExecuteNonQuery();
                ListarRequisicao();
                con.Close();
                //notificação aqui
            }
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID da solicitação que deseja excluir
                string id = Txt_id.Text;

                MySqlConnection con = new MySqlConnection(conexao);

                // Define a consulta SQL para exclusão
                string sql_delete_tb_requisicao = "DELETE FROM tb_requisicao WHERE tb_requisicao_id = @id";

                MySqlCommand executacmdMySql_delete_tb_requisicao = new MySqlCommand(sql_delete_tb_requisicao, con);
                executacmdMySql_delete_tb_requisicao.Parameters.AddWithValue("@id", id);

                con.Open();
                executacmdMySql_delete_tb_requisicao.ExecuteNonQuery();
                con.Close();

                //notificação aqui

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

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Child_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_requisita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Dgv_requisita.CurrentRow.Cells[0].Value.ToString();
            cmb_nome_produto.Text = Dgv_requisita.CurrentRow.Cells[1].Value.ToString();
            Txt_quantidade.Text = Dgv_requisita.CurrentRow.Cells[2].Value.ToString();
            cmb_status_requisicao.Text = Dgv_requisita.CurrentRow.Cells[3].Value.ToString();
        }

        private void Tela_requisicao_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

                        string sql_select_requisicao = @"
            SELECT
                            r.tb_requisicao_id AS Id,
                            pm.tb_produto_manu_nome AS Nome,
                            r.tb_requisicao_quantidade as Quantidade,
                            rs.tb_requisicao_status_nome as Status
                
                        FROM
                            tb_requisicao r
                            INNER JOIN tb_produto_manu pm ON pm.tb_produto_manu_id = r.tb_produto_manu_id
                            INNER JOIN tb_requisicao_status rs ON rs.tb_requisicao_status_id = r.tb_requisicao_status_id";


            string sql_select_produto = "select * from tb_produto_manu";
            string sql_select_status = "select * from tb_requisicao_status";

            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            MySqlCommand executacmdMySql_select_requisicao = new MySqlCommand(sql_select_requisicao, con);
            con.Open();

            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();
            executacmdMySql_select_requisicao.ExecuteNonQuery();

            DataTable tabela_requisicao = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_status = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(executacmdMySql_select_requisicao);
            da_solicitacao.Fill(tabela_requisicao);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);



            Dgv_requisita.DataSource = tabela_requisicao;


            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_PRODUTO_MANU_NOME"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_PRODUTO_MANU_ID";  //Pega os dados            
            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.SelectedItem = null;


            cmb_status_requisicao.DataSource = tabela_status;

            cmb_status_requisicao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_requisicao.DisplayMember = "TB_REQUISICAO_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_requisicao.ValueMember = "TB_REQUISICAO_STATUS_ID";  //Pega os dados            
            cmb_status_requisicao.DataSource = tabela_status;

            cmb_status_requisicao.SelectedItem = null;
        }
    }
}
