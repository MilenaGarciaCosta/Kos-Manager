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
    public partial class Tela_add_solicitacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_add_solicitacao()
        {
            InitializeComponent();
        }

        public void ListarSolicitacao()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"
                        SELECT
                     s.tb_solicitacao_id AS Id,
                     s.tb_solicitacao_quantidade as quantidade,
                     m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                     m.TB_MATERIA_PRIMA_MARCA AS Marca,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_solicitacao s
                     INNER JOIN
                     TB_MATERIA_PRIMA m ON s.TB_MATERIA_PRIMA_id = m.TB_MATERIA_PRIMA_id
                        INNER JOIN
                     tb_fornecedor f ON s.tb_fornecedor_id = f.tb_fornecedor_id";

            con.Open();

            DataTable tabela_solicitacao = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(sql_select_solicitacao, con);
            da_solicitacao.Fill(tabela_solicitacao);

            //Dgv_solicita.DataSource = tabela_solicitacao; datagridview

            con.Close();


        }


        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tela_add_solicitacao_Load(object sender, EventArgs e)
        {

        }

        private void cmb_status_solicitacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                int cmb_Fornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);

                string sql_insert = @"insert into TB_SOLICITACAO
                (  
                 
                   TB_SOLICITACAO_QUANTIDADE,
                   TB_MATERIA_PRIMA_ID, 
                   TB_FORNECEDOR_ID
            
                 )
                values
                (
                   @SOLICITACAO_QUANTIDADE, @MATERIA_PRIMA_ID, @FORNECEDOR_ID
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@SOLICITACAO_QUANTIDADE", quantidade);
                executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_ID", cmb_Produto);
                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_ID", cmb_Fornecedor);


                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarSolicitacao();
                con.Close();
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }
        }
    }
}
