using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager.Estoque_manu
{
    public partial class Tela_atualizar_manu : Form
    {
        public Tela_atualizar_manu( string id, string nome, string datafab, string dataval, string lote, string quantidade)
        {


            InitializeComponent();
            //this.id = id
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
    }
}
