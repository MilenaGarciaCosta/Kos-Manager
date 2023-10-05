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

namespace Kos_Manager
{
    public partial class Tela_mat_prima : Form
    {
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
    }
}
