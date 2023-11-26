using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Kos_Manager.Notificação;

namespace Kos_Manager
{
    public partial class Tela_funcionarios : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["bd_kosmanager"].ConnectionString;

        public Tela_funcionarios()
        {
            InitializeComponent();
            ListarFuncionario();
        }

        string id; 

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

            Dgv_funcionario.DataSource = tabela_funcionario;


            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_funcionarios_Load(object sender, EventArgs e)
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

           // DgvFuncionario.DataSource = tabela_funcionario;

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


        private void LimparDados()
        {
            // Limpar TextBox
            Txt_nome_funcionario.Clear();
            Txt_email_funcionario.Clear();
            Txt_senha_funcionario.Clear();

            
        }

        //Public de notificação
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void Btn_adicionar_Click_2(object sender, EventArgs e)
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
                LimparDados();
                // Limpar a seleção da ComboBox após adicionar os dados
                cmb_nivel_funcionario.SelectedItem = null;
                cmb_status_funcionario.SelectedItem = null;

                //notificação
                this.Alert("Adicionado com sucesso", Form_Alert.enmType.Sucess);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o Erro:" + erro);

                // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);
            }

        }

        private void Btn_atualizar_Click_1(object sender, EventArgs e)
        {
           // string id = txt_cod.Text;
            string nome = Txt_nome_funcionario.Text;
            string email = Txt_email_funcionario.Text;
            string senha = Txt_senha_funcionario.Text;
            int cmb_Nivel = Convert.ToInt32(cmb_nivel_funcionario.SelectedValue);
            int cmb_Status = Convert.ToInt32(cmb_status_funcionario.SelectedValue);

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_update_venda = @"update tb_funcionario
    set tb_funcionario_nome = @nome,
        tb_funcionario_email = @email,
        tb_funcionario_senha = @senha,
        tb_status_id = @status,
        tb_nivel_acesso_id = @nivel
    where tb_funcionario_id = @id";

            MySqlCommand executacmdMySql_update_venda = new MySqlCommand(sql_update_venda, con);
            executacmdMySql_update_venda.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_venda.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_venda.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_venda.Parameters.AddWithValue("@senha", senha);
            executacmdMySql_update_venda.Parameters.AddWithValue("@status", cmb_Status);
            executacmdMySql_update_venda.Parameters.AddWithValue("@nivel", cmb_Nivel);
            con.Open();
            executacmdMySql_update_venda.ExecuteNonQuery();

            

            ListarFuncionario();

            con.Close();
        }

        private void Btn_atualizar_Click_2(object sender, EventArgs e)
        {
            string id = this.id;
            string nome = Txt_nome_funcionario.Text;
            string email = Txt_email_funcionario.Text;
            string senha = Txt_senha_funcionario.Text;
            int cmb_Nivel = Convert.ToInt32(cmb_nivel_funcionario.SelectedValue);
            int cmb_Status = Convert.ToInt32(cmb_status_funcionario.SelectedValue);

            MySqlConnection con = new MySqlConnection(conexao);

            string sql_update_venda = @"update tb_funcionario
    set tb_funcionario_nome = @nome,
        tb_funcionario_email = @email,
        tb_funcionario_senha = @senha,
        tb_status_id = @status,
        tb_nivel_acesso_id = @nivel
    where tb_funcionario_id = @id";

            MySqlCommand executacmdMySql_update_venda = new MySqlCommand(sql_update_venda, con);
            executacmdMySql_update_venda.Parameters.AddWithValue("@id", id);
            executacmdMySql_update_venda.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_venda.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_venda.Parameters.AddWithValue("@senha", senha);
            executacmdMySql_update_venda.Parameters.AddWithValue("@status", cmb_Status);
            executacmdMySql_update_venda.Parameters.AddWithValue("@nivel", cmb_Nivel);
            con.Open();
            executacmdMySql_update_venda.ExecuteNonQuery();

            //notificação
            this.Alert("Atualizado com sucesso", Form_Alert.enmType.Update);
            // this.Alert("Falha ao adicionar: " + erro, Form_Alert.enmType.Warning);

            ListarFuncionario();
            // Limpar a seleção da ComboBox após adicionar os dados
            cmb_nivel_funcionario.SelectedItem = null;
            cmb_status_funcionario.SelectedItem = null;
            con.Close();
        }

        private void Btn_deletar_Click_1(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.id);

            // Conectando ao banco de dados MySql
            MySqlConnection con = new MySqlConnection(conexao);

            // Abrindo conexão
            con.Open();

            string sql_delete_funcionario = @"DELETE FROM tb_funcionario WHERE tb_funcionario_id = @id";

            MySqlCommand executarcmdMySql_delete_funcionario = new MySqlCommand(sql_delete_funcionario, con);

            executarcmdMySql_delete_funcionario.Parameters.AddWithValue("@id", codigo);

            executarcmdMySql_delete_funcionario.ExecuteNonQuery();

            //notificação
            this.Alert("Deletado com sucesso", Form_Alert.enmType.Delete);

            ListarFuncionario();

            // Fechando conexão
            con.Close();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Dgv_funcionario.CurrentRow.Cells[0].Value.ToString();
            Txt_nome_funcionario.Text = Dgv_funcionario.CurrentRow.Cells[1].Value.ToString();
            Txt_email_funcionario.Text = Dgv_funcionario.CurrentRow.Cells[2].Value.ToString();
            Txt_senha_funcionario.Text = Dgv_funcionario.CurrentRow.Cells[3].Value.ToString();
            cmb_status_funcionario.Text = Dgv_funcionario.CurrentRow.Cells[4].Value.ToString();
            cmb_nivel_funcionario.Text = Dgv_funcionario.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
