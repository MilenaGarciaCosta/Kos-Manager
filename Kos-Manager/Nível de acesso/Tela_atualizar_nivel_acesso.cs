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
using MySql.Data.MySqlClient;


namespace Kos_Manager.Nível_de_acesso
{
    public partial class Tela_atualizar_nivel_acesso : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_nivel_acesso()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            /
            string id = txt_cod.Text;
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

            //listarNiveis();

            con.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // deletar pelo id
            //Declarando variavel e inserindo conteudo do textbox nela
            int codigo;

            codigo = int.Parse(txt_cod.Text);

            //Conectanto banco de dados MySql

            MySqlConnection con = new MySqlConnection(conexao);

            //Abrindo conexão
            con.Open();

            string sql_delete_nivel_acesso = @"delete from tb_nivel_acesso where tb_nivel_acesso_id = @id";

            MySqlCommand executarcmdMySql_delete_nivel_acesso = new MySqlCommand(sql_delete_nivel_acesso, con);

            executarcmdMySql_delete_nivel_acesso.Parameters.AddWithValue("@id", codigo);

            executarcmdMySql_delete_nivel_acesso.ExecuteNonQuery();

            MessageBox.Show("Registrado deletado com sucesso");
            //listarNiveis();
            //Fechando conexão

            con.Close();
        }
    }
}
