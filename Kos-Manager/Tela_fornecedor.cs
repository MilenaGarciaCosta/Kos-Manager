using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager
{
    public partial class Tela_fornecedor : Form
    {




        public class Fornecedor
        {
            public string Nome { get; set; }
            public string Produto { get; set; }
            public string Contato { get; set; }
        }


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




        public void AdicionarFornecedorAoPanel(Fornecedor fornecedor)
        {
            // Crie controles (por exemplo, Label) para exibir as informações do fornecedor
            Label lblNome = new Label();
            lblNome.Text = "Nome: " + fornecedor.Nome;
            lblNome.Location = new Point(10, 10);

            Label lblProduto = new Label();
            lblProduto.Text = "Produto: " + fornecedor.Produto;
            lblProduto.Location = new Point(10, 30);

            Label lblContato = new Label();
            lblContato.Text = "Contato: " + fornecedor.Contato;
            lblContato.Location = new Point(10, 50);

            // Adicione os controles ao Panel (pnlFornecedores)
            pnlFornecedores.Controls.Add(lblNome);
            pnlFornecedores.Controls.Add(lblProduto);
            pnlFornecedores.Controls.Add(lblContato);
        }

    }
}
