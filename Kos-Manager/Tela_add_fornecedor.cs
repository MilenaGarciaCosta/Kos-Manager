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

        public class Fornecedor
        {
            public string Nome { get; set; }
            public string Produto { get; set; }
            public string Contato { get; set; }
        }



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
                // Seu código para adicionar um fornecedor ao banco de dados

                // Crie um objeto Fornecedor
                Fornecedor novoFornecedor = new Fornecedor
                {
                    Nome = Txt_nome_fornecedor.Text,
                    Produto = Txt_produto_fornecido.Text,
                    Contato = Txt_tel_fornecedor.Text
                };

                // Crie ou obtenha uma instância da Tela_fornecedor
                Tela_fornecedor telaFornecedor = new Tela_fornecedor();

                // Adicione o fornecedor ao Panel na Tela_fornecedor
                telaFornecedor.AdicionarFornecedorAoPanel(novoFornecedor);

                // Mostre a tela Tela_fornecedor (se necessário)
                telaFornecedor.Show();

                // Limpe os campos de entrada após o cadastro
                ClearTextBoxes(this.Controls);



            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }
        }

      
    }
}
