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

namespace Kos_Manager.Requisição
{
    public partial class Tela_atualizar_req : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_req()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tela_atualizar_req_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_requisicao = @"
                   SELECT
                     r.tb_requisicao_id AS Id,
					 p.TB_PRODUTO_MANU_NOME AS Produto,
                     r.tb_requisicao_quantidade as Quantidade,
                     s.tb_requisicao_status_nome as Status,
                     f.tb_funcionario_nome as Responsavel 
                    FROM
                     tb_requisicao r
                     INNER JOIN
                     TB_PRODUTO_MANU p ON p.TB_PRODUTO_MANU_id = r.TB_PRODUTO_MANU_id
                        INNER JOIN
                     tb_requisicao_status s ON s.tb_requisicao_status_id = r.tb_requisicao_status_id 
                        INNER JOIN
                     tb_funcionario f ON f.tb_funcionario_id = r.tb_funcionario_id ";

            string sql_select_status = "select * from tb_requisicao_status";
            string sql_select_produto = "select *  from tb_produto_manu";
            string sql_select_funcionario = "select *  from tb_funcionario";

            MySqlCommand executacmdMySql_select_requisicao = new MySqlCommand(sql_select_requisicao, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            con.Open();

            executacmdMySql_select_requisicao.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();
            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_requisicao = new DataTable();
            DataTable tabela_status = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_requisicao = new MySqlDataAdapter(executacmdMySql_select_requisicao);
            da_requisicao.Fill(tabela_requisicao);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);




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

            cmb_funcionario.DataSource = tabela_funcionario;

            cmb_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_funcionario.DisplayMember = "TB_FUNCIONARIO_NOME"; //Exibe os dados para o usuário
            cmb_funcionario.ValueMember = "TB_FUNCIONARIO_ID";  //Pega os dados            
            cmb_funcionario.DataSource = tabela_funcionario;

            cmb_funcionario.SelectedItem = null;
        }
    }
}
