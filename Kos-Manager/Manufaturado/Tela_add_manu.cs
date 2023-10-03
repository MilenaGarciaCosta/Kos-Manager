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
    public partial class Tela_add_manu : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

        public Tela_add_manu()
        {
            InitializeComponent();
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

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                string dataval;
                string datafab;
                string lote;
                string quantidade;

                nome = Txt_nome_manu.Text;
                datafab = Txt_dt_fab.Text;
                dataval = Txt_dt_val.Text;
                lote = Txt_lote.Text;
                quantidade = Txt_quantidade.Text;


                string sql_insert = @"insert into tb_produto_manu
                                        (
                                            tb_produto_manu_nome, tb_produto_manu_dt_fab, tb_produto_manu_dt_val, tb_produto_manu_lote, tb_produto_manu_quantidade
                                        )
                                        values
                                        (
                                            @produto_manu_nome, @produto_manu_dt_fab, @produto_manu_dt_val, @produto_manu_lote, @produto_manu_quantidade
                                        )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@produto_manu_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@produto_manu_dt_fab", datafab);
                executacmdMySql_insert.Parameters.AddWithValue("@produto_manu_dt_val", dataval);
                executacmdMySql_insert.Parameters.AddWithValue("@produto_manu_lote", lote);
                executacmdMySql_insert.Parameters.AddWithValue("@produto_manu_quantidade", quantidade);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("cadastrado");



            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }

            ClearTextBoxes(this.Controls);
        }

        private void Tela_add_manu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
