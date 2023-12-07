//using Kos_Manager.Matéria_prima;
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
using Kos_Manager.Notificação;
using System.IO;
using Google.Protobuf.WellKnownTypes;

namespace Kos_Manager
{
    public partial class Tela_vendas : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;
		// Caminho do arquivo de log
		private string caminhoArquivoLog = "C:/Users/milen/Downloads/logs.txt";
		private string caminhoLogUpdate = "C:/Users/milen/Downloads/logs_update.txt";
		private string caminhoArquivoLogDeletar = "C:/Users/milen/Downloads/logs_delete.txt";

		public Tela_vendas()
        {
            InitializeComponent();
            ListarVendas();
        }

        string id;


        public void ListarVendas()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_venda = @"
                      SELECT
                     v.tb_venda_id AS Id,
                     v.tb_venda_quantidade AS Quantidade,
                     v.tb_venda_valor as Valor,
                     p.tb_produto_manu_nome AS Produto,
                     f.tb_funcionario_nome AS Funcionario,
                     s.tb_venda_status_nome AS venda
                    FROM
                     tb_venda v
                     INNER JOIN
                     tb_produto_manu p ON v.tb_produto_manu_id = p.tb_produto_manu_id
                        INNER JOIN
                     tb_funcionario f ON v.tb_funcionario_id = f.tb_funcionario_id
                              INNER JOIN
                     tb_venda_status s ON v.tb_venda_status_id = s.tb_venda_status_id";

            con.Open();

            DataTable tabela_venda = new DataTable();

            MySqlDataAdapter da_venda = new MySqlDataAdapter(sql_select_venda, con);
            da_venda.Fill(tabela_venda);

            Dgv_venda.DataSource = tabela_venda; 

            con.Close();
        }


        private void LimparDados()
        {
            // Limpar TextBox
            Txt_quantidade.Clear();
            Txt_valor_produto.Clear();
            
            //limpar cmb
           // cmb_funcionario.Items.Clear();
           // cmb_nome_produto.Items.Clear();
           // cmb_status.Items.Clear();
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



		private void Btn_adicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string quantidade = Txt_quantidade.Text;
                    string valor = Txt_valor_produto.Text;
                    int cmb_Funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                    int cmb_Produto = Convert.ToInt32(cmb_nome_produto.SelectedValue);
                    int cmb_Venda_status = Convert.ToInt32(cmb_status.SelectedValue);

                    // Força a cultura de interpretação para Português (Brasil)
                    CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

                    // Verifique se a quantidade é maior que 0 e se o valor é um número decimal válido
                    if (int.TryParse(quantidade, out int quantidadeInt) && decimal.TryParse(valor, NumberStyles.AllowDecimalPoint, culturaBrasileira, out decimal valorDecimal) && quantidadeInt > 0)
                    {
                        // Calcule o valor total com base na quantidade e no valor unitário
                        decimal valorTotal = quantidadeInt * valorDecimal;

                        string sql_insert = @"INSERT INTO TB_VENDA
                (  
                   TB_VENDA_QUANTIDADE, 
                   TB_VENDA_VALOR,
                   TB_PRODUTO_MANU_ID, 
                   TB_FUNCIONARIO_ID,
                   TB_VENDA_STATUS_ID
                 )
                VALUES
                (
                    @VENDA_QUANTIDADE, @VENDA_VALOR, @PRODUTO_MANU_ID, @FUNCIONARIO_ID, @VENDA_STATUS_ID
                 )";

                        using (MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con))
                        {
                            executacmdMySql_insert.Parameters.AddWithValue("@VENDA_QUANTIDADE", quantidadeInt);
                            executacmdMySql_insert.Parameters.AddWithValue("@VENDA_VALOR", valorTotal);
                            executacmdMySql_insert.Parameters.AddWithValue("@PRODUTO_MANU_ID", cmb_Produto);
                            executacmdMySql_insert.Parameters.AddWithValue("@FUNCIONARIO_ID", cmb_Funcionario);
                            executacmdMySql_insert.Parameters.AddWithValue("@VENDA_STATUS_ID", cmb_Venda_status);

                            con.Open();
                            executacmdMySql_insert.ExecuteNonQuery();
                            ListarVendas();
                            con.Close();
                            LimparDados();

                            // Limpar a seleção da ComboBox após adicionar os dados
                            cmb_nome_produto.SelectedItem = null;
                            cmb_funcionario.SelectedItem = null;
                            cmb_status.SelectedItem = null;

                            // Mensagem para registrar no log
                            string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Venda do valor total de {valorTotal} foi adicionada!";

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
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + erro.Message);
                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }
        }


        private void Btn_atualizar_Click(object sender, EventArgs e)
        {
            string id = this.id;
            string quantidade = Txt_quantidade.Text;
            decimal valor = decimal.Parse(Txt_valor_produto.Text, CultureInfo.GetCultureInfo("pt-BR")); // Converter para decimal
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
            executacmdMySql_update_venda.Parameters.AddWithValue("@id", id);

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

            ListarVendas();

            con.Close();

            LimparDados();

            // Limpar a seleção da ComboBox após adicionar os dados
            cmb_nome_produto.SelectedItem = null;
            cmb_funcionario.SelectedItem = null;
            cmb_status.SelectedItem = null;

            // Mensagem para registrar no log
            string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Venda do valor de {valor} foi atualizada!";

            // Chamada para registrar o log
            RegistrarLog(mensagemLog);

            // Adiciona a saída do console para o arquivo de log
            using (StreamWriter streamWriter = File.AppendText(caminhoLogUpdate))
            {
                streamWriter.WriteLine(mensagemLog);
            }

            // Atualiza a exibição do log na tela
            LerLog();

            this.Alert("Atualizado com sucesso", Form_Alert.enmType.Update);

        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            // Declarando variável a
            string id = this.id;

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_venda = @"DELETE FROM tb_venda WHERE tb_venda_id = @id";

            MySqlCommand executarcmdMySql_delete_venda = new MySqlCommand(sql_delete_venda, con);

            executarcmdMySql_delete_venda.Parameters.AddWithValue("@id", id);

            executarcmdMySql_delete_venda.ExecuteNonQuery();

            // Mensagem para registrar no log
            string mensagemLog = $"[{DateTime.Now:dd/MM HH:mm}] - Venda do id {id} foi deletada!";

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
            ListarVendas();

            // Fechando conexão
            con.Close();

            LimparDados();
            // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
        }

        private void Tela_vendas_Load(object sender, EventArgs e)
        {
            // MOSTRAR OS DADOS DO COMBOBOX

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_venda = @"
                     SELECT
                     v.tb_venda_id AS Id,
                     v.tb_venda_quantidade AS Quantidade,
                     v.tb_venda_valor as Valor,
                     p.tb_produto_manu_nome AS Produto,
                     f.tb_funcionario_nome AS Funcionario,
                     s.tb_venda_status_nome AS Status
                    FROM
                     tb_venda v
                     INNER JOIN
                     tb_produto_manu p ON v.tb_produto_manu_id = p.tb_produto_manu_id
                        INNER JOIN
                     tb_funcionario f ON v.tb_funcionario_id = f.tb_funcionario_id
                              INNER JOIN
                     tb_venda_status s ON v.tb_venda_status_id = s.tb_venda_status_id";

            string sql_select_produto = "select * from tb_produto_manu";
            string sql_select_venda_status = "select * from tb_venda_status";
            string sql_select_funcionario = "select * from tb_funcionario";

            MySqlCommand executacmdMySql_select_venda = new MySqlCommand(sql_select_venda, con);
            MySqlCommand executacmdMySql_select_produto = new MySqlCommand(sql_select_produto, con);
            MySqlCommand executacmdMySql_select_venda_status = new MySqlCommand(sql_select_venda_status, con);
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);

            con.Open();

            executacmdMySql_select_venda.ExecuteNonQuery();
            executacmdMySql_select_produto.ExecuteNonQuery();
            executacmdMySql_select_venda_status.ExecuteNonQuery();
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_venda = new DataTable();
            DataTable tabela_produto = new DataTable();
            DataTable tabela_venda_status = new DataTable();
            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_venda = new MySqlDataAdapter(executacmdMySql_select_venda);
            da_venda.Fill(tabela_venda);

            MySqlDataAdapter da_produto = new MySqlDataAdapter(executacmdMySql_select_produto);
            da_produto.Fill(tabela_produto);

            MySqlDataAdapter da_venda_status = new MySqlDataAdapter(executacmdMySql_select_venda_status);
            da_venda_status.Fill(tabela_venda_status);

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            Dgv_venda.DataSource = tabela_venda;


            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nome_produto.DisplayMember = "TB_PRODUTO_MANU_NOME"; //Exibe os dados para o usuário
            cmb_nome_produto.ValueMember = "TB_PRODUTO_MANU_ID";  //Pega os dados            
            cmb_nome_produto.DataSource = tabela_produto;

            cmb_nome_produto.SelectedItem = null;


            cmb_status.DataSource = tabela_venda_status;

            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status.DisplayMember = "TB_VENDA_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status.ValueMember = "TB_VENDA_STATUS_ID";  //Pega os dados            
            cmb_status.DataSource = tabela_venda_status;

            cmb_status.SelectedItem = null;


            cmb_funcionario.DataSource = tabela_funcionario;

            cmb_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_funcionario.DisplayMember = "TB_funcionario_NOME"; //Exibe os dados para o usuário
            cmb_funcionario.ValueMember = "TB_funcionario_ID";  //Pega os dados            
            cmb_funcionario.DataSource = tabela_funcionario;

            cmb_funcionario.SelectedItem = null;

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

        private void Link_ja_tem_cad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Dgv_venda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                this.id = Dgv_venda.CurrentRow.Cells[0].Value.ToString();
                Txt_quantidade.Text = Dgv_venda.CurrentRow.Cells[1].Value.ToString();

                // Obter o valor da célula e formatá-lo para exibição
                string valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Dgv_venda.CurrentRow.Cells[2].Value);
                Txt_valor_produto.Text = valorFormatado;

                cmb_nome_produto.Text = Dgv_venda.CurrentRow.Cells[3].Value.ToString();
                cmb_funcionario.Text = Dgv_venda.CurrentRow.Cells[4].Value.ToString();
                cmb_status.Text = Dgv_venda.CurrentRow.Cells[5].Value.ToString();
           
        }
    }
}
