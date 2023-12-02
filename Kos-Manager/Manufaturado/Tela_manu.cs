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
using Kos_Manager.Notificação;
using System.IO;

namespace Kos_Manager
{
    public partial class Tela_manu : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;
        private string caminhoArquivoLog = "C:/Users/Joao A/Documents/logs.txt";
        private string caminhoLogUpdate = "C:/Users/Joao A/Documents/logs_update.txt";
        private string caminhoArquivoLogDeletar = "C:/Users/Joao A/Documents/logs_delete.txt";

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

            
        //Public de notificação
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
                LimparDados();
                con.Close();

                // Mensagem para registrar no log
                string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Produto manufatorado {produto} foi adicionado!";

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


            // Mensagem para registrar no log
            string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Produto manufatorado {produto} foi atualizado!";

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
            ListarEstoquePm();
            LimparDados();
            con.Close();

            // this.Alert("Falha ao atualizar: " + erro, Form_Alert.enmType.Warning);

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {

            string id = this.id;

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                // Verificar se existem referências na tabela tb_venda
                string sql_check_references = "SELECT COUNT(*) FROM tb_venda WHERE tb_produto_manu_id = @codigo";

                MySqlCommand cmdCheckReferences = new MySqlCommand(sql_check_references, con);
                cmdCheckReferences.Parameters.AddWithValue("@codigo", id);

                con.Open();
                int referencesCount = Convert.ToInt32(cmdCheckReferences.ExecuteScalar());
                con.Close();

                if (referencesCount > 0)
                {
                    // Existem referências na tabela tb_venda, exiba uma mensagem ou tome outra ação apropriada.
                    MessageBox.Show("Não é possível excluir o produto porque há vendas associadas a ele.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Não há referências, pode excluir o produto da tabela tb_produto_manu
                    con.Open();

                    string sql_delete_produto_manu = "DELETE FROM tb_produto_manu WHERE tb_produto_manu_id = @codigo";

                    MySqlCommand executarcmdMySql_delete_produto_manu = new MySqlCommand(sql_delete_produto_manu, con);
                    executarcmdMySql_delete_produto_manu.Parameters.AddWithValue("@codigo", id);

                    executarcmdMySql_delete_produto_manu.ExecuteNonQuery();


                    // Mensagem para registrar no log
                    string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Produto manufatorado {id} foi deletado!";

                    // Chamada para registrar o log
                    RegistrarLog(mensagemLog);

                    // Adiciona a saída do console para o arquivo de log
                    using (StreamWriter streamWriter = File.AppendText(caminhoArquivoLogDeletar))
                    {
                        streamWriter.WriteLine(mensagemLog);
                    }

                    // Atualiza a exibição do log na tela
                    LerLog();


                    //notificação aqui
                    ListarEstoquePm();
                    LimparDados();
                    //notificação
                    this.Alert("Deletado com sucesso", Form_Alert.enmType.Delete);
                }
            }
            catch (Exception erro)
            {
                // Tratar exceções, exibir mensagem de erro, etc.
                MessageBox.Show("Erro ao excluir o produto: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fechar conexão
                con.Close();
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvEstoquePm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = DgvEstoquePm.CurrentRow.Cells[0].Value.ToString();
            Txt_nome_produto_manu.Text = DgvEstoquePm.CurrentRow.Cells[1].Value.ToString();

            // Formatação das datas e atribuição aos campos de texto
            if (DgvEstoquePm.CurrentRow.Cells[2].Value is DateTime)
            {
                DateTime dtFab = (DateTime)DgvEstoquePm.CurrentRow.Cells[2].Value;
                Txt_dt_fab.Text = dtFab.ToString("dd/MM/yyyy");
            }
            else
            {
                Txt_dt_fab.Text = DgvEstoquePm.CurrentRow.Cells[2].Value.ToString();
            }

            if (DgvEstoquePm.CurrentRow.Cells[3].Value is DateTime)
            {
                DateTime dtValidade = (DateTime)DgvEstoquePm.CurrentRow.Cells[3].Value;
                Txt_dt_validade.Text = dtValidade.ToString("dd/MM/yyyy");
            }
            else
            {
                Txt_dt_validade.Text = DgvEstoquePm.CurrentRow.Cells[3].Value.ToString();
            }

            Txt_lote.Text = DgvEstoquePm.CurrentRow.Cells[4].Value.ToString();
            Txt_quantidade.Text = DgvEstoquePm.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
