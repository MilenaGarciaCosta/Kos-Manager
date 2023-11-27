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

        public void RegistrarLog(string message)
        {
            string caminhoDoArquivoDeLog = "D:/home/aluno/Documents/logs.txt";
            Logger logger = new Logger(caminhoDoArquivoDeLog);
            logger.Log(message);
        }

        private int countTextBoxes = 0;
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
                string caminhoDoArquivoDeLog = "D:/home/aluno/Documents/logs.txt"; // Substitua pelo seu caminho
                string conteudoDoArquivoDeLog = File.ReadAllText(caminhoDoArquivoDeLog);

                textBoxLogs.Text = conteudoDoArquivoDeLog;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo de log: " + ex.Message);
            }
        }
    }
}
