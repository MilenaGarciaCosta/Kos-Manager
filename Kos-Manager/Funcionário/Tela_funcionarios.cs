using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Kos_Manager
{
    public partial class Tela_funcionarios : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

        public Tela_funcionarios()
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void txt_buscar_func_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_func_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click_1(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_add_funcionario());
        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_buscar_func_TextChanged_1(object sender, EventArgs e)
        {
            RealizarPesquisa(txt_buscar_func.Text);
        }
        private void RealizarPesquisa(string termoPesquisa)
        {
            // Verifique se o termo de pesquisa não está vazio
            if (!string.IsNullOrEmpty(termoPesquisa))
            {
                // Limpar o conteúdo atual do Panel
                pnlFuncionario.Controls.Clear();

                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();

                        // Consulta SQL para pesquisar fornecedores com base no termo de pesquisa
                        string sqlSelect = "SELECT TB_FUNCIONARIO_ID, TB_FUNCIONARIO_NOME, TB_FUNCIONARIO_EMAIL, " +
                                           "TB_FUNCIONARIO_SENHA, TB_STATUS_ID, TB_NIVEL_ACESSO_ID" +
                                           "FROM tb_funcionario " +
                                           "WHERE TB_FUNCIONARIO_NOME  LIKE @termoPesquisa " +
                                           "OR TB_FUNCIONARIO_EMAIL LIKE @termoPesquisa " +
                                           "OR TB_FUNCIONARIO_SENHA LIKE @termoPesquisa " +
                                           "OR TB_STATUS_ID LIKE @termoPesquisa " +
                                           "OR TB_NIVEL_ACESSO_ID LIKE @termoPesquisa";

                        MySqlCommand cmd = new MySqlCommand(sqlSelect, con);
                        cmd.Parameters.AddWithValue("@termoPesquisa", "%" + termoPesquisa + "%");

                        MySqlDataReader reader = cmd.ExecuteReader();

                        int top = 10; // Posição vertical inicial



                        while (reader.Read())
                        {
                            // Ler as informações de cada fornecedor
                            string id = reader["TB_FUNCIONARIO_ID"].ToString();
                            string nome = reader["TB_FUNCIONARIO_NOME"].ToString();
                            string email = reader["TB_FUNCIONARIO_EMAIL"].ToString();
                            string senha = reader["TB_FUNCIONARIO_SENHA"].ToString();
                            string status = reader["TB_STATUS_ID"].ToString();
                            string nivel = reader["TB_NIVEL_ACESSO_ID"].ToString();

                            // Criar uma nova TextBox para exibir as informações do fornecedor
                            TextBox txtManu = new TextBox();
                            txtManu.Multiline = true;
                            txtManu.ReadOnly = true;
                            txtManu.Text = $"Nome: {nome}, E-mail: {email}, Senha: {senha}, Status : {status}, Nível de Acesso: {nivel}";






                            //style 


                            // Definir a posição vertical da TextBox
                            txtManu.Top = top;

                            // Ajustar o tamanho da TextBox conforme necessário
                            txtManu.Width = pnlFuncionario.Width - 20; // Subtrair margens
                            txtManu.Height = 60; // Altura da TextBox

                            // Adicionar a TextBox ao Panel
                            pnlFuncionario.Controls.Add(txtManu);

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

        private void PnlFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
