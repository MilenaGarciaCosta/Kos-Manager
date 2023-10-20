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
        string id;

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
            try
            {
                string id = this.id; // Certifique-se de que 'this.id' esteja corretamente inicializado

                string quantidade = Txt_quantidade.Text;
                string valor = Txt_valor_produto.Text;
                int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
                int cmb_Venda_status = Convert.ToInt32(cmb_status.SelectedValue);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_venda = @"UPDATE tb_venda 
                                SET tb_venda_quantidade = @quantidade,
                                    tb_venda_valor = @valor,
                                    tb_funcionario_id = @cmbfuncionario,
                                    tb_produto_manu_id = @cmbproduto,
                                    tb_venda_status_id = @cmbstatus
                                WHERE tb_venda_id = @id";

                MySqlCommand executacmdMySql_update_venda = new MySqlCommand(sql_update_venda, con);
                executacmdMySql_update_venda.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_venda.Parameters.AddWithValue("@quantidade", int.Parse(quantidade));

                decimal valorDecimal = decimal.Parse(valor);
                if (int.TryParse(quantidade, out int quantidadeInt) && quantidadeInt > 1)
                {
                    valorDecimal *= quantidadeInt; // Multiplica o valor pela quantidade
                }
                executacmdMySql_update_venda.Parameters.AddWithValue("@valor", valorDecimal);
                executacmdMySql_update_venda.Parameters.AddWithValue("@cmbfuncionario", cmb_Funcionario);
                executacmdMySql_update_venda.Parameters.AddWithValue("@cmbproduto", cmb_Produto);
                executacmdMySql_update_venda.Parameters.AddWithValue("@cmbstatus", cmb_Venda_status);

                int rowsAffected = executacmdMySql_update_venda.ExecuteNonQuery();

                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Atualização realizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // Declarando variável e inserindo conteúdo do textbox nela
          

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_venda = @"DELETE FROM tb_venda WHERE tb_venda_id = @codigo";

            MySqlCommand executarcmdMySql_delete_venda = new MySqlCommand(sql_delete_venda, con);

            executarcmdMySql_delete_venda.Parameters.AddWithValue("@codigo", this.id);

            executarcmdMySql_delete_venda.ExecuteNonQuery();

            MessageBox.Show("Registro deletado com sucesso");
            //ListarVendas(); função do refresh 

            // Fechando conexão
            con.Close();
        }
    }
}
