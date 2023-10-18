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

    public partial class Tela_atualizar_fornecedor : Form
    {


        public event EventHandler FornecedorAtualizado;



        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

        string id;


        public Tela_atualizar_fornecedor(string id,
                                         string nome,
                                         string produto,
                                         string contato,
                                         string outro)
        {
            InitializeComponent();

            // Define os valores dos campos de texto com os dados do fornecedor
            this.id = id;
            Txt_nome_fornecedor.Text = nome;
            Txt_produto_fornecido.Text = produto;
            Txt_tel_fornecedor.Text = contato;
            Txt_outro_contato_fornecedor.Text = outro;
        }


        public Tela_atualizar_fornecedor()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string novoNome = Txt_nome_fornecedor.Text;
            string novoProduto = Txt_produto_fornecido.Text;
            string novoContato = Txt_tel_fornecedor.Text;
            string novoOutro = Txt_outro_contato_fornecedor.Text;

            if (!string.IsNullOrWhiteSpace(this.id))
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();

                        // Atualize os dados do fornecedor na tabela
                        string sql_update = "UPDATE TB_FORNECEDOR SET TB_FORNECEDOR_NOME = @novoNome, " +
                     "TB_FORNECEDOR_PRODUTO = @novoProduto, " +
                     "TB_FORNECEDOR_OUTRO_CONTATO = @novoOutro, " + 
                     "TB_FORNECEDOR_CONTATO = @novoContato " +
                     "WHERE TB_FORNECEDOR_ID = @nomeFornecedor";


                        MySqlCommand cmd = new MySqlCommand(sql_update, con);
                        cmd.Parameters.AddWithValue("@novoNome", novoNome);
                        cmd.Parameters.AddWithValue("@novoProduto", novoProduto);
                        cmd.Parameters.AddWithValue("@novoContato", novoContato);
                        cmd.Parameters.AddWithValue("@novoOutro", novoOutro);
                        cmd.Parameters.AddWithValue("@nomeFornecedor", this.id);
                        cmd.ExecuteNonQuery();
                    }


                    // Após a atualização bem-sucedida
                    FornecedorAtualizado?.Invoke(this, EventArgs.Empty);

                    

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

        private void Txt_nome_fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_produto_fornecido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_tel_fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = Txt_nome_fornecedor.Text; // Obtenha o nome do fornecedor do campo de texto

            if (!string.IsNullOrWhiteSpace(nomeFornecedor))
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexao))
                    {
                        con.Open();
                        string sql_delete = "DELETE FROM TB_FORNECEDOR WHERE TB_FORNECEDOR_NOME = @nomeFornecedor";
                        MySqlCommand cmd = new MySqlCommand(sql_delete, con);
                        cmd.Parameters.AddWithValue("@nomeFornecedor", nomeFornecedor);
                        cmd.ExecuteNonQuery();

                    }

                    // Após uma exclusão bem-sucedida
                    FornecedorAtualizado?.Invoke(this, EventArgs.Empty);

                   
                    

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

        private void Btn_voltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_outro_contato_fornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
