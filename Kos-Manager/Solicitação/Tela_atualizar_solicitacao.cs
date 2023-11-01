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


namespace Kos_Manager.Solicitação
{
    public partial class Tela_atualizar_solicitacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_solicitacao()
        {
            InitializeComponent();
        }

        private void Tela_atualizar_solicitacao_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"
                    SELECT
                     s.tb_solicitacao_id AS Id,
                     s.tb_solicitacao_quantidade as Quantidade,
                     t.tb_solicitacao_status_nome as Status,
                     m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                     p.TB_MATERIA_PRIMA_MARCA_NOME AS Marca,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_solicitacao s
                     INNER JOIN
                     TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
                        INNER JOIN
                     tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
                     INNER JOIN
                     tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id
                    INNER JOIN
                     tb_materia_prima_marca p ON p.tb_materia_prima_marca_id = s.tb_materia_prima_marca_id";

            string sql_select_produto = "select * from tb_materia_prima";
            string sql_select_fornecedor = "select * from tb_fornecedor";
            string sql_select_status = "select * from tb_solicitacao_status";
            string sql_select_marca = "select * from tb_materia_prima_marca";

            MySqlCommand executacmdMySql_select_solicitacao = new MySqlCommand(sql_select_solicitacao, con);
            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            con.Open();

            executacmdMySql_select_solicitacao.ExecuteNonQuery();
            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_fornecedor.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_solicitacao = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_fornecedor = new DataTable();
            DataTable tabela_status = new DataTable();
            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(executacmdMySql_select_solicitacao);
            da_solicitacao.Fill(tabela_solicitacao);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_fornecedor = new MySqlDataAdapter(executacmdMySql_select_fornecedor);
            da_fornecedor.Fill(tabela_fornecedor);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);





            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_MATERIA_PRIMA_NOMENCLATURA"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_MATERIA_PRIMA_ID";  //Pega os dados            
            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.SelectedItem = null;


            cmb_fornecedor.DataSource = tabela_fornecedor;

            cmb_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_fornecedor.DisplayMember = "TB_FORNECEDOR_NOME"; //Exibe os dados para o usuário
            cmb_fornecedor.ValueMember = "TB_FORNECEDOR_ID";  //Pega os dados            
            cmb_fornecedor.DataSource = tabela_fornecedor;

            cmb_fornecedor.SelectedItem = null;


            cmb_marca.DataSource = tabela_marca;

            cmb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca.DisplayMember = "TB_MATERIA_PRIMA_MARCA_NOME"; // Exibe os dados para o usuário
            cmb_marca.ValueMember = "TB_MATERIA_PRIMA_MARCA_ID"; // Pega os dados

            cmb_marca.SelectedItem = null;

            cmb_status_solicitacao.DataSource = tabela_status;

            cmb_status_solicitacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_solicitacao.DisplayMember = "TB_SOLICITACAO_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_solicitacao.ValueMember = "TB_SOLICITACAO_STATUS_ID";  //Pega os dados            
            cmb_status_solicitacao.DataSource = tabela_status;

            cmb_status_solicitacao.SelectedItem = null;


        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
