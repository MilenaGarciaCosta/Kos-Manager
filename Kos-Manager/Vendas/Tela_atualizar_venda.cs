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
using System.Globalization;

namespace Kos_Manager.Vendas
{
    public partial class Tela_atualizar_venda : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_venda()
        {
            InitializeComponent();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string quantidade = Txt_quantidade.Text;
            string valor = Txt_valor_produto.Text;
            int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
            int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
            int cmb_Venda_status = Convert.ToInt32(cmb_status.SelectedValue);

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_update_venda = @"update tb_venda 
    set tb_venda_quantidade = @quantidade,
        tb_venda_valor = @valor,
        tb_funcionario_id = @cmbfuncionario,
        tb_produto_manu_id = @cmbproduto,
        tb_venda_status_id = @cmbstatus
    where tb_venda_id = @id";

            MySqlCommand executacmdMySql_update_venda = new MySqlCommand(sql_update_venda, con);
            executacmdMySql_update_venda.Parameters.AddWithValue("@id", id); //atualizar apartir do id (nao tem txt_id para puxar)

            // Verificar se a quantidade é maior que 1 e, se for, multiplicar o valor pela quantidade
            if (int.TryParse(quantidade, out int quantidadeInt) && quantidadeInt > 1)
            {
                valor *= quantidadeInt; // Multiplica o valor pela quantidade
            }

            executacmdMySql_update_venda.Parameters.AddWithValue("@quantidade", quantidadeInt);
            executacmdMySql_update_venda.Parameters.AddWithValue("@valor", valor); // Agora é um decimal
            executacmdMySql_update_venda.Parameters.AddWithValue("@cmbfuncionario", cmb_Funcionario);
            executacmdMySql_update_venda.Parameters.AddWithValue("@cmbproduto", cmb_Produto);
            executacmdMySql_update_venda.Parameters.AddWithValue("@cmbstatus", cmb_Venda_status);
            con.Open();
            executacmdMySql_update_venda.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso");

            //ListarVendas(); função do refresh 

            con.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // Declarando variável e inserindo conteúdo do textbox nela
            int codigo = int.Parse(txt_id.Text); //deletar apartir do id

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_venda = @"DELETE FROM tb_venda WHERE tb_venda_id = @codigo";

            MySqlCommand executarcmdMySql_delete_venda = new MySqlCommand(sql_delete_venda, con);

            executarcmdMySql_delete_venda.Parameters.AddWithValue("@codigo", codigo);

            executarcmdMySql_delete_venda.ExecuteNonQuery();

            MessageBox.Show("Registro deletado com sucesso");
            //ListarVendas(); função do refresh 

            // Fechando conexão
            con.Close();
        }
    }
}
