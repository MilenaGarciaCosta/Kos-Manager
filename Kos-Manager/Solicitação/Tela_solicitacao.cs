//using Kos_Manager.Solicitação;
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
using Kos_Manager.Notificação;
using System.IO;

namespace Kos_Manager
{
    public partial class Tela_solicitacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;
		// Caminho do arquivo de log
		private string caminhoArquivoLog = "C:/Users/milen/Downloads/logs.txt";
		private string caminhoLogUpdate = "C:/Users/milen/Downloads/logs_update.txt";
		private string caminhoArquivoLogDeletar = "C:/Users/milen/Downloads/logs_delete.txt";

		public Tela_solicitacao()
        {
            InitializeComponent();
            LimparDados();
            ListarSolicitacao();
        }


        public void ListarSolicitacao()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"
                   SELECT
                s.tb_solicitacao_id AS Id,
                m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                s.tb_solicitacao_quantidade as Quantidade,
                s.tb_solicitacao_marca as Marca,
                t.tb_solicitacao_status_nome as Status,
                f.tb_fornecedor_nome AS Fornecedor
            FROM
                tb_solicitacao s
                     INNER JOIN
                TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
                     INNER JOIN 
                tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
                     INNER JOIN 
                tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id";


            con.Open();

            DataTable tabela_solicitacao = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(sql_select_solicitacao, con);
            da_solicitacao.Fill(tabela_solicitacao);

            Dgv_solicita.DataSource = tabela_solicitacao;

            con.Close();


        }


        private void LimparDados()
        {
            // Limpar TextBox
            Txt_quantidade.Clear();
            Txt_solicitacao_marca.Clear();

            
        }

        //Public de notificação
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void LerLog()
        {
            // Verifica se o arquivo de log existe
            if (File.Exists(caminhoArquivoLog))
            {
                using (StreamReader streamReader = new StreamReader(caminhoArquivoLog))
                {
                    // Lê o conteúdo do arquivo de log
                    string conteudoLog = streamReader.ReadToEnd();

                }
            }
            if (File.Exists(caminhoLogUpdate))
            {
                using (StreamReader streamReader = new StreamReader(caminhoLogUpdate))
                {
                    // Lê o conteúdo do arquivo de log
                    string conteudoLog = streamReader.ReadToEnd();

                }
            }
            if (File.Exists(caminhoArquivoLogDeletar))
            {
                using (StreamReader streamReader = new StreamReader(caminhoArquivoLogDeletar))
                {
                    // Lê o conteúdo do arquivo de log
                    string conteudoLog = streamReader.ReadToEnd();

                }
            }


        }

        //Public de registro de autoria
        public class Logger
        {
            private string filePath;
            public Logger(string logFilePath)
            {
                filePath = logFilePath;
            }

            public void Log(string message)
            {
                try
                {


                }
                catch (Exception ex)
                {
                    // Lida com possíveis erros ao registrar o log
                    throw new Exception("Erro ao registrar o log: " + ex.Message);
                }
            }
        }

		//LogRegistros
		private void RegistrarLog(string message)
		{
			string caminhoDoArquivoDeLog = "C:/Users/milen/Downloads/logs.txt";

			Logger logger = new Logger(caminhoDoArquivoDeLog);
			logger.Log(message);
		}

		private void RegistrarLogAtualizacao(string message)
		{
			string caminhoLogUpdate = "C:/Users/milen/Downloads/logs_update.txt";
			Logger logger = new Logger(caminhoLogUpdate);
			logger.Log(message);
		}

		private void RegistrarLogDeletar(string message)
		{
			string caminhoArquivoLogDeletar = "C:/Users/milen/Downloads/logs_delete.txt";
			Logger logger = new Logger(caminhoArquivoLogDeletar);
			logger.Log(message);
		}



		private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                string marca = Txt_solicitacao_marca.Text;
                int cmb_Status = Convert.ToInt32(cmb_status_solicitacao.SelectedValue);
                int cmb_Fornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);

                string sql_insert = @"insert into TB_SOLICITACAO
                (  
                 
                   TB_SOLICITACAO_QUANTIDADE,
                   TB_SOLICITACAO_STATUS_ID,
                   TB_SOLICITACAO_MARCA,
                   TB_MATERIA_PRIMA_ID, 
                   TB_FORNECEDOR_ID
            
                 )
                values
                (
                   @SOLICITACAO_QUANTIDADE, @SOLICITACAO_STATUS,@SOLICITACAO_MARCA, @MATERIA_PRIMA_ID, @FORNECEDOR_ID
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@SOLICITACAO_QUANTIDADE", quantidade);
                executacmdMySql_insert.Parameters.AddWithValue("@SOLICITACAO_STATUS", cmb_Status);
                executacmdMySql_insert.Parameters.AddWithValue("@SOLICITACAO_MARCA", marca);
                executacmdMySql_insert.Parameters.AddWithValue("@MATERIA_PRIMA_ID", cmb_Produto);
                executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_ID", cmb_Fornecedor);



                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarSolicitacao();

                con.Close();
                LimparDados();

                // Limpar a seleção da ComboBox após adicionar os dados
                cmb_nome_produto.SelectedItem = null;
                cmb_status_solicitacao.SelectedItem = null;
                cmb_fornecedor.SelectedItem = null;

                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Solicitação de quantidade {quantidade} foi adicionada!";

                // Chamada para registrar o log
                RegistrarLog(mensagemLog);

                // Adiciona a saída do console para o arquivo de log
                using (StreamWriter streamWriter = File.AppendText(caminhoArquivoLog))
                {
                    streamWriter.WriteLine(mensagemLog);
                }

                // Atualiza a exibição do log na tela
                LerLog();

                //notificação
                this.Alert("Adicionado com sucesso", Form_Alert.enmType.Sucess);


            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }
        }

        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string id = Txt_id.Text;
            string quantidade = Txt_quantidade.Text;
            string marca = Txt_solicitacao_marca.Text;
            int cmb_Status = Convert.ToInt32(cmb_status_solicitacao.SelectedValue);
            int cmb_Fornecedor = Convert.ToInt32(cmb_fornecedor.SelectedValue);
            int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                
                string sql_update_tb_requisicao = @"
            UPDATE TB_SOLICITACAO
            SET TB_SOLICITACAO_QUANTIDADE = @quantidade,
                TB_SOLICITACAO_STATUS_ID = @status,
                TB_SOLICITACAO_MARCA = @Marca,
                TB_MATERIA_PRIMA_ID = @produto,
                TB_FORNECEDOR_ID = @fornecedor
            WHERE TB_SOLICITACAO_ID = @id";


                MySqlCommand executacmdMySql_update_tb_requisicao = new MySqlCommand(sql_update_tb_requisicao, con);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@quantidade", quantidade);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@status", cmb_Status);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@Marca", marca);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@produto", cmb_Produto);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@fornecedor", cmb_Fornecedor);

             
                con.Open();
                executacmdMySql_update_tb_requisicao.ExecuteNonQuery();
                ListarSolicitacao();
                con.Close();
                LimparDados();
                // Limpar a seleção da ComboBox após adicionar os dados
                cmb_nome_produto.SelectedItem = null;
                cmb_status_solicitacao.SelectedItem = null;
                cmb_fornecedor.SelectedItem = null;

                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Solicitação do id {id} foi atualizada!";

                // Chamada para registrar o log
                RegistrarLog(mensagemLog);

                // Adiciona a saída do console para o arquivo de log
                using (StreamWriter streamWriter = File.AppendText(caminhoLogUpdate))
                {
                    streamWriter.WriteLine(mensagemLog);
                }

                // Atualiza a exibição do log na tela
                LerLog();


                //notificação
                this.Alert("Atualizado com sucesso", Form_Alert.enmType.Update);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }




        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID da solicitação que deseja excluir
                string id = Txt_id.Text;

                MySqlConnection con = new MySqlConnection(conexao);

                // Define a consulta SQL para exclusão
                string sql_delete_tb_solicitacao = "DELETE FROM tb_solicitacao WHERE tb_solicitacao_id = @id";

                MySqlCommand executacmdMySql_delete_tb_solicitacao = new MySqlCommand(sql_delete_tb_solicitacao, con);
                executacmdMySql_delete_tb_solicitacao.Parameters.AddWithValue("@id", id);

               
                con.Open();
                executacmdMySql_delete_tb_solicitacao.ExecuteNonQuery();
                ListarSolicitacao();
                con.Close();
                LimparDados();


                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Solicitação do id {id} foi deletada!";

                // Chamada para registrar o log
                RegistrarLog(mensagemLog);

                // Adiciona a saída do console para o arquivo de log
                using (StreamWriter streamWriter = File.AppendText(caminhoArquivoLogDeletar))
                {
                    streamWriter.WriteLine(mensagemLog);
                }

                // Atualiza a exibição do log na tela
                LerLog();



                //notificação
                this.Alert("Deletado com sucesso", Form_Alert.enmType.Delete);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Child_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Tela_solicitacao_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_solicitacao = @"SELECT
                s.tb_solicitacao_id AS Id,
                m.TB_MATERIA_PRIMA_NOMENCLATURA AS Nome,
                s.tb_solicitacao_quantidade as Quantidade,
                s.tb_solicitacao_marca as Marca,
                t.tb_solicitacao_status_nome as Status,
                f.tb_fornecedor_nome AS Fornecedor
            FROM
                tb_solicitacao s
                     INNER JOIN
                TB_MATERIA_PRIMA m ON m.TB_MATERIA_PRIMA_id = s.TB_MATERIA_PRIMA_id
                     INNER JOIN 
                tb_fornecedor f ON f.tb_fornecedor_id = s.tb_fornecedor_id    
                     INNER JOIN 
                tb_solicitacao_status t ON t.tb_solicitacao_status_id = s.tb_solicitacao_status_id";
                    

            string sql_select_produto = "select * from tb_materia_prima";
            string sql_select_fornecedor = "select * from tb_fornecedor";
            string sql_select_status = "select * from tb_solicitacao_status";
            

            MySqlCommand executacmdMySql_select_solicitacao = new MySqlCommand(sql_select_solicitacao, con);
            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            con.Open();

            executacmdMySql_select_solicitacao.ExecuteNonQuery();
            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_fornecedor.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();

            DataTable tabela_solicitacao = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_fornecedor = new DataTable();
            DataTable tabela_status = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(executacmdMySql_select_solicitacao);
            da_solicitacao.Fill(tabela_solicitacao);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_fornecedor = new MySqlDataAdapter(executacmdMySql_select_fornecedor);
            da_fornecedor.Fill(tabela_fornecedor);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);



            Dgv_solicita.DataSource = tabela_solicitacao;


            cmb_nome_produto.DataSource = tabela_produto;
            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_MATERIA_PRIMA_NOMENCLATURA"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_MATERIA_PRIMA_ID";  //Pega os dados    
            cmb_nome_produto.SelectedItem = null;


            cmb_fornecedor.DataSource = tabela_fornecedor;
            cmb_fornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_fornecedor.DisplayMember = "TB_FORNECEDOR_NOME"; //Exibe os dados para o usuário
            cmb_fornecedor.ValueMember = "TB_FORNECEDOR_ID";  //Pega os dados   
            cmb_fornecedor.SelectedItem = null;


            cmb_status_solicitacao.DataSource = tabela_status;
            cmb_status_solicitacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_solicitacao.DisplayMember = "TB_SOLICITACAO_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_solicitacao.ValueMember = "TB_SOLICITACAO_STATUS_ID";  //Pega os dados     
            cmb_status_solicitacao.SelectedItem = null;

            // Verifica se o arquivo de log existe, se não, cria o arquivo
            if (!File.Exists(caminhoArquivoLog))
            {
                File.Create(caminhoArquivoLog).Close();
            }
            // Atualização
            if (!File.Exists(caminhoLogUpdate))
            {
                File.Create(caminhoLogUpdate).Close();
            }
            //Deletar
            if (!File.Exists(caminhoArquivoLogDeletar))
            {
                File.Create(caminhoArquivoLogDeletar).Close();
                // Inicia a leitura do log
                LerLog();

            }

        }

        private void Dgv_solicita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Txt_id.Text = Dgv_solicita.CurrentRow.Cells[0].Value.ToString();
            cmb_nome_produto.Text = Dgv_solicita.CurrentRow.Cells[1].Value.ToString();
            Txt_quantidade.Text = Dgv_solicita.CurrentRow.Cells[2].Value.ToString();
            Txt_solicitacao_marca.Text = Dgv_solicita.CurrentRow.Cells[3].Value.ToString();
            cmb_status_solicitacao.Text = Dgv_solicita.CurrentRow.Cells[4].Value.ToString();
            cmb_fornecedor.Text = Dgv_solicita.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
