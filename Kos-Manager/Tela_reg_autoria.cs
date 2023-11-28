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
        private string caminhoLogUpdate = "C:/Users/Joao A/Documents/logs_update.txt";
        private string caminhoArquivoLogDeletar = "C:/Users/Joao A/Documents/logs_delete.txt";
        private Logger logger;
        private Logger loggerUpdate;
        private Logger loggerDeletar;
        public void RegistrarLog(string message)
        {
            string caminhoDoArquivoDeLog = "C:/Users/Joao A//Documents//logs.txt";
            string caminhoLogUpdate = "C:/Users/Joao A//Documents//logs_update.txt";
            string caminhoArquivoLogDeletar = "C:/Users/Joao A//Documents//logs_delete.txt";
            Logger logger = new Logger(caminhoDoArquivoDeLog);
            Logger loggerUpdate = new Logger(caminhoLogUpdate);
            Logger loggerDelete = new Logger(caminhoArquivoLogDeletar);
            logger.Log(message);
            loggerUpdate.Log(message);
            loggerDeletar.Log(message);



        }
        public void RegistrarLogAtualizacao(string message)
        {
            // Adiciona o log de atualização no textBoxLogs_update
            textBoxLogs_update.AppendText(message + Environment.NewLine);
        }
        public void RegistrarLogDeletar(string message)
        {
            // Adiciona o log de atualização no textBoxLogs_update
            textBoxLogs_delete.AppendText(message + Environment.NewLine);
        }

        private void LerLog()
        {
             if (File.Exists(caminhoDoArquivoDeLog))
            {
                using (StreamReader streamReader = new StreamReader(caminhoDoArquivoDeLog))
                {
                    string conteudoLog = streamReader.ReadToEnd();
                    textBoxLogs.Text = conteudoLog.Replace(Environment.NewLine, "<br>");
                    textBoxLogs_update.Text = conteudoLog.Replace(Environment.NewLine, "<br>");
                }
            }
            if (File.Exists(caminhoLogUpdate))
            {
                using (StreamReader streamReader = new StreamReader(caminhoLogUpdate))
                {
                    string conteudoLog = streamReader.ReadToEnd();
                    textBoxLogs_update.Text = conteudoLog.Replace(Environment.NewLine, "<br>");
                }
            }
            if (File.Exists(caminhoArquivoLogDeletar))
            {
                using (StreamReader streamReader = new StreamReader(caminhoArquivoLogDeletar))
                {
                    string conteudoLog = streamReader.ReadToEnd();
                    textBoxLogs_delete.Text = conteudoLog.Replace(Environment.NewLine, "<br>");
                }
            }
        }
        public Tela_reg_autoria()
        {
            InitializeComponent();
            logger = new Logger(caminhoDoArquivoDeLog);
            loggerUpdate = new Logger(caminhoLogUpdate);
            loggerDeletar = new Logger(caminhoArquivoLogDeletar);
        }



        //Public de registro de autoria
        public class Logger
        {
            private string filePath;

            public Logger(string logFilePath)
            {
                filePath = logFilePath;
            }
            public void LogDeletar(string message)
            {
                try
                {
                    string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
                    File.AppendAllText(filePath, logMessage + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao registrar o log: " + ex.Message);
                }
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
                    throw new Exception("Erro ao registrar o log: " + ex.Message);
                }
            }
            public void LogAtualizacao(string message)
            {
                try
                {
                    string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
                    File.AppendAllText(filePath, logMessage + Environment.NewLine);
                }
                catch (Exception ex)
                {
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
                if (File.Exists(caminhoLogUpdate))
                {
                    using (StreamReader streamReader = new StreamReader(caminhoLogUpdate))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            textBoxLogs_update.AppendText(line + Environment.NewLine); // Aqui deve ser textBoxLogs_update
                        }
                    }
                }
                if (File.Exists(caminhoArquivoLogDeletar))
                {
                    using (StreamReader streamReader = new StreamReader(caminhoArquivoLogDeletar))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            textBoxLogs_delete.AppendText(line + Environment.NewLine); // Aqui deve ser textBoxLogs_delete
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo de log: " + ex.Message);
            }
        }


            private void Btn_limpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
