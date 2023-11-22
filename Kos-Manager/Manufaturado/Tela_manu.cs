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
using System.Globalization;

namespace Kos_Manager
{
    public partial class Tela_manu : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;


        public Tela_manu()
        {
            InitializeComponent();
            ListarEstoquePm();
        }

        string id;

        public void ListarEstoquePm()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_estoqueMp = @"
               select 
                    TB_PRODUTO_MANU_ID as id,
					TB_PRODUTO_MANU_NOME as Produto,
					TB_PRODUTO_MANU_DT_FAB as Fabricação,
					TB_PRODUTO_MANU_DT_VAL as Validade,
					TB_PRODUTO_MANU_LOTE as Lote,
					TB_PRODUTO_MANU_QUANTIDADE as Quantidade
                        from TB_PRODUTO_MANU";

            con.Open();

            DataTable tabela_estoqueMp = new DataTable();

            MySqlDataAdapter da_estoqueMp = new MySqlDataAdapter(sql_select_estoqueMp, con);
            da_estoqueMp.Fill(tabela_estoqueMp);

            DgvEstoquePm.DataSource = tabela_estoqueMp;

            con.Close();


        }


        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
        }

        private void Btn_requisitar_Click(object sender, EventArgs e)
        {
            
        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_manu_Load(object sender, EventArgs e)
        {
            
        }

        private void LimparDados()
        {
            // Limpar TextBox
            Txt_dt_fab.Clear();
            Txt_dt_validade.Clear();
            Txt_lote.Clear();
            Txt_nome_produto_manu.Clear();
            Txt_quantidade.Clear();

            // Limpar ComboBox
        }

        private void Btn_adicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string produto = Txt_nome_produto_manu.Text;
                string lote = Txt_lote.Text;
                string quantidade = Txt_quantidade.Text;
                DateTime dtVal = DateTime.ParseExact(Txt_dt_validade.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dtFab = DateTime.ParseExact(Txt_dt_fab.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string formattedDateV = dtVal.ToString("yyyy-MM-dd");
                string formattedDateF = dtFab.ToString("yyyy-MM-dd");

                // Correção do comando SQL para inserção na tabela correta (TB_PRODUTO_MANU)
                string sql_insert = @"
            insert into TB_PRODUTO_MANU
            (
                TB_PRODUTO_MANU_NOME,
                TB_PRODUTO_MANU_DT_FAB,
                TB_PRODUTO_MANU_DT_VAL,
                TB_PRODUTO_MANU_LOTE,
                TB_PRODUTO_MANU_QUANTIDADE
            )
            values
            (
                @PRODUTO_MANU_NOME, @PRODUTO_MANU_DT_FAB, @PRODUTO_MANU_DT_VAL, @PRODUTO_MANU_LOTE, @PRODUTO_MANU_QUANTIDADE
            )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_NOME", produto);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_DT_FAB", formattedDateF);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_DT_VAL", formattedDateV);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_LOTE", lote);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_QUANTIDADE", quantidade);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarEstoquePm();
                con.Close();
                LimparDados();
                //notificação aqui
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);

            string produto = Txt_nome_produto_manu.Text;
            string lote = Txt_lote.Text;
            string quantidade = Txt_quantidade.Text;
            DateTime dtVal = DateTime.ParseExact(Txt_dt_validade.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dtFab = DateTime.ParseExact(Txt_dt_fab.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string formattedDateV = dtVal.ToString("yyyy-MM-dd");
            string formattedDateF = dtFab.ToString("yyyy-MM-dd");

            // Correção do comando SQL para atualização na tabela correta (TB_PRODUTO_MANU)
            string sql_update_manu = @"
        update TB_PRODUTO_MANU 
        set TB_PRODUTO_MANU_NOME = @nome,
            TB_PRODUTO_MANU_DT_FAB = @dtfab,
            TB_PRODUTO_MANU_DT_VAL = @dtval,
            TB_PRODUTO_MANU_LOTE = @lote,
            TB_PRODUTO_MANU_QUANTIDADE = @quantidade
        where TB_PRODUTO_MANU_ID = @id";

            MySqlCommand executacmdMySql_update_manu = new MySqlCommand(sql_update_manu, con);
            executacmdMySql_update_manu.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_manu.Parameters.AddWithValue("@nome", produto);
            executacmdMySql_update_manu.Parameters.AddWithValue("@lote", lote);
            executacmdMySql_update_manu.Parameters.AddWithValue("@quantidade", quantidade);
            executacmdMySql_update_manu.Parameters.AddWithValue("@dtval", formattedDateV);
            executacmdMySql_update_manu.Parameters.AddWithValue("@dtfab", formattedDateF);

            con.Open();
            executacmdMySql_update_manu.ExecuteNonQuery();
            //notificação aqui
            ListarEstoquePm();
            con.Close();

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // Declarando variável e inserindo conteúdo do textbox nela
            int codigo = int.Parse(this.id);

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_produto_manu = @"DELETE FROM tb_produto_manu WHERE tb_produto_manu_id = @codigo";

            MySqlCommand executarcmdMySql_delete_produto_manu = new MySqlCommand(sql_delete_produto_manu, con);

            executarcmdMySql_delete_produto_manu.Parameters.AddWithValue("@codigo", codigo);

            executarcmdMySql_delete_produto_manu.ExecuteNonQuery();

            //notificação aqui
            ListarEstoquePm();

            // Fechando conexão
            con.Close();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvEstoquePm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = DgvEstoquePm.CurrentRow.Cells[0].Value.ToString();
            Txt_nome_produto_manu.Text = DgvEstoquePm.CurrentRow.Cells[1].Value.ToString();
            Txt_dt_fab.Text = DgvEstoquePm.CurrentRow.Cells[2].Value.ToString();
            Txt_dt_validade.Text = DgvEstoquePm.CurrentRow.Cells[3].Value.ToString();
            Txt_lote.Text = DgvEstoquePm.CurrentRow.Cells[4].Value.ToString();
            Txt_quantidade.Text = DgvEstoquePm.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
