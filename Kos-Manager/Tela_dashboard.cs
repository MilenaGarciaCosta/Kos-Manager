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
            CarregarProdutosComMenorQuantidadeMAT();
            CarregarProdutosComMenorQuantidadePRIM();
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

        private void CarregarProdutosComMenorQuantidadeMAT()
        {

            using (MySqlConnection connection = new MySqlConnection(conexao))
            try
            {
                // Abrir a conexão com o banco de dados
                connection.Open();

                // Consulta SQL para obter os três produtos com menores quantidades
                string query = "SELECT TB_PRODUTO_MANU_NOME, TB_PRODUTO_MANU_QUANTIDADE " +
                               "FROM tb_produto_manu " +
                               "ORDER BY TB_PRODUTO_MANU_QUANTIDADE ASC " +
                               "LIMIT 3";

                // Criar um adaptador de dados
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao))
                {
                    // Preencher um DataTable com os resultados da consulta
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Verificar se há pelo menos um produto retornado
                    if (dataTable.Rows.Count > 0)
                    {
                        // Preencher as labels com os nomes e quantidades dos produtos
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            string nomeProduto = dataTable.Rows[i]["TB_PRODUTO_MANU_NOME"].ToString();
                            int quantidadeProduto = Convert.ToInt32(dataTable.Rows[i]["TB_PRODUTO_MANU_QUANTIDADE"]);

                            // Exibir as informações nas labels correspondentes
                            if (i == 0)
                                Lbl_manu_top1.Text = $"{nomeProduto} ({quantidadeProduto})";
                            else if (i == 1)
                                Lbl_manu_top2.Text = $"{nomeProduto} ({quantidadeProduto})";
                            else if (i == 2)
                                Lbl_manu_top3.Text = $"{nomeProduto} ({quantidadeProduto})";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratar exceções, se necessário
                MessageBox.Show($"Erro ao obter os produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fechar a conexão com o banco de dados, independentemente do resultado
                connection.Close();
            }
        }

        private void CarregarProdutosComMenorQuantidadePRIM()
        {
            // Lista para armazenar os nomes dos produtos com menor quantidade
            using (MySqlConnection connection = new MySqlConnection(conexao))
                try
                {
                    // Abrir a conexão com o banco de dados
                    connection.Open();

                    // Consulta SQL para obter os três produtos com menores quantidades
                    string query = "SELECT TB_MATERIA_PRIMA_NOMENCLATURA, TB_MATERIA_PRIMA_QUANTIDADE " +
                                   "FROM tb_materia_prima " +
                                   "ORDER BY TB_MATERIA_PRIMA_QUANTIDADE ASC " +
                                   "LIMIT 3";

                    // Criar um adaptador de dados
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao))
                    {
                        // Preencher um DataTable com os resultados da consulta
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Verificar se há pelo menos um produto retornado
                        if (dataTable.Rows.Count > 0)
                        {
                            // Preencher as labels com os nomes e quantidades dos produtos
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                string nomeProduto = dataTable.Rows[i]["TB_MATERIA_PRIMA_NOMENCLATURA"].ToString();
                                int quantidadeProduto = Convert.ToInt32(dataTable.Rows[i]["TB_MATERIA_PRIMA_QUANTIDADE"]);

                                // Exibir as informações nas labels correspondentes
                                if (i == 0)
                                    Lbl_mat1.Text = $"{nomeProduto} ({quantidadeProduto})";
                                else if (i == 1)
                                    Lbl_mat2.Text = $"{nomeProduto} ({quantidadeProduto})";
                                else if (i == 2)
                                    Lbl_mat3.Text = $"{nomeProduto} ({quantidadeProduto})";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Tratar exceções, se necessário
                    MessageBox.Show($"Erro ao obter os produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Fechar a conexão com o banco de dados, independentemente do resultado
                    connection.Close();
                }
        }

    }

    }