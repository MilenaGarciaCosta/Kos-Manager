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
using System.Globalization;

namespace Kos_Manager.Vendas
{
    public partial class Tela_atualizar_venda : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;
        string id;

        public Tela_atualizar_venda()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.id; // Certifique-se de que 'this.id' esteja corretamente inicializado

                string quantidade = Txt_quantidade.Text;
                string valor = Txt_valor_produto.Text;
                int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
                int cmb_Venda_status = Convert.ToInt32(cmb_status.SelectedValue);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_venda = @"UPDATE tb_venda 
                                SET tb_venda_quantidade = @quantidade,
                                    tb_venda_valor = @valor,
                                    tb_funcionario_id = @cmbfuncionario,
                                    tb_produto_manu_id = @cmbproduto,
                                    tb_venda_status_id = @cmbstatus
                                WHERE tb_venda_id = @id";

                MySqlCommand executacmdMySql_update_venda = new MySqlCommand(sql_update_venda, con);
                executacmdMySql_update_venda.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_venda.Parameters.AddWithValue("@quantidade", int.Parse(quantidade));

                decimal valorDecimal = decimal.Parse(valor);
                if (int.TryParse(quantidade, out int quantidadeInt) && quantidadeInt > 1)
                {
                    valorDecimal *= quantidadeInt; // Multiplica o valor pela quantidade
                }
                executacmdMySql_update_venda.Parameters.AddWithValue("@valor", valorDecimal);
                executacmdMySql_update_venda.Parameters.AddWithValue("@cmbfuncionario", cmb_Funcionario);
                executacmdMySql_update_venda.Parameters.AddWithValue("@cmbproduto", cmb_Produto);
                executacmdMySql_update_venda.Parameters.AddWithValue("@cmbstatus", cmb_Venda_status);

                int rowsAffected = executacmdMySql_update_venda.ExecuteNonQuery();

                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Atualização realizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // Declarando variável e inserindo conteúdo do textbox nela
          

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_venda = @"DELETE FROM tb_venda WHERE tb_venda_id = @codigo";

            MySqlCommand executarcmdMySql_delete_venda = new MySqlCommand(sql_delete_venda, con);

            executarcmdMySql_delete_venda.Parameters.AddWithValue("@codigo", this.id);

            executarcmdMySql_delete_venda.ExecuteNonQuery();

            MessageBox.Show("Registro deletado com sucesso");
            //ListarVendas(); função do refresh 

            // Fechando conexão
            con.Close();
        }

        private void Tela_atualizar_venda_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_venda = @"
                     SELECT
                     v.tb_venda_id AS Id,
                     v.tb_venda_quantidade AS Quantidade,
                     v.tb_venda_valor as Valor,
                     p.tb_produto_manu_nome AS Produto,
                     f.tb_funcionario_nome AS Funcionario,
                     s.tb_venda_status_nome AS Status
                    FROM
                     tb_venda v
                     INNER JOIN
                     tb_produto_manu p ON v.tb_produto_manu_id = p.tb_produto_manu_id
                        INNER JOIN
                     tb_funcionario f ON v.tb_funcionario_id = f.tb_funcionario_id
                              INNER JOIN
                     tb_venda_status s ON v.tb_venda_status_id = s.tb_venda_status_id";

            string sql_select_produto = "select * from tb_produto_manu";
            string sql_select_venda_status = "select * from tb_venda_status";
            string sql_select_funcionario = "select * from tb_funcionario";

            MySqlCommand executacmdMySql_select_venda = new MySqlCommand(sql_select_venda, con);
            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_venda_status = new MySqlCommand(sql_select_venda_status, con);
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);

            con.Open();

            executacmdMySql_select_venda.ExecuteNonQuery();
            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_venda_status.ExecuteNonQuery();
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_venda = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_venda_status = new DataTable();
            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_venda = new MySqlDataAdapter(executacmdMySql_select_venda);
            da_venda.Fill(tabela_venda);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_venda_status = new MySqlDataAdapter(executacmdMySql_select_venda_status);
            da_venda_status.Fill(tabela_venda_status);

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);



            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_PRODUTO_MANU_NOME"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_PRODUTO_MANU_ID";  //Pega os dados            
            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.SelectedItem = null;


            cmb_status.DataSource = tabela_venda_status;

            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status.DisplayMember = "TB_VENDA_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status.ValueMember = "TB_VENDA_STATUS_ID";  //Pega os dados            
            cmb_status.DataSource = tabela_venda_status;

            cmb_status.SelectedItem = null;


            cmb_funcionario.DataSource = tabela_funcionario;

            cmb_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_funcionario.DisplayMember = "TB_funcionario_NOME"; //Exibe os dados para o usuário
            cmb_funcionario.ValueMember = "TB_funcionario_ID";  //Pega os dados            
            cmb_funcionario.DataSource = tabela_funcionario;

            cmb_funcionario.SelectedItem = null;
        }
    }
}
