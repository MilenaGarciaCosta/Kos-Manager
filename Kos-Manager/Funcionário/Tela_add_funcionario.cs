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

namespace Kos_Manager
{
    public partial class Tela_add_funcionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["BD_KOSMANAGER"].ConnectionString;

        public Tela_add_funcionario()
        {
            InitializeComponent();
        }

        public void ListarFuncionario()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_select_funcionario = @"SELECT 
				 f.tb_funcionario_id AS Id,
                 f.tb_funcionario_nome AS Nome,
                 f.tb_funcionario_email AS Email,
                 f.tb_funcionario_senha AS Senha,
                 s.tb_status_nome AS Status,
                 n.tb_nivel_acesso_nome AS Nivel_de_Acesso

            FROM
                tb_funcionario f
            INNER JOIN
                tb_status s ON f.tb_status_id = s.tb_status_id
                INNER JOIN
                tb_nivel_acesso n ON f.tb_nivel_acesso_id = n.tb_nivel_acesso_id";


            con.Open();

            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();



            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);



            //DgvFuncionario.DataSource = tabela_funcionario; datagridview


            con.Close();
        }


        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome = Txt_nome_funcionario.Text;
                string email = Txt_email_funcionario.Text;
                string senha = Txt_senha_funcionario.Text;
                int cmbnivelId = Convert.ToInt32(cmb_nivel_funcionario.SelectedValue); // Use SelectedValue para obter o ID do nível de acesso
                int cmbstatusId = Convert.ToInt32(cmb_status_funcionario.SelectedValue); // Use SelectedValue para obter o ID do status

                string sql_insert = @"INSERT INTO tb_funcionario
                            (  
                                tb_funcionario_nome, 
                                tb_funcionario_email,
                                tb_funcionario_senha,
                                tb_nivel_acesso_id,
                                tb_status_id
                            )
                            VALUES
                            (
                                @funcionario_nome, @funcionario_email, @funcionario_senha, @nivel_acesso_id, @status_id
                             )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@funcionario_senha", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@nivel_acesso_id", cmbnivelId);
                executacmdMySql_insert.Parameters.AddWithValue("@status_id", cmbstatusId);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                ListarFuncionario();
                con.Close();
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro:" + erro);
            }

            ClearTextBoxes(this.Controls);
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tela_add_funcionario_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_funcionario = @"SELECT 
				f.tb_funcionario_id AS Id,
                 f.tb_funcionario_nome AS Nome,
                 f.tb_funcionario_email AS Email,
                 f.tb_funcionario_senha AS Senha,
                 s.tb_status_nome AS Status,
                 n.tb_nivel_acesso_nome AS Nivel_de_Acesso

            FROM
                tb_funcionario f
            INNER JOIN
                tb_status s ON f.tb_status_id = f.tb_status_id
                INNER JOIN
                tb_nivel_acesso n ON n.tb_nivel_acesso_id = f.tb_nivel_acesso_id ";
            string sql_select_nivel = "select * from tb_nivel_acesso";
            string sql_select_status = "select * from tb_status";

            //Execute o cargo e funcionario
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            MySqlCommand executacmdMySql_select_nivel = new MySqlCommand(sql_select_nivel, con);
            MySqlCommand executacmdMySql_select_status = new MySqlCommand(sql_select_status, con);
            con.Open();

            executacmdMySql_select_funcionario.ExecuteNonQuery();
            executacmdMySql_select_nivel.ExecuteNonQuery();
            executacmdMySql_select_status.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();
            DataTable tabela_nivel = new DataTable();
            DataTable tabela_status = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            MySqlDataAdapter da_nivel = new MySqlDataAdapter(executacmdMySql_select_nivel);
            da_nivel.Fill(tabela_nivel);

            MySqlDataAdapter da_status = new MySqlDataAdapter(executacmdMySql_select_status);
            da_status.Fill(tabela_status);

    

            cmb_nivel_funcionario.DataSource = tabela_nivel;

            cmb_nivel_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_nivel_funcionario.DisplayMember = "TB_NIVEL_ACESSO_NOME"; //Exibe os dados para o usuário
            cmb_nivel_funcionario.ValueMember = "TB_NIVEL_ACESSO_ID";  //Pega os dados     
            
            cmb_nivel_funcionario.SelectedItem = null;

            cmb_status_funcionario.DataSource = tabela_status;

            cmb_status_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status_funcionario.DisplayMember = "TB_STATUS_NOME"; //Exibe os dados para o usuário
            cmb_status_funcionario.ValueMember = "TB_STATUS_ID";  //Pega os dados            
            cmb_status_funcionario.SelectedItem = null;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
