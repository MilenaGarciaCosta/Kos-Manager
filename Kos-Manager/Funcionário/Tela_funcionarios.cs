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
    public partial class Tela_funcionarios : Form
    {
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
    }
}
