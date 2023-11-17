﻿using Kos_Manager.Solicitação;
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

namespace Kos_Manager
{
    public partial class Tela_solicitacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_solicitacao()
        {
            InitializeComponent();
            ListarSolicitacao();
        }

        public void ListarSolicitacao()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"
                         SELECT
                     s.tb_solicitacao_id AS Id,
                     s.tb_solicitacao_quantidade as Quantidade,
                     t.tb_solicitacao_status_nome as Status,
                     m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                     p.TB_MATERIA_PRIMA_MARCA_NOME AS Marca,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_solicitacao s
                     INNER JOIN
                     TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
                        INNER JOIN
                     tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
                     INNER JOIN
                     tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id
                    INNER JOIN
                     tb_materia_prima_marca p ON p.tb_materia_prima_marca_id = s.tb_materia_prima_marca_id";

            con.Open();

            DataTable tabela_solicitacao = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(sql_select_solicitacao, con);
            da_solicitacao.Fill(tabela_solicitacao);

            Dgv_solicita.DataSource = tabela_solicitacao;

            con.Close();


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


        private void Pnl_mat_prima_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_solicitar_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_add_solicitacao());
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                int cmb_Status = Convert.ToInt32(cmb_status_solicitacao.SelectedValue);
                int cmb_Fornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
                int cmb_Marca = Convert.ToInt32(cmb_marca.SelectedValue);

                string sql_insert = @"insert into TB_SOLICITACAO
                (  
                 
                   TB_SOLICITACAO_QUANTIDADE,
                   TB_SOLICITACAO_STATUS_ID,
                   TB_MATERIA_PRIMA_ID, 
                   TB_MATERIA_PRIMA_MARCA_ID,
                   TB_FORNECEDOR_ID
            
                 )
                values
                (
                   @SOLICITACAO_QUANTIDADE, @SOLICITACAO_STATUS, @MATERIA_PRIMA_ID, @MATERIA_PRIMA_MARCA_ID, @FORNECEDOR_ID
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@SOLICITACAO_QUANTIDADE", quantidade);
                executacmdMySql_insert.Parameters.AddWithValue("@SOLICITACAO_STATUS", cmb_Status);
                executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_ID", cmb_Produto);
                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_ID", cmb_Fornecedor);
                executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_MARCA_ID", cmb_Marca);


                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarSolicitacao();
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
            string id = txt_cod.Text;
            string quantidade = Txt_quantidade.Text;
            int cmb_Status = Convert.ToInt32(cmb_status_solicitacao.SelectedValue);
            int cmb_Fornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);
            int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
            int cmb_Marca = Convert.ToInt32(cmb_marca.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string sql_update_tb_requisicao = @"
            UPDATE TB_SOLICITACAO
            SET TB_SOLICITACAO_QUANTIDADE = @quantidade,
                TB_SOLICITACAO_STATUS_ID = @status,
                TB_MATERIA_PRIMA_ID = @produto,
                TB_MATERIA_PRIMA_MARCA_ID = @marca,
                TB_FORNECEDOR_ID = @fornecedor
            WHERE TB_SOLICITACAO_ID = @id";


                MySqlCommand executacmdMySql_update_tb_requisicao = new MySqlCommand(sql_update_tb_requisicao, con);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@quantidade", quantidade);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@status", cmb_Status);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@produto", cmb_Produto);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@marca", cmb_Marca);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@fornecedor", cmb_Fornecedor);

                executacmdMySql_update_tb_requisicao.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso");
            }

            ListarSolicitacao();

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID da solicitação que deseja excluir
                string id = txt_cod.Text;

                MySqlConnection con = new MySqlConnection(conexao);

                // Define a consulta SQL para exclusão
                string sql_delete_tb_solicitacao = "DELETE FROM tb_solicitacao WHERE tb_solicitacao_id = @id";

                MySqlCommand executacmdMySql_delete_tb_solicitacao = new MySqlCommand(sql_delete_tb_solicitacao, con);
                executacmdMySql_delete_tb_solicitacao.Parameters.AddWithValue("@id", id);

                con.Open();
                executacmdMySql_delete_tb_solicitacao.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Exclusão realizada com sucesso");

                // Atualize a exibição da lista de solicitações
                ListarSolicitacao();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Child_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Tela_solicitacao_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"
                    SELECT
                     s.tb_solicitacao_id AS Id,
                     s.tb_solicitacao_quantidade as Quantidade,
                     t.tb_solicitacao_status_nome as Status,
                     m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                     p.TB_MATERIA_PRIMA_MARCA_NOME AS Marca,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_solicitacao s
                     INNER JOIN
                     TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
                        INNER JOIN
                     tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
                     INNER JOIN
                     tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id
                    INNER JOIN
                     tb_materia_prima_marca p ON p.tb_materia_prima_marca_id = s.tb_materia_prima_marca_id";

            string sql_select_produto = "select * from tb_materia_prima";
            string sql_select_fornecedor = "select * from tb_fornecedor";
            string sql_select_status = "select * from tb_solicitacao_status";
            string sql_select_marca = "select * from tb_materia_prima_marca";

            MySqlCommand executacmdMySql_select_solicitacao = new MySqlCommand(sql_select_solicitacao, con);
            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            con.Open();

            executacmdMySql_select_solicitacao.ExecuteNonQuery();
            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_fornecedor.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_solicitacao = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_fornecedor = new DataTable();
            DataTable tabela_status = new DataTable();
            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(executacmdMySql_select_solicitacao);
            da_solicitacao.Fill(tabela_solicitacao);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_fornecedor = new MySqlDataAdapter(executacmdMySql_select_fornecedor);
            da_fornecedor.Fill(tabela_fornecedor);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);


            Dgv_solicita.DataSource = tabela_solicitacao;


            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_MATERIA_PRIMA_NOMENCLATURA"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_MATERIA_PRIMA_ID";  //Pega os dados            
            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.SelectedItem = null;


            cmb_fornecedor.DataSource = tabela_fornecedor;

            cmb_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_fornecedor.DisplayMember = "TB_FORNECEDOR_NOME"; //Exibe os dados para o usuário
            cmb_fornecedor.ValueMember = "TB_FORNECEDOR_ID";  //Pega os dados            
            cmb_fornecedor.DataSource = tabela_fornecedor;

            cmb_fornecedor.SelectedItem = null;


            cmb_marca.DataSource = tabela_marca;

            cmb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca.DisplayMember = "TB_MATERIA_PRIMA_MARCA_NOME"; // Exibe os dados para o usuário
            cmb_marca.ValueMember = "TB_MATERIA_PRIMA_MARCA_ID"; // Pega os dados

            cmb_marca.SelectedItem = null;

            cmb_status_solicitacao.DataSource = tabela_status;

            cmb_status_solicitacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_solicitacao.DisplayMember = "TB_SOLICITACAO_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_solicitacao.ValueMember = "TB_SOLICITACAO_STATUS_ID";  //Pega os dados            
            cmb_status_solicitacao.DataSource = tabela_status;

            cmb_status_solicitacao.SelectedItem = null;

        }
    }
}
