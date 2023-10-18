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


namespace Kos_Manager.Estoque_manu
{
    public partial class Tela_atualizar_manu : Form
    {

        public event EventHandler ManuAtualizado;

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

        string id;

        public Tela_atualizar_manu( string id, string nome, string datafab, string dataval, string lote, string quantidade)
        {


            InitializeComponent();
            this.id = id;
            Txt_nome_produto_manu.Text = nome;
            Txt_dt_fab.Text = datafab;
            Txt_dt_validade.Text = dataval;
            Txt_lote.Text = lote;
            Txt_quantidade.Text = quantidade;
            
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Txt_dt_fab_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            string nomeManu = Txt_nome_produto_manu.Text; // Obtenha o nome do fornecedor do campo de texto

            if (!string.IsNullOrWhiteSpace(nomeManu))
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();
                        string sql_delete = "DELETE FROM TB_PRODUTO_MANU WHERE TB_PRODUTO_MANU_NOME = @nomeFornecedor";
                        MySqlCommand cmd = new MySqlCommand(sql_delete, con);
                        cmd.Parameters.AddWithValue("@nomeFornecedor", nomeManu);
                        cmd.ExecuteNonQuery();

                    }

                    // Após uma exclusão bem-sucedida
                    ManuAtualizado?.Invoke(this, EventArgs.Empty);




                    MessageBox.Show("Fornecedor excluído com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Digite o nome do fornecedor para excluí-lo.");
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string novoNome = Txt_nome_produto_manu.Text;
            string novoDtfab = Txt_dt_fab.Text;
            string novoDtval = Txt_dt_validade.Text;
            string novoLote = Txt_lote.Text;
            string novoQuantidade = Txt_quantidade.Text;

            if (!string.IsNullOrWhiteSpace(this.id))
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();

                        // Atualize os dados do fornecedor na tabela
                        string sql_update = "UPDATE TB_PRODUTO_MANU SET TB_PRODUTO_MANU_NOME = @novoNome, " +
                     "TB_PRODUTO_MANU_DT_FAB = @novoDtfab, " +
                     "TB_PRODUTO_MANU_DT_VAL = @novoDtval, " +
                     "TB_PRODUTO_MANU_LOTE = @novoLote, " +
                     "TB_PRODUTO_MANU_QUANTIDADE = @novoQuantidade " +
                     "WHERE TB_PRODUTO_MANU_ID = @nomeManu";


                        MySqlCommand cmd = new MySqlCommand(sql_update, con);
                        cmd.Parameters.AddWithValue("@novoNome", novoNome);
                        cmd.Parameters.AddWithValue("@novoDtfab", novoDtfab);
                        cmd.Parameters.AddWithValue("@novoDtval", novoDtval);
                        cmd.Parameters.AddWithValue("@novoLote", novoLote);
                        cmd.Parameters.AddWithValue("@novoQuantidade", novoQuantidade);
                        cmd.Parameters.AddWithValue("@nomeManu", this.id);
                        cmd.ExecuteNonQuery();
                    }


                    // Após a atualização bem-sucedida
                    ManuAtualizado?.Invoke(this, EventArgs.Empty);



                    MessageBox.Show("Fornecedor atualizado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Digite o nome do fornecedor para atualizá-lo.");
            }

        }
    }
}
