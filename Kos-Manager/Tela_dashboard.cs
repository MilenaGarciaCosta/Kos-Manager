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

namespace Kos_Manager
{
    public partial class Tela_dashboard : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_dashboard()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void Tela_dashboard_Load(object sender, EventArgs e)
        {
            ExibirNumeroTotalFuncionarios();
            ExibirSomaValoresVenda();
            ExibirProdutosMaisVendidos();
        }
        private void ExibirNumeroTotalFuncionarios()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conexao))
                {
                    connection.Open();

                    // Consulta SQL para obter o número total de funcionários
                    string query = "SELECT COUNT(*) FROM tb_funcionario";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // ExecuteScalar é usado para obter um valor único (o número total de funcionários neste caso)
                        int numeroTotalFuncionarios = Convert.ToInt32(command.ExecuteScalar());

                        // Exiba o número total de funcionários na label
                        Lbl_nmr_funcionario.Text = $"{numeroTotalFuncionarios}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExibirSomaValoresVenda()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conexao))
                {
                    connection.Open();

                    // Consulta SQL para obter a soma dos valores de venda
                    string query = "SELECT SUM(TB_VENDA_VALOR) FROM tb_venda";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // ExecuteScalar é usado para obter um valor único (a soma dos valores de venda neste caso)
                        object resultado = command.ExecuteScalar();

                        // Verifica se o resultado não é nulo antes de converter para evitar exceção
                        if (resultado != DBNull.Value)
                        {
                            decimal somaValoresVenda = Convert.ToDecimal(resultado);

                            // Exiba a soma dos valores de venda na label
                            Lbl_total_venda.Text = $"R$ {somaValoresVenda:N2}";
                        }
                        else
                        {
                            // Se o resultado for nulo, significa que não há vendas cadastradas
                            Lbl_total_venda.Text = "ND";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObterNomeProdutoPorID(int produtoID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conexao))
                {
                    connection.Open();

                    // Consulta SQL para obter o nome do produto com base no ID
                    string query = "SELECT TB_PRODUTO_MANU_NOME FROM tb_produto_manu WHERE TB_PRODUTO_MANU_ID = @ProdutoID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProdutoID", produtoID);

                        object resultado = command.ExecuteScalar();

                        // Verifica se o resultado não é nulo antes de converter para evitar exceção
                        if (resultado != DBNull.Value)
                        {
                            return resultado.ToString();
                        }
                        else
                        {
                            return "Nome do Produto Desconhecido";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter o nome do produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Nome do Produto Desconhecido";
            }
        }

        private void ExibirProdutosMaisVendidos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conexao))
                {
                    connection.Open();

                    // Consulta SQL para obter os quatro produtos mais vendidos
                    string query = @"
                SELECT 
                    p.TB_PRODUTO_MANU_ID,
                    COUNT(*) AS total_venda
                FROM
                    tb_venda v
                INNER JOIN
                    tb_produto_manu p ON v.TB_PRODUTO_MANU_ID = p.TB_PRODUTO_MANU_ID
                GROUP BY
                    p.TB_PRODUTO_MANU_ID
                ORDER BY
                    total_venda DESC
                LIMIT 3;
            ";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int labelIndex = 1;

                            // Iterar pelos resultados e exibir nas labels correspondentes
                            while (reader.Read() && labelIndex <= 3)
                            {
                                string produtoNome = ObterNomeProdutoPorID(Convert.ToInt32(reader["TB_PRODUTO_MANU_ID"]));

                                // Encontrar a label pelo nome
                                Label label = Controls.Find($"Lbl_mais_{labelIndex}", true).FirstOrDefault() as Label;

                                // Verificar se a label foi encontrada antes de tentar modificá-la
                                if (label != null)
                                {
                                    label.Text = $"{produtoNome}: {reader["total_venda"]} vendas";
                                }

                                labelIndex++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter os produtos mais vendidos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}