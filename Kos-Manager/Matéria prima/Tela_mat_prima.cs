﻿        using System;
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
       using System.Globalization;

    namespace Kos_Manager
        {
            public partial class Tela_mat_prima : Form
            {
                string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

                public Tela_mat_prima()
                {
                    InitializeComponent();
                    ListarEstoqueMp();

                }

                string id;

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

                    DgvEstoqueMp.DataSource = tabela_estoqueMp;

                    con.Close();


                }
            

                    private void Tela_mat_prima_Load(object sender, EventArgs e)
                    {
                //MOSTRAR OS DADOS DO COMBOBOX

                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_select_estoque = @"
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
                    string sql_select_fornecedor = "select * from tb_fornecedor";



                    MySqlCommand executacmdMySql_select_estoque = new MySqlCommand(sql_select_estoque, con);
                    MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, con);

                    con.Open();

                    executacmdMySql_select_estoque.ExecuteNonQuery();
                    executacmdMySql_select_fornecedor.ExecuteNonQuery();


                    DataTable tabela_estoque = new DataTable();
                    DataTable tabela_fornecedor = new DataTable();


                    MySqlDataAdapter da_estoque = new MySqlDataAdapter(executacmdMySql_select_estoque);
                    da_estoque.Fill(tabela_estoque);

                    MySqlDataAdapter da_fornecedor = new MySqlDataAdapter(executacmdMySql_select_fornecedor);
                    da_fornecedor.Fill(tabela_fornecedor);


                    DgvEstoqueMp.DataSource = tabela_estoque;

                    cmb_fornecedor.DataSource = tabela_fornecedor;

                    cmb_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb_fornecedor.DisplayMember = "TB_FORNECEDOR_NOME"; //Exibe os dados para o usuário
                    cmb_fornecedor.ValueMember = "TB_FORNECEDOR_ID";  //Pega os dados            
                    cmb_fornecedor.DataSource = tabela_fornecedor;

                    cmb_fornecedor.SelectedItem = null;

            }

            private void Btn_adicionar_Click_1(object sender, EventArgs e)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome = txt_produto.Text;
                    string marca = Txt_marca.Text;
                    string lote = Txt_lote.Text;
                    string quantidade = Txt_quantidade.Text;
                    DateTime dtVal = DateTime.ParseExact(Txt_dt_validade.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Converter a data para DateTime
                    string formattedDate = dtVal.ToString("yyyy-MM-dd"); // Formatar a data no formato MySQL
                    int cmbFornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);

                    string sql_insert = @"insert into tb_materia_prima
                    (  
                       tb_materia_prima_nomenclatura, 
                        TB_MATERIA_PRIMA_MARCA, 
                        TB_MATERIA_PRIMA_LOTE,
                        TB_MATERIA_PRIMA_DT_VAL,
                        TB_MATERIA_PRIMA_QUANTIDADE,
                        TB_FORNECEDOR_ID
                     )
                    values
                    (
                        @materia_prima_nomenclatura, @MATERIA_PRIMA_MARCA, @MATERIA_PRIMA_LOTE, @MATERIA_PRIMA_DT_VAL, @MATERIA_PRIMA_QUANTIDADE, @FORNECEDOR_ID
                     )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@materia_prima_nomenclatura", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_MARCA", marca);
                    executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_LOTE", lote);
                    executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_DT_VAL", formattedDate); // Usar a data formatada para MySQL
                    executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_QUANTIDADE", quantidade);
                    executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_ID", cmbFornecedor);

                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();
                    ListarEstoqueMp();
                    con.Close();
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Aconteceu o Erro: " + erro);
                }
            }

            private void Btn_atualizar_Click(object sender, EventArgs e)
            {
                string nome = txt_produto.Text;
                string marca = Txt_marca.Text;
                string lote = Txt_lote.Text;
                string quantidade = Txt_quantidade.Text;
                DateTime dtVal = DateTime.ParseExact(Txt_dt_validade.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Converter a data para DateTime
                string formattedDate = dtVal.ToString("yyyy-MM-dd"); // Formatar a data no formato MySQL
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
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@dtVal", formattedDate);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@cmbfornecedor", cmbFornecedor);

                con.Open();
                executacmdMySql_update_fornecedor.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso");

                ListarEstoqueMp();

                con.Close();
            }

            private void Btn_deletar_Click(object sender, EventArgs e)
            {
                // Declarando variável e inserindo conteúdo do textbox nela
                int codigo = int.Parse(this.id);

                // Conectando ao banco de dados MySql
                MySqlConnection con = new MySqlConnection(conexao);

                // Abrindo conexão
                con.Open();

                string sql_delete_materia_prima = @"DELETE FROM tb_materia_prima WHERE tb_materia_prima_id = @codigo";

                MySqlCommand executarcmdMySql_delete_materia_prima = new MySqlCommand(sql_delete_materia_prima, con);

                executarcmdMySql_delete_materia_prima.Parameters.AddWithValue("@codigo", codigo);

                executarcmdMySql_delete_materia_prima.ExecuteNonQuery();

                MessageBox.Show("Registro deletado com sucesso");
                ListarEstoqueMp();

                // Fechando conexão
                con.Close();
            }

            private void Btn_voltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void DgvEstoqueMp_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                this.id = DgvEstoqueMp.CurrentRow.Cells[0].Value.ToString();
                txt_produto.Text = DgvEstoqueMp.CurrentRow.Cells[1].Value.ToString();
                Txt_marca.Text = DgvEstoqueMp.CurrentRow.Cells[2].Value.ToString();
                Txt_dt_validade.Text = DgvEstoqueMp.CurrentRow.Cells[3].Value.ToString();
                Txt_lote.Text = DgvEstoqueMp.CurrentRow.Cells[4].Value.ToString();
                Txt_quantidade.Text = DgvEstoqueMp.CurrentRow.Cells[5].Value.ToString();
                cmb_fornecedor.Text = DgvEstoqueMp.CurrentRow.Cells[6].Value.ToString();
            }
        }
        }
