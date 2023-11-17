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
    public partial class Tela_configuracao : Form
    {
        public Tela_configuracao()
        {
            InitializeComponent();
        }

        private void Tela_configuracao_Load(object sender, EventArgs e)
        {

            txt_email.Text = Usuario.email;
            txt_senha.Text = Usuario.senha;

        }

        private void txt_atualizar_nivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_visivel_Click(object sender, EventArgs e)
        {
           
            
                txt_senha.PasswordChar = '\0';

               //txt_senha.PasswordChar = '*';

    
        }
    }
}