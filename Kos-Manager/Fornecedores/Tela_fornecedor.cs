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

   
    public partial class Tela_fornecedor : Form
    {



        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;


        public Tela_fornecedor()
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

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_atualizar_fornecedor());
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

           
        }

        private void AtualizarTextBoxFornecedores()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_select = "SELECT tb_fornecedor_nome, tb_fornecedor_produto, tb_fornecedor_contato FROM tb_fornecedor";
                MySqlCommand cmd = new MySqlCommand(sql_select, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpar o conteúdo atual do Panel
                pnlFornecedores.Controls.Clear();

                int top = 10; // Posição vertical inicial

                while (reader.Read())
                {
                    // Ler as informações de cada fornecedor
                    string nome = reader["tb_fornecedor_nome"].ToString();
                    string produto = reader["tb_fornecedor_produto"].ToString();
                    string contato = reader["tb_fornecedor_contato"].ToString();

                    // Criar uma nova TextBox para exibir as informações do fornecedor
                    TextBox txtFornecedor = new TextBox();
                    txtFornecedor.Multiline = true;
                    txtFornecedor.ReadOnly = true;
                    txtFornecedor.Text = $"Nome: {nome}, Produto: {produto}, Contato: {contato}";


                    //testegepeto 

                    txtFornecedor.Click += (sender, e) =>
                    {
                        //Tela_atualizar_fornecedor tela_atualizar = new Tela_atualizar_fornecedor(nome, produto, contato);
                        abrirChildForm(new Tela_atualizar_fornecedor(nome, produto, contato));
                        //tela_atualizar.ShowDialog();
                    };




                    // Definir a posição vertical da TextBox
                    txtFornecedor.Top = top;

                    // Ajustar o tamanho da TextBox conforme necessário
                    txtFornecedor.Width = pnlFornecedores.Width - 20; // Subtrair margens
                    txtFornecedor.Height = 60; // Altura da TextBox

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

    }
}
