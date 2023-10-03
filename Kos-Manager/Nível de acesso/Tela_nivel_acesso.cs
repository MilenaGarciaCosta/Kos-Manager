using Kos_Manager.Nível_de_acesso;
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
    public partial class Tela_nivel_acesso : Form
    {
        public Tela_nivel_acesso()
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

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click_1(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_nivel_acesso_add());
        }
    }
}
