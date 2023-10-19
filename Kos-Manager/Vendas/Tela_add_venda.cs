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
    public partial class Tela_add_venda : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;


        public Tela_add_venda()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ListarVendas()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_venda = @"
                      SELECT
                     v.tb_venda_id AS Id,
                     v.tb_venda_quantidade AS Quantidade,
                     v.tb_venda_valor as Valor,
                     p.tb_produto_manu_nome AS Produto,
                     f.tb_funcionario_nome AS Funcionario,
                     s.tb_venda_status_nome AS venda
                    FROM
                     tb_venda v
                     INNER JOIN
                     tb_produto_manu p ON v.tb_produto_manu_id = p.tb_produto_manu_id
                        INNER JOIN
                     tb_funcionario f ON v.tb_funcionario_id = f.tb_funcionario_id
                              INNER JOIN
                     tb_venda_status s ON v.tb_venda_status_id = s.tb_venda_status_id";

            con.Open();

            DataTable tabela_venda = new DataTable();

            MySqlDataAdapter da_venda = new MySqlDataAdapter(sql_select_venda, con);
            da_venda.Fill(tabela_venda);

            //Dgv_venda.DataSource = tabela_venda; datagridview

            con.Close();


        }
        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                string valor = Txt_valor_produto.Text;
                int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
                int cmb_Venda_status = Convert.ToInt32(cmb_status.SelectedValue);

                // Força a cultura de interpretação para Português (Brasil)
                CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

                // Verifique se a quantidade é maior que 0 e se o valor é um número decimal válido

                if (int.TryParse(quantidade, out int quantidadeInt) && decimal.TryParse(valor, NumberStyles.AllowDecimalPoint, culturaBrasileira, out decimal valorDecimal) && quantidadeInt > 0)
                {
                    // Calcule o valor total com base na quantidade e no valor unitário
                    decimal valorTotal = quantidadeInt * valorDecimal;


                    string sql_insert = @"insert into TB_VENDA
        (  
           TB_VENDA_QUANTIDADE, 
           TB_VENDA_VALOR,
           TB_PRODUTO_MANU_ID, 
           TB_FUNCIONARIO_ID,
           TB_VENDA_STATUS_ID
         )
        values
        (
            @VENDA_QUANTIDADE, @VENDA_VALOR, @PRODUTO_MANU_ID, @FUNCIONARIO_ID, @VENDA_STATUS_ID
         )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@VENDA_QUANTIDADE", quantidadeInt);
                    executacmdMySql_insert.Parameters.AddWithValue("@VENDA_VALOR", valorTotal);
                    executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_ID", cmb_Produto);
                    executacmdMySql_insert.Parameters.AddWithValue("@FUNCIONARIO_ID", cmb_Funcionario);
                    executacmdMySql_insert.Parameters.AddWithValue("@VENDA_STATUS_ID", cmb_Venda_status);

                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();
                    ListarVendas();
                    con.Close();
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }

        }
    }
}
