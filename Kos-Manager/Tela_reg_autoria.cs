using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kos_Manager
{
    public partial class Tela_reg_autoria : Form
    {
        private string caminhoDoArquivoDeLog = "C:/Users/Joao A/Documents/logs.txt";
        public void RegistrarLog(string message)
        {
            string caminhoDoArquivoDeLog = "C:/Users/Joao A//Documents//logs.txt";
            Logger logger = new Logger(caminhoDoArquivoDeLog);
            logger.Log(message);
        }

        private void LerLog()
        {
            // Verifica se o arquivo de log existe
            if (File.Exists(caminhoDoArquivoDeLog))
            {
                using (StreamReader streamReader = new StreamReader(caminhoDoArquivoDeLog))
                {
                    // Lê o conteúdo do arquivo de log
                    string conteudoLog = streamReader.ReadToEnd();

                    // Exibe os registros na caixa de texto como uma lista
                    textBoxLogs.Text = conteudoLog.Replace(Environment.NewLine, "<br>");
                }
            }
        }
        public Tela_reg_autoria()
        {
            InitializeComponent();
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
                    string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
                    File.AppendAllText(filePath, logMessage + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    // Lida com possíveis erros ao registrar o log
                    throw new Exception("Erro ao registrar o log: " + ex.Message);
                }
            }

        }





        private void Tela_reg_autoria_Load(object sender, EventArgs e)
        {
            ExibirLogsNoTextBox();
        }

        private void TextBoxLogs_TextChanged(object sender, EventArgs e)
        {

        }
        private void ExibirLogsNoTextBox()
        {
            try
            {
                if (File.Exists(caminhoDoArquivoDeLog))
                {
                    using (StreamReader streamReader = new StreamReader(caminhoDoArquivoDeLog))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            textBoxLogs.AppendText(line + Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo de log: " + ex.Message);
            }
        }
    }
}
