using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Kos_Manager
{
    public partial class Tela_nivel_acesso : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_nivel_acesso()
        {
            InitializeComponent();
            ListarNiveis();
        }

        string id;

        public void ListarNiveis()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_nivel = @"SELECT 
                    n.tb_nivel_acesso_id as Id,
                    n.tb_nivel_acesso_nome as Nivel_de_Acesso
                    from tb_nivel_acesso n";


            con.Open();

            DataTable tabela_nivel = new DataTable();

            MySqlDataAdapter da_nivel = new MySqlDataAdapter(sql_select_nivel, con);
            da_nivel.Fill(tabela_nivel);

            Dgv_nivel.DataSource = tabela_nivel;

            con.Close();


        }


       

        private void Btn_adicionar_Click_2(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);


                string nome = txt_nome.Text;


                string sql_insert = @"insert into tb_nivel_acesso
                                    (
                                        tb_nivel_acesso_nome
    
                                    )
                                    values
                                    (
                                        @nivel_acesso_nome
                                     )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@nivel_acesso_nome", nome);


                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarNiveis();
                con.Close();
                MessageBox.Show("Adicionado com Sucesso!");




            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro:" + erro);
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string id = this.id;
            string nome = txt_nome.Text;

            MySqlConnection con = new MySqlConnection(conexao);


            string sql_update_fornecedor = @"update tb_nivel_acesso
                                  set tb_nivel_acesso_nome = @nome
                                  where tb_nivel_acesso_id = @id";


            MySqlCommand executacmdMySql_update_fornecedor = new MySqlCommand(sql_update_fornecedor, con);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@nome", nome);

            con.Open();
            executacmdMySql_update_fornecedor.ExecuteNonQuery();
            ListarNiveis();
            con.Close();
            MessageBox.Show("Atualização realizada com sucesso");
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {

            string id = this.id;

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_delete_nivel_acesso = @"delete from tb_nivel_acesso where tb_nivel_acesso_id = @id";

            MySqlCommand executarcmdMySql_delete_nivel_acesso = new MySqlCommand(sql_delete_nivel_acesso, con);

            executarcmdMySql_delete_nivel_acesso.Parameters.AddWithValue("@id", id);

            con.Open();
            executarcmdMySql_delete_nivel_acesso.ExecuteNonQuery();
            ListarNiveis();
            con.Close();
            MessageBox.Show("Registrado deletado com sucesso");
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_nivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Dgv_nivel.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = Dgv_nivel.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
