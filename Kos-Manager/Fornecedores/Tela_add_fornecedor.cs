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


    public partial class Tela_add_fornecedor : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;


        public Tela_add_fornecedor()
        {
            InitializeComponent();
        }



        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            

                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome;
                    string produto;
                    string contato;
                    string outro;

                    nome = Txt_nome_fornecedor.Text;
                    produto = Txt_produto_fornecido.Text;
                    contato = Txt_tel_fornecedor.Text;
                    outro = Txt_outro_contato_fornecedor.Text; 

                    string sql_insert = @"insert into tb_fornecedor
                                    (
                                         tb_fornecedor_nome, tb_fornecedor_produto, tb_fornecedor_contato, tb_fornecedor_outro_contato
                                    )
                                    values 
                                    (
                                        @fornecedor_nome, @fornecedor_produto, @fornecedor_contato, @outro_contato
                                    )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@fornecedor_nome", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@fornecedor_produto", produto);
                    executacmdMySql_insert.Parameters.AddWithValue("@fornecedor_contato", contato);
                    executacmdMySql_insert.Parameters.AddWithValue("@outro_contato", outro);
                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("cadastrado");


                    // Agora, você pode criar uma instância da classe Fornecedor e definir os valores das propriedades
                    
                    Fornecedor.Nome = nome;
                    Fornecedor.Produto = produto;
                    Fornecedor.Contato = contato;
                    Fornecedor.Outro = outro;


                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro " + erro);
                }
                // Limpe os campos de entrada após o cadastro
                ClearTextBoxes(this.Controls);

        }

        private void Txt_nome_fornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
