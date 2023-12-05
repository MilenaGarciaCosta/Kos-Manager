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
using Kos_Manager.Notificação;
using System.IO;

namespace Kos_Manager
{
    public partial class Tela_nivel_acesso : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;
        private string caminhoArquivoLog = "D:/home/aluno/Documents/logs.txt";
        private string caminhoLogUpdate = "D:/home/aluno/Documents/logs_update.txt";
        private string caminhoArquivoLogDeletar = "D:/home/aluno/Documents/logs_delete.txt";
        public Tela_nivel_acesso()
        {
            InitializeComponent();
            ListarNiveis();
        }

        string id;


        private void LimparDados()
        {
            // Limpar TextBox
            txt_nome.Clear();
           

        }


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
            string caminhoDoArquivoDeLog = "C:/Users/Joao A//Documents//logs.txt";
            Logger logger = new Logger(caminhoDoArquivoDeLog);
            logger.Log(message);
        }

        private void RegistrarLogAtualizacao(string message)
        {
            string caminhoLogUpdate = "C:/Users/Joao A//Documents//logs_update.txt";
            Logger logger = new Logger(caminhoLogUpdate);
            logger.Log(message);
        }

        private void RegistrarLogDeletar(string message)
        {
            string caminhoArquivoLogDeletar = "C:/Users/Joao A//Documents//logs_delete.txt";
            Logger logger = new Logger(caminhoArquivoLogDeletar);
            logger.Log(message);
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
                LimparDados();
                con.Close();

                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Nível de acesso {nome} foi adicionado!";

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
                MessageBox.Show("Aconteceu o Erro:" + erro);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
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
            LimparDados();
            con.Close();

            // Mensagem para registrar no log
            string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Nível de acesso {nome} foi atualizado!";

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
            LimparDados();
            con.Close();

            // Mensagem para registrar no log
            string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Nível de acesso {id} foi deletado!";

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
            // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
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

        private void Tela_nivel_acesso_Load(object sender, EventArgs e)
        {
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
