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

        public Tela_atualizar_fornecedor(string nome, string produto, string contato)
        {
            InitializeComponent();

            // Define os valores dos campos de texto com os dados do fornecedor
            Txt_nome_fornecedor.Text = nome;
            Txt_produto_fornecido.Text = produto;
            Txt_tel_fornecedor.Text = contato;
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
    }
}
