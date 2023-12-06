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
    using System.Drawing.Drawing2D;
    using System.Runtime.InteropServices;
    using Kos_Manager.Notificação;
    using System.Text.RegularExpressions;
    using System.IO; 

    namespace Kos_Manager
    {

   
        public partial class Tela_fornecedor : Form
        {



            string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;
		// Caminho do arquivo de log
		// Caminho do arquivo de log
		private string caminhoArquivoLog = "D:/home/aluno/Documents/logs.txt";
		private string caminhoLogUpdate = "D:/home/aluno/Documents/logs_update.txt";
		private string caminhoArquivoLogDeletar = "D:/home/aluno/Documents/logs_delete.txt";



		public Tela_fornecedor()
            {

                InitializeComponent();
                ListarFornecedores();

            // Evento TextChanged para a TextBox Txt_tel_fornecedor
            Txt_tel_fornecedor.TextChanged += Txt_tel_fornecedor_TextChanged;


        }

        private void Txt_tel_fornecedor_TextChanged(object sender, EventArgs e)
        {
            string texto = Txt_tel_fornecedor.Text;
            string numero = Regex.Replace(texto, @"[^\d]", "");

            if (numero.Length > 11)
            {
                numero = numero.Substring(0, 11);
            }

            if (numero.Length >= 2)
            {
                string formato = "";

                if (numero.Length == 11)
                {
                    formato = @"(00) 00000-0000"; // Formato para número de celular
                }
                else if (numero.Length == 10)
                {
                    formato = @"(00) 0000-0000"; // Formato para número de telefone fixo
                }
                else if (numero.Length >= 6)
                {
                    formato = @"(00) 0000-0000"; // Pode ser ajustado conforme necessário
                }
                else if (numero.Length >= 2)
                {
                    formato = @"(00) 0000-0000"; // Pode ser ajustado conforme necessário
                }

                string numeroFormatado = "";

                int index = 0;
                foreach (char c in formato)
                {
                    if (c == '0' && index < numero.Length)
                    {
                        numeroFormatado += numero[index];
                        index++;
                    }
                    else if (c == '0')
                    {
                        break;
                    }
                    else
                    {
                        numeroFormatado += c;
                    }
                }

                Txt_tel_fornecedor.Text = numeroFormatado;
                Txt_tel_fornecedor.SelectionStart = Txt_tel_fornecedor.Text.Length;
            }
        }





        string id;

            public void ListarFornecedores()
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_fornecedor = @"
                        SELECT 
                            TB_FORNECEDOR_ID  as id,
						    TB_FORNECEDOR_NOME as Nome,
						    TB_FORNECEDOR_PRODUTO as Produto,
						    TB_FORNECEDOR_CONTATO as Contato,
						    TB_FORNECEDOR_OUTRO_CONTATO as Outro
                            from tb_fornecedor";

                con.Open();

                DataTable tabela_fornecedor = new DataTable();

                MySqlDataAdapter da_estoqueMp = new MySqlDataAdapter(sql_select_fornecedor, con);
                da_estoqueMp.Fill(tabela_fornecedor);

                DgvFornecedor.DataSource = tabela_fornecedor;

                con.Close();


            }

            private void Child_panel_Paint(object sender, PaintEventArgs e)
            {

            }


            private void Tela_fornecedor_Load(object sender, EventArgs e)
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
                }


                // Inicia a leitura do log
                LerLog();
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

            private void LimparDados()
            {
                // Limpar TextBox
                Txt_nome_fornecedor.Clear();
                Txt_produto_fornecido.Clear();
                Txt_tel_fornecedor.Clear();
                Txt_outro_contato_fornecedor.Clear();
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
                string caminhoDoArquivoDeLog = "D:/home/aluno/Documents/logs.txt";
			Logger logger = new Logger(caminhoDoArquivoDeLog);
                logger.Log(message);
            }

            private void RegistrarLogAtualizacao(string message)
            {
                string caminhoLogUpdate = "D:/home/aluno/Documents/logs_update.txt";
			Logger logger = new Logger(caminhoLogUpdate);
                logger.Log(message);
            }

            private void RegistrarLogDeletar(string message)
            {
                string caminhoArquivoLogDeletar = "D:/home/aluno/Documents/logs_delete.txt" ;
            Logger logger = new Logger(caminhoArquivoLogDeletar);
                logger.Log(message);
            }





            //Public de notificação
            public void Alert(string msg, Form_Alert.enmType type)
            {
                Form_Alert frm = new Form_Alert();
                frm.showAlert(msg, type);
            }
            private void Btn_adicionar_Click(object sender, EventArgs e)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome = Txt_nome_fornecedor.Text;
                    string produto = Txt_produto_fornecido.Text;
                    string contato = Txt_tel_fornecedor.Text;
                    string outro_tel = Txt_outro_contato_fornecedor.Text;

                    string sql_insert = @"insert into tb_fornecedor
                    (  
                  
                      TB_FORNECEDOR_NOME, 
                      TB_FORNECEDOR_PRODUTO, 
                      TB_FORNECEDOR_CONTATO, 
                      TB_FORNECEDOR_OUTRO_CONTATO
                     )
                    values
                    (
                        @FORNECEDOR_NOME, @FORNECEDOR_PRODUTO, @FORNECEDOR_CONTATO, @FORNECEDOR_OUTRO_CONTATO
                     )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_NOME", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_PRODUTO", produto);
                    executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_CONTATO", contato);
                    executacmdMySql_insert.Parameters.AddWithValue("@FORNECEDOR_OUTRO_CONTATO", outro_tel); 

                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();
                    ListarFornecedores();
                    LimparDados();
                    con.Close();

                    // Mensagem para registrar no log
                    string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Fornecedor {nome} foi adicionado!";

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

                MySqlConnection con = new MySqlConnection(conexao); 


                string id = this.id;
                string nome = Txt_nome_fornecedor.Text;
                string produto = Txt_produto_fornecido.Text;
                string contato = Txt_tel_fornecedor.Text;
                string outro_ctt = Txt_outro_contato_fornecedor.Text;


            


                string sql_update_fornecedor = @"update tb_fornecedor 
                                      set 
                                          TB_FORNECEDOR_NOME = @nome,
                                          TB_FORNECEDOR_PRODUTO = @produto,
                                          TB_FORNECEDOR_CONTATO = @contato,
                                          TB_FORNECEDOR_OUTRO_CONTATO = @outro
                                      where tb_fornecedor_id = @id";





                MySqlCommand executacmdMySql_update_fornecedor = new MySqlCommand(sql_update_fornecedor, con);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@id", id);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@produto", produto);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@contato", contato);
                executacmdMySql_update_fornecedor.Parameters.AddWithValue("@outro", outro_ctt);

                con.Open();
                executacmdMySql_update_fornecedor.ExecuteNonQuery();


                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Fornecedor {nome} foi Atualizado!";

                // Chamada para registrar o log
                RegistrarLogAtualizacao(mensagemLog);

                // Adiciona a saída do console para o arquivo de log
                using (StreamWriter streamWriter = File.AppendText(caminhoLogUpdate))
                {
                    streamWriter.WriteLine(mensagemLog);
                }

                //notificação
                this.Alert("Atualizado com sucesso", Form_Alert.enmType.Update);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);

                ListarFornecedores();
                LimparDados();

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

                string sql_delete_fornecedor = @"DELETE FROM tb_fornecedor WHERE tb_fornecedor_id = @codigo";

                MySqlCommand executarcmdMySql_delete_fornecedor = new MySqlCommand(sql_delete_fornecedor, con);

                executarcmdMySql_delete_fornecedor.Parameters.AddWithValue("@codigo", codigo);

                executarcmdMySql_delete_fornecedor.ExecuteNonQuery();

                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Fornecedor {id} foi Deletado!";

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

                ListarFornecedores();
                LimparDados();

                // Fechando conexão
                con.Close();
            }

            private void Btn_voltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void DgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                this.id = DgvFornecedor.CurrentRow.Cells[0].Value.ToString();
                Txt_nome_fornecedor.Text = DgvFornecedor.CurrentRow.Cells[1].Value.ToString();
                Txt_produto_fornecido.Text = DgvFornecedor.CurrentRow.Cells[2].Value.ToString();
                Txt_tel_fornecedor.Text = DgvFornecedor.CurrentRow.Cells[3].Value.ToString();
                Txt_outro_contato_fornecedor.Text = DgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
