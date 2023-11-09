    using Kos_Manager.Matéria_prima;
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
        public partial class Tela_mat_prima : Form
        {
            string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

            public Tela_mat_prima()
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


            private void Txt_buscar_fornecedor_TextChanged(object sender, EventArgs e)
            {

            }

            private void Lbl_fornecedor_Click(object sender, EventArgs e)
            {

            }

            private void Child_panel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void guna2HtmlLabel2_Click(object sender, EventArgs e)
            {

            }

            private void Btn_adicionar_Click(object sender, EventArgs e)
            {
                abrirChildForm(new Tela_add_mat_prima());
            }

            private void Btn_solicitar_Click(object sender, EventArgs e)
            {
                abrirChildForm(new Tela_solicitacao());
            }

            private void Pnl_mat_prima_Paint(object sender, PaintEventArgs e)
            {

            }

            public void AdicionarPrimaAoPanel()
            {
                // Crie controles (por exemplo, Label) para exibir as informações do fornecedor
                Label lblNomenclatura = new Label();
                lblNomenclatura.Text = "Nomenclatura: " + Prima.nomenclatura;
                lblNomenclatura.Location = new Point(10, 10);


                Label lbllote = new Label();
                lbllote.Text = "Data de validade: " + Prima.lote;
                lbllote.Location = new Point(10, 30);

                Label lbldtval = new Label();
                lbldtval.Text = "Quantos lotes: " + Prima.dtval;
                lbldtval.Location = new Point(10, 50);

                Label lblquantidade = new Label();
                lblquantidade.Text = " Quantidade: " + Prima.marca;
                lblquantidade.Location = new Point(10, 70);

                Label lblmarca = new Label();
                lblmarca.Text = " Quantidade: " + Prima.quantidade;
                lblmarca.Location = new Point(10, 70); 

                Label lblidfornecedor = new Label();
                lblidfornecedor.Text = " fornecedor: " + Prima.fornecedorID;
                lblidfornecedor.Location = new Point(10, 110);
            }

            public void AtualizarTextBoxPrima()
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);
                    string sql_select = @"
    SELECT 
                    v.tb_materia_prima_id,
                    v.tb_materia_prima_nomenclatura as Produto,
                    v.tb_materia_prima_lote as Lote,
                    v.tb_materia_prima_marca as Marca, 
                    v.tb_materia_prima_dt_val as Validade,
                    v.tb_materia_prima_quantidade as Quantidade,
                    f.tb_fornecedor_nome AS fornecedor,
                    v.tb_materia_prima_id AS id

                    FROM tb_materia_prima v 

                        INNER JOIN
                        tb_fornecedor f  ON v.tb_fornecedor_id = f.tb_fornecedor_id  
    ";

                    MySqlCommand cmd = new MySqlCommand(sql_select, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Limpar o conteúdo atual do Panel
                    Pnl_mat_prima.Controls.Clear();


                    int top = 10; // Posição vertical inicial

                    while (reader.Read())
                    {
                        // Ler as informações de cada fornecedor
                        string id = reader["tb_materia_prima_id"].ToString();
                        string nome = reader["Produto"].ToString(); // Aguarde até que o registro seja lido
                        string lote = reader["lote"].ToString();
                        string marca = reader["Marca"].ToString();
                        string dataval = reader["Validade"].ToString();
                        string quantidade = reader["Quantidade"].ToString();
                        string fornecedorID = reader["fornecedor"].ToString();

                        // Criar uma nova TextBox para exibir as informações do fornecedor
                        TextBox txtManu = new TextBox();
                        txtManu.Multiline = true;
                        txtManu.ReadOnly = true;
                        txtManu.Text = $"ID: {id}, Nome: {nome}, marca: {marca}, Quantidade: {quantidade}, Lote: {lote}, Data de validade: {dataval}, fornecedor: {fornecedorID}";


                        // testegepto 

                          txtManu.Click += (sender, e) =>
                          {
                              abrirChildForm(new Tela_atualizar_mat_prima(id, nome,  marca, quantidade, lote, dataval, fornecedorID));
                          
                          };





                        // style 


                        // Definir a posição vertical da TextBox
                        txtManu.Top = top;

                        // Ajustar o tamanho da TextBox conforme necessário
                        txtManu.Width = Pnl_mat_prima.Width - 20; // Subtrair margens
                        txtManu.Height = 60; // Altura da TextBox

                        // Adicionar a TextBox ao Panel
                        Pnl_mat_prima.Controls.Add(txtManu);

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

            private void Tela_mat_prima_Load(object sender, EventArgs e)
            {
                AtualizarTextBoxPrima();
            }
        }
    }
