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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Kos_Manager
{

   
    public partial class Tela_fornecedor : Form
    {



        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;


        public Tela_fornecedor()
        {
            InitializeComponent();
            ListarFornecedores();
        }

        string id;

        public void ListarFornecedores()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_estoqueMp = @"
                    SELECT 
                        TB_FORNECEDOR_ID  as id,
						TB_FORNECEDOR_NOME as Nome,
						TB_FORNECEDOR_PRODUTO as Produto,
						TB_FORNECEDOR_CONTATO as Contato ,
						TB_FORNECEDOR_OUTRO_CONTATO as Outro
                        from tb_fornecedor";

            con.Open();

            DataTable tabela_estoqueMp = new DataTable();

            MySqlDataAdapter da_estoqueMp = new MySqlDataAdapter(sql_select_estoqueMp, con);
            da_estoqueMp.Fill(tabela_estoqueMp);

            DgvFornecedor.DataSource = tabela_estoqueMp;

            con.Close();


        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Tela_fornecedor_Load(object sender, EventArgs e)
        {
            
        }

        private void LimparDados()
        {
            // Limpar TextBox
            Txt_nome_fornecedor.Clear();
            Txt_produto_fornecido.Clear();
            Txt_tel_fornecedor.Clear();
            Txt_outro_contato_fornecedor.Clear();
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome = Txt_nome_fornecedor.Text;
                string produto = Txt_produto_fornecido.Text;
                string contato = Txt_tel_fornecedor.Text;
                string outro_tel = Txt_outro_contato_fornecedor.Text;

                string sql_insert = @"insert into tb_fornecedor
                (  
                  
                  TB_FORNECEDOR_NOME, 
                  TB_FORNECEDOR_PRODUTO, 
                  TB_FORNECEDOR_CONTATO, 
                  TB_FORNECEDOR_OUTRO_CONTATO
                 )
                values
                (
                    @FORNECEDOR_NOME, @FORNECEDOR_PRODUTO, @FORNECEDOR_CONTATO, @FORNECEDOR_OUTRO_CONTATO
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_NOME", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_PRODUTO", produto);
                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_CONTATO", contato);
                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_OUTRO_CONTATO", outro_tel); 

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarFornecedores();
                con.Close();
                LimparDados();
                //nnotificação aqui
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {

            string id = this.id;
            string nome = Txt_nome_fornecedor.Text;
            string produto = Txt_produto_fornecido.Text;
            string contato = Txt_tel_fornecedor.Text;
            string outro_tel = Txt_outro_contato_fornecedor.Text;


            MySqlConnection con = new MySqlConnection(conexao);


            string sql_update_fornecedor = @"update tb_materia_prima 
                                  set 
                                      TB_FORNECEDOR_NOME = @nome,
                                      TB_FORNECEDOR_PRODUTO = @produto,
                                      TB_FORNECEDOR_CONTATO = @contato,
                                      TB_FORNECEDOR_OUTRO_CONTATO = @outro
                                  where tb_fornecedor_id = @id";





            MySqlCommand executacmdMySql_update_fornecedor = new MySqlCommand(sql_update_fornecedor, con);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@produto", produto);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@contato", contato);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@quantidade", outro_tel);

            con.Open();
            executacmdMySql_update_fornecedor.ExecuteNonQuery();

            //notificação aqui

            ListarFornecedores();

            con.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // Declarando variável e inserindo conteúdo do textbox nela
            string id = this.id;

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_fornecedor = @"DELETE FROM tb_fornecedor WHERE tb_fornecedor_id = @id";

            MySqlCommand executarcmdMySql_delete_fornecedor = new MySqlCommand(sql_delete_fornecedor, con);

            executarcmdMySql_delete_fornecedor.Parameters.AddWithValue("@id", id);

            executarcmdMySql_delete_fornecedor.ExecuteNonQuery();

            //notificação aqui
            ListarFornecedores();

            // Fechando conexão
            con.Close();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_nome_fornecedor.Text = DgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            Txt_produto_fornecido.Text = DgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            Txt_tel_fornecedor.Text = DgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            Txt_outro_contato_fornecedor.Text = DgvFornecedor.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
