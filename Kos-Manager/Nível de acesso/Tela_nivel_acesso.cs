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
            listarNiveis();
        }

        string id;

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

            Dgv_nivel.DataSource = tabela_nivel_acesso;

            con.Close();

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
            //Child_panel.Controls.Add(ChildForm);
            //Child_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }

     

        private void Btn_adicionar_Click_2(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);


                string nome;

                nome = txt_nome.Text;




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

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
           // string id = txt_cod.Text;
            string nome = txt_nome.Text;

            MySqlConnection con = new MySqlConnection(conexao);


            string sql_update_fornecedor = @"update tb_nivel_acesso
                                  set tb_nivel_acesso_nome = @nome,
                                  where tb_nivel_acesso_id = @id";




            MySqlCommand executacmdMySql_update_fornecedor = new MySqlCommand(sql_update_fornecedor, con);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_fornecedor.Parameters.AddWithValue("@nome", nome);

            con.Open();
            executacmdMySql_update_fornecedor.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");

            listarNiveis();

            con.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            //Declarando variavel e inserindo conteudo do textbox nela
            //int codigo;

            //codigo = int.Parse(txt_cod.Text);

            //Conectanto banco de dados MySql

            MySqlConnection con = new MySqlConnection(conexao);

            //Abrindo conexão
            con.Open();

            string sql_delete_nivel_acesso = @"delete from tb_nivel_acesso where tb_nivel_acesso_id = @id";

            MySqlCommand executarcmdMySql_delete_nivel_acesso = new MySqlCommand(sql_delete_nivel_acesso, con);

            executarcmdMySql_delete_nivel_acesso.Parameters.AddWithValue("@id", id);

            executarcmdMySql_delete_nivel_acesso.ExecuteNonQuery();

            MessageBox.Show("Registrado deletado com sucesso");
            listarNiveis();
            //Fechando conexão

            con.Close();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
