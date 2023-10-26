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

namespace Kos_Manager.Matéria_prima
{
    public partial class Tela_add_mat_prima : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_add_mat_prima()
        {
            InitializeComponent();
        }

        public void ListarEstoqueMp()
        {

            string nomenclatura;
            string marca;
            string lote;
            string dtval;
            string quantidade;
            string fornecedor;


            nomenclatura = txt_produto.Text;
            marca = cmb_marca.Text;
            lote = Txt_lote.Text;
            dtval = Txt_dt_validade.Text;
            quantidade = Txt_quantidade.Text;
            fornecedor = cmb_fornecedor.Text;


            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_estoqueMp = @"
                    SELECT
                     m.tb_materia_prima_id AS Id,
                     m.tb_materia_prima_nomenclatura AS Nomenclatura,
                     p.tb_materia_prima_marca_nome AS Marca,
                     m.tb_materia_prima_lote AS Lote,
                     m.tb_materia_prima_dt_val AS Data_de_Validade,
					 m.tb_materia_prima_quantidade AS Quantidade,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_materia_prima m
                     INNER JOIN
                     tb_fornecedor f ON m.tb_fornecedor_id = f.tb_fornecedor_id
                     INNER JOIN
                     tb_materia_prima_marca p ON m.tb_materia_prima_marca_id = p.tb_materia_prima_marca_id";

                con.Open();

                DataTable tabela_estoqueMp = new DataTable();

                MySqlDataAdapter da_estoqueMp = new MySqlDataAdapter(sql_select_estoqueMp, con);
                da_estoqueMp.Fill(tabela_estoqueMp);

               

                con.Close();

                Prima.nomenclatura = nomenclatura;
                Prima.marca = marca;
                Prima.lote = lote;
                Prima.dtval = dtval;
                Prima.quantidade = quantidade;
                Prima.IDfornecedor = fornecedor;


            }

            catch
            {

            }

        }

        private void Lbl_estoque_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txt_produto.Text;
                int cmbMarca = Convert.ToInt32(cmb_marca.SelectedValue);
                string lote = Txt_lote.Text;
                string quantidade = Txt_quantidade.Text;
                DateTime dtVal = DateTime.ParseExact(Txt_dt_validade.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Converter a data para DateTime
                string formattedDate = dtVal.ToString("yyyy-MM-dd"); // Formatar a data no estilo MySQL
                int cmbFornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);

                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql_insert = @"INSERT INTO tb_materia_prima
                             (tb_materia_prima_nomenclatura, 
                              TB_MATERIA_PRIMA_MARCA_ID, 
                              TB_MATERIA_PRIMA_LOTE,
                              TB_MATERIA_PRIMA_DT_VAL,
                              TB_MATERIA_PRIMA_QUANTIDADE,
                              TB_FORNECEDOR_ID)

                             VALUES
                             (@materia_prima_nomenclatura, 
                              @MATERIA_PRIMA_MARCA_ID, 
                              @MATERIA_PRIMA_LOTE, 
                              @MATERIA_PRIMA_DT_VAL, 
                              @MATERIA_PRIMA_QUANTIDADE, 
                              @FORNECEDOR_ID)";

                    using (MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con))
                    {
                        executacmdMySql_insert.Parameters.AddWithValue("@materia_prima_nomenclatura", nome);
                        executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_MARCA_ID", cmbMarca);
                        executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_LOTE", lote);
                        executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_DT_VAL", formattedDate);
                        executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_QUANTIDADE", quantidade);
                        executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_ID", cmbFornecedor);

                        executacmdMySql_insert.ExecuteNonQuery();
                    }

                    ListarEstoqueMp();
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }

        }

        private void Tela_add_mat_prima_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_estoque = @"
                     SELECT
                     m.tb_materia_prima_id AS Id,
                     m.tb_materia_prima_nomenclatura AS Nomenclatura,
                     p.tb_materia_prima_marca_nome AS Marca,
                     m.tb_materia_prima_lote AS Lote,
                     m.tb_materia_prima_dt_val AS Data_de_Validade,
					 m.tb_materia_prima_quantidade AS Quantidade,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_materia_prima m
                     INNER JOIN
                     tb_fornecedor f ON m.tb_fornecedor_id = f.tb_fornecedor_id
                     INNER JOIN
                     tb_materia_prima_marca p ON m.tb_materia_prima_marca_id = p.tb_materia_prima_marca_id";
            string sql_select_fornecedor = "select * from tb_fornecedor";
            string sql_select_marca = "select * from tb_materia_prima_marca";


            MySqlCommand executacmdMySql_select_estoque = new MySqlCommand(sql_select_estoque, con);
            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, con);
            MySqlCommand executacmdMySql_select_marca= new MySqlCommand(sql_select_marca, con);

            con.Open();

            executacmdMySql_select_estoque.ExecuteNonQuery();
            executacmdMySql_select_fornecedor.ExecuteNonQuery();
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_estoque = new DataTable();
            DataTable tabela_fornecedor = new DataTable();
            DataTable tabela_marca = new DataTable();


            MySqlDataAdapter da_estoque = new MySqlDataAdapter(executacmdMySql_select_estoque);
            da_estoque.Fill(tabela_estoque);

            MySqlDataAdapter da_fornecedor = new MySqlDataAdapter(executacmdMySql_select_fornecedor);
            da_fornecedor.Fill(tabela_fornecedor);

            MySqlDataAdapter da_marca= new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);


            cmb_fornecedor.DataSource = tabela_fornecedor;

            cmb_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_fornecedor.DisplayMember = "TB_FORNECEDOR_NOME"; //Exibe os dados para o usuário
            cmb_fornecedor.ValueMember = "TB_FORNECEDOR_ID";  //Pega os dados     

            cmb_fornecedor.SelectedItem = null;

           

            cmb_marca.DataSource = tabela_marca;

            cmb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca.DisplayMember = "TB_MATERIA_PRIMA_MARCA_NOME"; //Exibe os dados para o usuário
            cmb_marca.ValueMember = "TB_MATERIA_PRIMA_MARCA_ID";  //Pega os dados            
            cmb_marca.DataSource = tabela_marca;

            cmb_marca.SelectedItem = null;
        }
    }
}
