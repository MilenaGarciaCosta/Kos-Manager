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
using static Guna.UI2.Native.WinApi;
using System.Web.UI.WebControls.WebParts;

namespace Kos_Manager
{
    public partial class Tela_requisicao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;
        private string caminhoArquivoLog = "C:/Users/paulo/Documents/logs.txt";
        private string caminhoLogUpdate = "C:/Users/paulo/Documents/logs_update.txt";
        private string caminhoArquivoLogDeletar = "C:/Users/paulo/Documents/logs_delete.txt";
        public Tela_requisicao()
        {
            InitializeComponent();
            ListarRequisicao();
        }

        string id;

        public void ListarRequisicao()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_requisicao = @"
                           SELECT
                     r.tb_requisicao_id AS Id,
                     p.TB_PRODUTO_MANU_NOME AS Nome,
                     r.tb_requisicao_quantidade as Quantidade,
                     s.tb_requisicao_status_nome as Status
                    FROM
                     tb_requisicao r
                     INNER JOIN
                     TB_PRODUTO_MANU p ON p.TB_PRODUTO_MANU_id = r.TB_PRODUTO_MANU_id
                        INNER JOIN
                     tb_requisicao_status s ON s.tb_requisicao_status_id = r.tb_requisicao_status_id ";

            con.Open();

            DataTable tabela_requisicao = new DataTable();

            MySqlDataAdapter da_requisicao = new MySqlDataAdapter(sql_select_requisicao, con);
            da_requisicao.Fill(tabela_requisicao);

            Dgv_requisita.DataSource = tabela_requisicao;

            con.Close();


        }


        private void LimparDados()
        {
            // Limpar TextBox
            Txt_quantidade.Clear();

            // Limpar ComboBox
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
            string caminhoDoArquivoDeLog = "C:/Users/paulo/Documents/logs.txt";
            Logger logger = new Logger(caminhoDoArquivoDeLog);
            logger.Log(message);
        }

        private void RegistrarLogAtualizacao(string message)
        {
            string caminhoLogUpdate = "C:/Users/paulo/Documents/logs_update.txt";
            Logger logger = new Logger(caminhoLogUpdate);
            logger.Log(message);
        }

        private void RegistrarLogDeletar(string message)
        {
            string caminhoArquivoLogDeletar = "C:/Users/paulo/Documents/logs_delete.txt";
            Logger logger = new Logger(caminhoArquivoLogDeletar);
            logger.Log(message);
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string quantidade = Txt_quantidade.Text;
                int cmb_Status = Convert.ToInt32(cmb_status_requisicao.SelectedValue);
                int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);

                string sql_insert = @"insert into TB_REQUISICAO
                (  
                 
                   TB_REQUISICAO_QUANTIDADE,
                   TB_REQUISICAO_STATUS_ID,
                   TB_PRODUTO_MANU_ID
            
                 )
                values
                (
                   @REQUISICAO_QUANTIDADE, @REQUISICAO_STATUS, @PRODUTO_MANU_ID
                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@REQUISICAO_QUANTIDADE", quantidade);
                executacmdMySql_insert.Parameters.AddWithValue("@REQUISICAO_STATUS", cmb_Status);
                executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_ID", cmb_Produto);


                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarRequisicao();
                LimparDados();
                con.Close();
                
                // Limpar a seleção da ComboBox após adicionar os dados
                cmb_nome_produto.SelectedItem = null;
                cmb_status_requisicao.SelectedItem = null;

                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Requisição de quantidade {quantidade} foi adicionada!";

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
            string id = this.id;
            int quantidade = Convert.ToInt32(Txt_quantidade.Text);
            int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
            int cmb_Status = Convert.ToInt32(cmb_status_requisicao.SelectedValue);

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                

                string sql_update_tb_requisicao = @"UPDATE tb_requisicao
            SET tb_requisicao_quantidade = @quantidade,
                tb_requisicao_status_id = @status,
                tb_produto_manu_id = @produto
            WHERE tb_requisicao_id = @id";

                MySqlCommand executacmdMySql_update_tb_requisicao = new MySqlCommand(sql_update_tb_requisicao, con);

                    
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@quantidade", quantidade);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@status", cmb_Status);
                executacmdMySql_update_tb_requisicao.Parameters.AddWithValue("@produto", cmb_Produto);

                con.Open();
                executacmdMySql_update_tb_requisicao.ExecuteNonQuery();
                ListarRequisicao();
                LimparDados();
                con.Close();

                // Limpar a seleção da ComboBox após adicionar os dados
                cmb_nome_produto.SelectedItem = null;
                cmb_status_requisicao.SelectedItem = null;


                //Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Requisição do id {id} foi atualizada!";

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

                // this.Alert("Falha ao atualizar: " + erro, Form_Alert.enmType.Warning);
            }
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID da solicitação que deseja excluir
                string id = this.id;

                MySqlConnection con = new MySqlConnection(conexao);

                // Define a consulta SQL para exclusão
                string sql_delete_tb_requisicao = "DELETE FROM tb_requisicao WHERE tb_requisicao_id = @id";

                MySqlCommand executacmdMySql_delete_tb_requisicao = new MySqlCommand(sql_delete_tb_requisicao, con);
                executacmdMySql_delete_tb_requisicao.Parameters.AddWithValue("@id", id);

                con.Open();
                executacmdMySql_delete_tb_requisicao.ExecuteNonQuery();
                LimparDados();
                con.Close();



                //Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Requisição do id {id} foi deletada!";

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

                // Atualize a exibição da lista de solicitações
                ListarRequisicao();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);

                // this.Alert("Falha ao deletar: " + erro, Form_Alert.enmType.Warning);
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Child_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_requisita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Dgv_requisita.CurrentRow.Cells[0].Value.ToString();
            cmb_nome_produto.Text = Dgv_requisita.CurrentRow.Cells[1].Value.ToString();
            Txt_quantidade.Text = Dgv_requisita.CurrentRow.Cells[2].Value.ToString();
            cmb_status_requisicao.Text = Dgv_requisita.CurrentRow.Cells[3].Value.ToString();
        }

        private void Tela_requisicao_Load(object sender, EventArgs e)
        {
            //MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

                        string sql_select_requisicao = @"
            SELECT
                            r.tb_requisicao_id AS Id,
                            pm.tb_produto_manu_nome AS Nome,
                            r.tb_requisicao_quantidade as Quantidade,
                            rs.tb_requisicao_status_nome as Status
                
                        FROM
                            tb_requisicao r
                            INNER JOIN tb_produto_manu pm ON pm.tb_produto_manu_id = r.tb_produto_manu_id
                            INNER JOIN tb_requisicao_status rs ON rs.tb_requisicao_status_id = r.tb_requisicao_status_id";


            string sql_select_produto = "select * from tb_produto_manu";
            string sql_select_status = "select * from tb_requisicao_status";

            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            MySqlCommand executacmdMySql_select_requisicao = new MySqlCommand(sql_select_requisicao, con);
            con.Open();

            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();
            executacmdMySql_select_requisicao.ExecuteNonQuery();

            DataTable tabela_requisicao = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_status = new DataTable();

            MySqlDataAdapter da_solicitacao = new MySqlDataAdapter(executacmdMySql_select_requisicao);
            da_solicitacao.Fill(tabela_requisicao);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);



            Dgv_requisita.DataSource = tabela_requisicao;


            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_PRODUTO_MANU_NOME"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_PRODUTO_MANU_ID";  //Pega os dados            
            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.SelectedItem = null;


            cmb_status_requisicao.DataSource = tabela_status;

            cmb_status_requisicao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_requisicao.DisplayMember = "TB_REQUISICAO_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_requisicao.ValueMember = "TB_REQUISICAO_STATUS_ID";  //Pega os dados            
            cmb_status_requisicao.DataSource = tabela_status;

            cmb_status_requisicao.SelectedItem = null;

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
    }
}
