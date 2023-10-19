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

namespace Kos_Manager.Nível_de_acesso
{
    public partial class Tela_nivel_acesso_add : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;
        
        public Tela_nivel_acesso_add()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void listarNiveis()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_select_nivel_acesso = "select * from tb_nivel_acesso";


            MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_nivel_acesso, con);

            con.Open();

            MySqlCommand executacmdMySql_select_nivel_acesso = new MySqlCommand(sql_select_nivel_acesso, con);
            executacmdMySql_select_nivel_acesso.ExecuteNonQuery();

            DataTable tabela_nivel_acesso = new DataTable();

            MySqlDataAdapter da_nivel_acesso = new MySqlDataAdapter(executacmdMySql_select_nivel_acesso);
            da_nivel_acesso.Fill(tabela_nivel_acesso);

            //DgvNivelAcesso.DataSource = tabela_nivel_acesso; datagridview

            con.Close();

        }


        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);


                string nome;

                nome = txt_add_nivel.Text;




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
                listarNiveis();
                con.Close();
                MessageBox.Show("Adicionado com Sucesso!");




            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro:" + erro);
            }


        }
    }
}
