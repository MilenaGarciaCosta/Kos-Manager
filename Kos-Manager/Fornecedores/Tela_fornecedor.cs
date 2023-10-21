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
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
        int nLeftRect,     // x-coordenada superior esquerda
        int nTopRect,      // y-coordenada superior esquerda
        int nRightRect,    // x-coordenada inferior direita
        int nBottomRect,   // y-coordenada inferior direita
        int nWidthEllipse, // largura da elipse
        int nHeightEllipse // altura da elipse
);
        private void SetRoundedEdges(Control control, int curve)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, control.Width, control.Height, curve, curve);
            control.Region = System.Drawing.Region.FromHrgn(ptr);
            Marshal.Release(ptr);
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

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_fornecedor_Load(object sender, EventArgs e)
        {
            AtualizarTextBoxFornecedores();
        }

        private void Btn_adicionar_Click_1(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_add_fornecedor());
        }


        private void Child_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void AdicionarFornecedorAoPanel()
        {
            // Crie controles (por exemplo, Label) para exibir as informações do fornecedor
            Label lblNome = new Label();
            lblNome.Text = "Nome: " + Fornecedor.Nome;
            lblNome.Location = new Point(10, 10);

            Label lblProduto = new Label();
            lblProduto.Text = "Produto: " + Fornecedor.Produto;
            lblProduto.Location = new Point(10, 30);

            Label lblContato = new Label();
            lblContato.Text = "Contato: " + Fornecedor.Contato;
            lblContato.Location = new Point(10, 50);

            Label lblOutro = new Label();
            lblOutro.Text = "Outro meio de Contato: " + Fornecedor.Outro;
            lblOutro.Location = new Point(10, 70);
        }

        private void AtualizarTextBoxFornecedores()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_select = "SELECT tb_fornecedor_id, tb_fornecedor_nome, tb_fornecedor_produto, tb_fornecedor_contato, tb_fornecedor_outro_contato FROM tb_fornecedor";
                MySqlCommand cmd = new MySqlCommand(sql_select, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpar o conteúdo atual do Panel
                pnlFornecedores.Controls.Clear();

                int top = 10; // Posição vertical inicial

                while (reader.Read())
                {
                    // Ler as informações de cada fornecedor
                    string id = reader["tb_fornecedor_id"].ToString();
                    string nome = reader["tb_fornecedor_nome"].ToString();
                    string produto = reader["tb_fornecedor_produto"].ToString();
                    string contato = reader["tb_fornecedor_contato"].ToString();
                    string outro = reader["tb_fornecedor_outro_contato"].ToString();

                    // Criar uma nova TextBox para exibir as informações do fornecedor
                    TextBox txtFornecedor = new TextBox();
                    txtFornecedor.Multiline = true;
                    txtFornecedor.ReadOnly = true;
                    txtFornecedor.Text = $"Nome: {nome}\r\nProduto: {produto}\r\nContato: {contato}\r\nOutro meio de contato: {outro}";


                    //testegepeto 

                    txtFornecedor.Click += (sender, e) =>
                    {
                        abrirChildForm(new Tela_atualizar_fornecedor(id, nome, produto, contato, outro));
                    };





                    //style 


                    txtFornecedor.Top = top;

                    // Ajustar o tamanho da TextBox para corresponder à largura total do Panel
                    txtFornecedor.Width = pnlFornecedores.ClientSize.Width;

                    // Se o TextBox permitir várias linhas, você pode calcular a altura necessária com base no número de linhas.
                    int linesCount = txtFornecedor.Text.Split('\n').Length;
                    txtFornecedor.Height = linesCount * 20 + 20; // 20 é a altura aproximada por linha. Ajuste conforme necessário.

                    // Estilizar a TextBox
                    txtFornecedor.BackColor = System.Drawing.ColorTranslator.FromHtml("#84A98C");
                    txtFornecedor.ForeColor = System.Drawing.ColorTranslator.FromHtml("#171717");

                    // Adicionar margem interna (n funfo)
                    //txtFornecedor.Padding = new Padding(10);

                    //Border do capeta
                    SetRoundedEdges(txtFornecedor, 8);

                    // Alterar a fonte
                    Font font = new Font("Segoe UI", 13);
                    txtFornecedor.Font = font;

                    // O TextBox padrão não suporta alinhamento vertical, então essa linha foi comentada.
                    //txtFornecedor.TextAlign = ContentAlignment.MiddleCenter;

                    // Definir a borda da TextBox como None
                    txtFornecedor.BorderStyle = BorderStyle.None;

                    // Alterar o cursor para o estilo "pointer" (mãozinha)
                    txtFornecedor.Cursor = Cursors.Hand;

                    // Adicionar a TextBox ao Panel
                    pnlFornecedores.Controls.Add(txtFornecedor);

                    // Aumentar a posição vertical para a próxima TextBox
                    top += txtFornecedor.Height + 10; // 10 pixels de margem entre TextBoxes


                }

                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar fornecedores: " + erro);
            }


        }

        private void Txt_buscar_fornecedor_TextChanged(object sender, EventArgs e)
        {
            RealizarPesquisa(Txt_buscar_fornecedor.Text);
        }

        private void RealizarPesquisa(string termoPesquisa)
        {
            // Verifique se o termo de pesquisa não está vazio
            if (!string.IsNullOrEmpty(termoPesquisa))
            {
                // Limpar o conteúdo atual do Panel
                pnlFornecedores.Controls.Clear();

                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();

                        // Consulta SQL para pesquisar fornecedores com base no termo de pesquisa
                        string sqlSelect = "SELECT tb_fornecedor_id, tb_fornecedor_nome, tb_fornecedor_produto, " +
                                           "tb_fornecedor_contato, tb_fornecedor_outro_contato " +
                                           "FROM tb_fornecedor " +
                                           "WHERE tb_fornecedor_nome LIKE @termoPesquisa " +
                                           "OR tb_fornecedor_produto LIKE @termoPesquisa " +
                                           "OR tb_fornecedor_contato LIKE @termoPesquisa " +
                                           "OR tb_fornecedor_outro_contato LIKE @termoPesquisa";

                        MySqlCommand cmd = new MySqlCommand(sqlSelect, con);
                        cmd.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa + "%");

                        MySqlDataReader reader = cmd.ExecuteReader();

                        int top = 10; // Posição vertical inicial



                        while (reader.Read())
                        {
                            // Ler informações do fornecedor
                            string id = reader["tb_fornecedor_id"].ToString();
                            string nome = reader["tb_fornecedor_nome"].ToString();
                            string produto = reader["tb_fornecedor_produto"].ToString();
                            string contato = reader["tb_fornecedor_contato"].ToString();
                            string outro = reader["tb_fornecedor_outro_contato"].ToString();

                            // Criar TextBox para exibir informações do fornecedor
                            TextBox txtFornecedor = new TextBox();
                            txtFornecedor.Multiline = true;
                            txtFornecedor.ReadOnly = true;
                            txtFornecedor.Text = $"Nome: {nome}\r\nProduto: {produto}\r\nContato: {contato}\r\nOutro meio de contato: {outro}";


                            //style


                            txtFornecedor.Top = top;

                            // Ajustar o tamanho da TextBox para corresponder à largura total do Panel
                            txtFornecedor.Width = pnlFornecedores.ClientSize.Width;

                            // Se o TextBox permitir várias linhas, você pode calcular a altura necessária com base no número de linhas.
                            int linesCount = txtFornecedor.Text.Split('\n').Length;
                            txtFornecedor.Height = linesCount * 20 + 20; // 20 é a altura aproximada por linha. Ajuste conforme necessário.

                            // Estilizar a TextBox
                            txtFornecedor.BackColor = System.Drawing.ColorTranslator.FromHtml("#84A98C");
                            txtFornecedor.ForeColor = System.Drawing.ColorTranslator.FromHtml("#171717");

                            // Adicionar margem interna
                            txtFornecedor.Padding = new Padding(10);

                            //Border do capeta
                            SetRoundedEdges(txtFornecedor, 8);

                            // Alterar a fonte
                            Font font = new Font("Segoe UI", 13);
                            txtFornecedor.Font = font;

                            // O TextBox padrão não suporta alinhamento vertical, então essa linha foi comentada.
                            //txtFornecedor.TextAlign = ContentAlignment.MiddleCenter;

                            // Definir a borda da TextBox como None
                            txtFornecedor.BorderStyle = BorderStyle.None;

                            // Alterar o cursor para o estilo "pointer" (mãozinha)
                            txtFornecedor.Cursor = Cursors.Hand;

                            // Adicionar a TextBox ao Panel
                            pnlFornecedores.Controls.Add(txtFornecedor);

                            // Aumentar a posição vertical para a próxima TextBox
                            top += txtFornecedor.Height + 10; // 10 pixels de margem entre TextBoxes


                            // Adicione um evento de clique para abrir a tela de atualização do fornecedor
                            txtFornecedor.Click += (sender, e) =>
                            {
                                abrirChildForm(new Tela_atualizar_fornecedor(id, nome, produto, contato, outro));
                            };
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
                AtualizarTextBoxFornecedores();
            }
        }

        private void pnlFornecedores_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
