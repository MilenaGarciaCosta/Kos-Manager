using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager
{
    public partial class Tela_inicial : Form
    {
        bool Expandir_menu;
        bool Estoque_fechado;
        bool Solicitacao_fechado;
        bool Funcionario_fechado;
        public Tela_inicial()
        {
            InitializeComponent();
        }

        private void Tela_inicial_Load(object sender, EventArgs e)
        {
            Lbl_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Lbl_hora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Menu_timer_Tick(object sender, EventArgs e)
        {
            // definir o maior e menor tamanho do menu lateral
            if(Expandir_menu)
            {
                //se o menu lateral estiver expandido, minimiza
                Lateral_menu.Width -= 10;
                if(Lateral_menu.Width == Lateral_menu.MinimumSize.Width)
                {
                    Expandir_menu = false;
                    Menu_timer.Stop();
                }
                Solicitacao_container.Height -= 10;
                if (Solicitacao_container.Height == Solicitacao_container.MinimumSize.Height)
                {
                    Solicitacao_fechado = true;
                    Solicitacao_timer.Stop();
                }
                Funcionario_container.Height -= 10;
                if (Funcionario_container.Height == Funcionario_container.MinimumSize.Height)
                {
                    Funcionario_fechado = true;
                    Funcionario_timer.Stop();
                }
                Estoque_container.Height -= 10;
                if (Estoque_container.Height == Estoque_container.MinimumSize.Height)
                {
                    Estoque_fechado = true;
                    Estoque_timer.Stop();
                }
            }
            else
            {
                Lateral_menu.Width += 10;
                if (Lateral_menu.Width == Lateral_menu.MaximumSize.Width)
                {
                    Expandir_menu = true;
                    Menu_timer.Stop();
                }
            }
        }

        private void Menu_burguer_Click(object sender, EventArgs e)
        {
            Menu_timer.Start();
        }

        private void Estoque_timer_Tick(object sender, EventArgs e)
        {
            if(Estoque_fechado)
            {
                Estoque_container.Height += 10;
                if(Estoque_container.Height == Estoque_container.MaximumSize.Height)
                {
                    Estoque_fechado = false;
                    Estoque_timer.Stop();
                }
                Solicitacao_container.Height -= 10;
                if (Solicitacao_container.Height == Solicitacao_container.MinimumSize.Height)
                {
                    Solicitacao_fechado = true;
                    Solicitacao_timer.Stop();
                }
                Funcionario_container.Height -= 10;
                if (Funcionario_container.Height == Funcionario_container.MinimumSize.Height)
                {
                    Funcionario_fechado = true;
                    Funcionario_timer.Stop();
                }
            }
            else
            {
                Estoque_container.Height -= 10;
                if(Estoque_container.Height == Estoque_container.MinimumSize.Height)
                {
                    Estoque_fechado = true;
                    Estoque_timer.Stop();
                }
            }
        }

        private void Btn_estoque_menu_Click(object sender, EventArgs e)
        {
            Estoque_timer.Start();
        }

        private void Solicitacao_timer_Tick(object sender, EventArgs e)
        {
            if (Solicitacao_fechado)
            {
                Solicitacao_container.Height += 10;
                if (Solicitacao_container.Height == Solicitacao_container.MaximumSize.Height)
                {
                    Solicitacao_fechado = false;
                    Solicitacao_timer.Stop();
                }
                Estoque_container.Height -= 10;
                if (Estoque_container.Height == Estoque_container.MinimumSize.Height)
                {
                    Estoque_fechado = true;
                    Estoque_timer.Stop();
                }
                Funcionario_container.Height -= 10;
                if (Funcionario_container.Height == Funcionario_container.MinimumSize.Height)
                {
                    Funcionario_fechado = true;
                    Funcionario_timer.Stop();
                }
            }
            else
            {
                Solicitacao_container.Height -= 10;
                if (Solicitacao_container.Height == Solicitacao_container.MinimumSize.Height)
                {
                    Solicitacao_fechado = true;
                    Solicitacao_timer.Stop();
                }
            }
        }

        private void Btn_solicitacao_menu_Click(object sender, EventArgs e)
        {
            Solicitacao_timer.Start();
        }

        private void Funcionario_timer_Tick(object sender, EventArgs e)
        {
            if (Funcionario_fechado)
            {
                Funcionario_container.Height += 10;
                if (Funcionario_container.Height == Funcionario_container.MaximumSize.Height)
                {
                    Funcionario_fechado = false;
                    Funcionario_timer.Stop();
                }
                Solicitacao_container.Height -= 10;
                if (Solicitacao_container.Height == Solicitacao_container.MinimumSize.Height)
                {
                    Solicitacao_fechado = true;
                    Solicitacao_timer.Stop();
                }
                Estoque_container.Height -= 10;
                if (Estoque_container.Height == Estoque_container.MinimumSize.Height)
                {
                    Estoque_fechado = true;
                    Estoque_timer.Stop();
                }
            }
            else
            {
                Funcionario_container.Height -= 10;
                if (Funcionario_container.Height == Funcionario_container.MinimumSize.Height)
                {
                    Funcionario_fechado = true;
                    Funcionario_timer.Stop();
                }
            }
        }

        private void Btn_funcionarios_Click(object sender, EventArgs e)
        {
            Funcionario_timer.Start();
        }

        private void Lbl_date_Click(object sender, EventArgs e)
        {
            
        }

        private void Lbl_hora_Click(object sender, EventArgs e)
        {
            
        }

        private Form FormAtivo = null;
        private void abrirChildForm(Form ChildForm)
        {
            if (FormAtivo != null)
                FormAtivo.Close();
            FormAtivo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Child_panel.Controls.Add(ChildForm);
            Child_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Btn_gerenciar_funcionarios_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_funcionarios());
        }

        private void Btn_fornecedores_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_fornecedor());
        }

        private void Btn_materia_prima_Click_1(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_mat_prima());
        }

        private void Btn_produto_manu_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_manu());
        }

        private void Btn_solicitacao_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_solicitacao());
        }

        private void Btn_requisicao_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_requisicao());
        }

        private void Btn_vendas_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_vendas());
        }

        private void Btn_nota_fiscal_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_nivel_acesso());
        }

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_dashboard());
        }

        private void Btn_reg_autoria_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_reg_autoria());
        }

        private void Btn_config_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Tela_configuracao());
        }

        private void Child_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
