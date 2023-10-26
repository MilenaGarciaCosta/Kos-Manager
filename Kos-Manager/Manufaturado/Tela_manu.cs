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
using Kos_Manager.Estoque_manu;

namespace Kos_Manager
{
    public partial class Tela_manu : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;


        public Tela_manu()
        {
            InitializeComponent();
        }
        private Form FormAtivo = null;
        private void abrirChildForm(Form ChildForm)
        {
            if (FormAtivo != null)
                FormAtivo.Close();
            FormAtivo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Child_panel.Controls.Add(ChildForm);
            Child_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        public void AdicionarFornecedorAoPanel()
        {
            // Crie controles (por exemplo, Label) para exibir as informações do fornecedor
            Label lblNome = new Label();
            lblNome.Text = "Nome: " + Manu.nome;
            lblNome.Location = new Point(10, 10);

            Label lbldatafab = new Label();
            lbldatafab.Text = "Data de fabricação: " + Manu.datafab;
            lbldatafab.Location = new Point(10, 30);

            Label lbldataval = new Label();
            lbldataval.Text = "Data de validade: " + Manu.dataval;
            lbldataval.Location = new Point(10, 50);

            Label lbllote = new Label();
            lbllote.Text = "Quantos lotes: " + Manu.lote;
            lbllote.Location = new Point(10, 70);

            Label lblquantidade = new Label();
            lblquantidade.Text = " Quantidade: " + Manu.quantidade;
            lblquantidade.Location = new Point(10, 90);
        }


        private void AtualizarTextBoxProdutoManu()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_select = "SELECT tb_produto_manu_id, tb_produto_manu_nome, tb_produto_manu_dt_fab, tb_produto_manu_dt_val, tb_produto_manu_lote, tb_produto_manu_quantidade FROM tb_produto_manu";
                MySqlCommand cmd = new MySqlCommand(sql_select, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpar o conteúdo atual do Panel
                Pnl_produto_manu.Controls.Clear();


                int top = 10; // Posição vertical inicial


                while (reader.Read())
                {
                    // Ler as informações de cada fornecedor
                    string id = reader["tb_produto_manu_id"].ToString();
                    string nome = reader["tb_produto_manu_nome"].ToString();
                    string datafab = reader["tb_produto_manu_dt_fab"].ToString();
                    string dataval = reader["tb_produto_manu_dt_val"].ToString();
                    string lote = reader["tb_produto_manu_lote"].ToString();
                    string quantidade = reader["tb_produto_manu_quantidade"].ToString();

                    // Criar uma nova TextBox para exibir as informações do fornecedor
                    TextBox txtManu = new TextBox();
                    txtManu.Multiline = true;
                    txtManu.ReadOnly = true;
                    txtManu.Text = $"Nome: {nome}, Data de fabricação: {datafab}, Data de validade: {dataval}, Quantos lotes: {lote}, Quantidade: {quantidade}";


                    //testegepeto 

                    txtManu.Click += (sender, e) =>
                   {
                       abrirChildForm(new Tela_atualizar_manu(id, nome, datafab, dataval, lote, quantidade));
                   };





                    //style 


                    // Definir a posição vertical da TextBox
                    txtManu.Top = top;

                    // Ajustar o tamanho da TextBox conforme necessário
                    txtManu.Width = Pnl_produto_manu.Width - 20; // Subtrair margens
                    txtManu.Height = 60; // Altura da TextBox

                    // Adicionar a TextBox ao Panel
                    Pnl_produto_manu.Controls.Add(txtManu);

                    // Aumentar a posição vertical para a próxima TextBox
                    top += txtManu.Height + 10; // 10 pixels de margem entre TextBoxes
                }

                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar fornecedores: " + erro);
            }


        }


        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_add_manu());
        }

        private void Btn_requisitar_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_requisicao());
        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_manu_Load(object sender, EventArgs e)
        {
            AtualizarTextBoxProdutoManu();
        }

        private void Txt_buscar_produto_manu_TextChanged(object sender, EventArgs e)
        {
            RealizarPesquisa(Txt_buscar_produto_manu.Text);
        }
        private void RealizarPesquisa(string termoPesquisa)
        {
            // Verifique se o termo de pesquisa não está vazio
            if (!string.IsNullOrEmpty(termoPesquisa))
            {
                // Limpar o conteúdo atual do Panel
                Pnl_produto_manu.Controls.Clear();

                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();

                        // Consulta SQL para pesquisar fornecedores com base no termo de pesquisa
                        string sqlSelect = "SELECT tb_produto_manu_id, tb_produto_manu_nome, tb_produto_manu_dt_fab, " +
                                           "tb_manu_dt_val, tb_produto_manu_lote, tb_produto_manu_quantidade " +
                                           "FROM tb_produto_manu " +
                                           "WHERE tb_produto_manu_nome LIKE @termoPesquisa " +
                                           "OR tb_produto_manu_dt_fab LIKE @termoPesquisa " +
                                           "OR tb_produto_manu_dt_val LIKE @termoPesquisa " +
                                           "OR tb_produto_manu_lote LIKE @termoPesquisa " +
                                           "OR tb_produto_manu_quantidade LIKE @termoPesquisa";

                        MySqlCommand cmd = new MySqlCommand(sqlSelect, con);
                        cmd.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa + "%");

                        MySqlDataReader reader = cmd.ExecuteReader();

                        int top = 10; // Posição vertical inicial



                        while (reader.Read())
                        {
                            // Ler as informações de cada fornecedor
                            string id = reader["tb_produto_manu_id"].ToString();
                            string nome = reader["tb_produto_manu_nome"].ToString();
                            string datafab = reader["tb_produto_manu_dt_fab"].ToString();
                            string dataval = reader["tb_produto_manu_dt_val"].ToString();
                            string lote = reader["tb_produto_manu_lote"].ToString();
                            string quantidade = reader["tb_produto_manu_quantidade"].ToString();

                            // Criar uma nova TextBox para exibir as informações do fornecedor
                            TextBox txtManu = new TextBox();
                            txtManu.Multiline = true;
                            txtManu.ReadOnly = true;
                            txtManu.Text = $"Nome: {nome}, Data de fabricação: {datafab}, Data de validade: {dataval}, Quantos lotes: {lote}, Quantidade: {quantidade}";


                            //testegepeto 

                            txtManu.Click += (sender, e) =>
                            {
                                abrirChildForm(new Tela_atualizar_manu(id, nome, datafab, dataval, lote, quantidade));
                            };





                            //style 


                            // Definir a posição vertical da TextBox
                            txtManu.Top = top;

                            // Ajustar o tamanho da TextBox conforme necessário
                            txtManu.Width = Pnl_produto_manu.Width - 20; // Subtrair margens
                            txtManu.Height = 60; // Altura da TextBox

                            // Adicionar a TextBox ao Panel
                            Pnl_produto_manu.Controls.Add(txtManu);

                            // Aumentar a posição vertical para a próxima TextBox
                            top += txtManu.Height + 10; // 10 pixels de margem entre TextBoxes
                        }

                        con.Close();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao realizar a pesquisa: " + erro);
                }
            }
            else
            {
                // Se o campo de pesquisa estiver vazio, atualize o Panel com todos os fornecedores
               // AtualizarTextBoxFornecedores();
            }
        }

        private void Pnl_produto_manu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
