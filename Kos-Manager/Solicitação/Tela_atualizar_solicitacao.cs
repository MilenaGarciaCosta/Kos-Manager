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


namespace Kos_Manager.Solicitação
{
    public partial class Tela_atualizar_solicitacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_atualizar_solicitacao()
        {
            InitializeComponent();
        }

        private void Tela_atualizar_solicitacao_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"
                    SELECT
                     s.tb_solicitacao_id AS Id,
                     s.tb_solicitacao_quantidade as Quantidade,
                     t.tb_solicitacao_status_nome as Status,
                     m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                     m.TB_MATERIA_PRIMA_MARCA AS Marca,
                     f.tb_fornecedor_nome AS Fornecedor
                    FROM
                     tb_solicitacao s
                     INNER JOIN
                     TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
                        INNER JOIN
                     tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
                     INNER JOIN
                     tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id";

            string sql_select_status = "select * from tb_solicitacao_status";


            MySqlCommand executacmdMySql_select_solicitacao = new MySqlCommand(sql_select_solicitacao, con);

            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            con.Open();

            executacmdMySql_select_solicitacao.ExecuteNonQuery();
      
            executacmdMySql_select_status.ExecuteNonQuery();

            DataTable tabela_solicitacao = new DataTable();

            DataTable tabela_status = new DataTable();
         

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(executacmdMySql_select_solicitacao);
            da_solicitacao.Fill(tabela_solicitacao);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);



            cmb_status_solicitacao.DataSource = tabela_status;

            cmb_status_solicitacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_solicitacao.DisplayMember = "TB_SOLICITACAO_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_solicitacao.ValueMember = "TB_SOLICITACAO_STATUS_ID";  //Pega os dados            
            cmb_status_solicitacao.DataSource = tabela_status;

            cmb_status_solicitacao.SelectedItem = null;
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
