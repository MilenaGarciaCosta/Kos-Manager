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

namespace Kos_Manager.Matéria_prima
{
    public partial class Tela_atualizar_mat_prima : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_mat_prima()
        {
            InitializeComponent();
        }

        public void ListarEstoqueMp()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_estoqueMp = @"
                    SELECT
                     m.tb_materia_prima_id AS Id,
                     m.tb_materia_prima_nomenclatura AS Nomenclatura,
                     m.tb_materia_prima_marca AS Marca,
                     m.tb_materia_prima_lote AS Lote,
                     m.tb_materia_prima_dt_val AS Data_de_Validade,
                        m.tb_materia_prima_quantidade AS Quantidade,
                    f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_materia_prima m
                     INNER JOIN
                     tb_fornecedor f ON m.tb_fornecedor_id = f.tb_fornecedor_id";

            con.Open();

            DataTable tabela_estoqueMp = new DataTable();

            MySqlDataAdapter da_estoqueMp = new MySqlDataAdapter(sql_select_estoqueMp, con);
            da_estoqueMp.Fill(tabela_estoqueMp);

           //DgvEstoqueMp.DataSource = tabela_estoqueMp; mostrar no Datagridview

            con.Close();


        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Txt_dt_validade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_dt_fabricacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Txt_quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Txt_marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string nome = Txt_produto.Text;
            string marca = Txt_marca.Text;
            string lote = Txt_lote.Text;
            string quantidade = Txt_quantidade.Text;
            string dtVal = Txt_quantidade .Text;
            int cmbFornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);


            MySqlConnection con = new MySqlConnection(conexao);


            string sql_update_fornecedor = @"update tb_materia_prima 
                                  set tb_materia_prima_nomenclatura = @nome,
                                      tb_materia_prima_marca = @marca,
                                      tb_materia_prima_lote = @lote,
                                      tb_materia_prima_quantidade = @quantidade,
                                      tb_materia_prima_dt_val = @dtVal,
                                      tb_fornecedor_id = @cmbfornecedor
                                  where tb_materia_prima_id = @id";




            MySqlCommand executacmdMySql_update_fornecedor = new MySqlCommand(sql_update_fornecedor, con);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@marca", marca);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@lote", lote);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@quantidade", quantidade);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@dtVal", dtVal);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@cmbfornecedor", cmbFornecedor);

            con.Open();
            executacmdMySql_update_fornecedor.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");

            ListarEstoqueMp();

            con.Close();
        }
    }
}
