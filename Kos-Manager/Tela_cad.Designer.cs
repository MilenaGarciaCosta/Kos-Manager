namespace Kos_Manager
{
    partial class Tela_cad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_cad));
            this.Lbl_caracteres_min = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_caracteres_especiais = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.Link_ja_tem_cad = new System.Windows.Forms.LinkLabel();
            this.Picture_box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Txt_senha_cad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_email_cad = new Guna.UI2.WinForms.Guna2TextBox();
            this.Check_ver_senha = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Txt_nome_cad = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_caracteres_min
            // 
            this.Lbl_caracteres_min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_caracteres_min.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_caracteres_min.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_caracteres_min.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_caracteres_min.Location = new System.Drawing.Point(265, 484);
            this.Lbl_caracteres_min.Name = "Lbl_caracteres_min";
            this.Lbl_caracteres_min.Size = new System.Drawing.Size(136, 17);
            this.Lbl_caracteres_min.TabIndex = 4;
            this.Lbl_caracteres_min.Text = "8 caracteres (obrigatório)\r\n";
            this.Lbl_caracteres_min.Click += new System.EventHandler(this.Lbl_caracteres_min_Click);
            // 
            // Lbl_caracteres_especiais
            // 
            this.Lbl_caracteres_especiais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_caracteres_especiais.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_caracteres_especiais.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_caracteres_especiais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_caracteres_especiais.Location = new System.Drawing.Point(265, 503);
            this.Lbl_caracteres_especiais.Name = "Lbl_caracteres_especiais";
            this.Lbl_caracteres_especiais.Size = new System.Drawing.Size(161, 17);
            this.Lbl_caracteres_especiais.TabIndex = 5;
            this.Lbl_caracteres_especiais.Text = "Ao menos 1 caractere especial";
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_cadastrar.BorderRadius = 6;
            this.Btn_cadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_cadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_cadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_cadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Btn_cadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_cadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Btn_cadastrar.Location = new System.Drawing.Point(428, 565);
            this.Btn_cadastrar.MinimumSize = new System.Drawing.Size(180, 45);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(180, 45);
            this.Btn_cadastrar.TabIndex = 6;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Link_ja_tem_cad
            // 
            this.Link_ja_tem_cad.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.Link_ja_tem_cad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Link_ja_tem_cad.AutoSize = true;
            this.Link_ja_tem_cad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_ja_tem_cad.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Link_ja_tem_cad.Location = new System.Drawing.Point(395, 618);
            this.Link_ja_tem_cad.Name = "Link_ja_tem_cad";
            this.Link_ja_tem_cad.Size = new System.Drawing.Size(246, 17);
            this.Link_ja_tem_cad.TabIndex = 7;
            this.Link_ja_tem_cad.TabStop = true;
            this.Link_ja_tem_cad.Text = "Já é cadastrado? Clique aqui para logar!";
            this.Link_ja_tem_cad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ja_tem_cad_LinkClicked);
            // 
            // Picture_box
            // 
            this.Picture_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Picture_box.Image = global::Kos_Manager.Properties.Resources.logo_branca;
            this.Picture_box.ImageRotate = 0F;
            this.Picture_box.Location = new System.Drawing.Point(0, 0);
            this.Picture_box.Name = "Picture_box";
            this.Picture_box.Size = new System.Drawing.Size(1028, 249);
            this.Picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Picture_box.TabIndex = 0;
            this.Picture_box.TabStop = false;
            this.Picture_box.Click += new System.EventHandler(this.Picture_box_Click);
            // 
            // Txt_senha_cad
            // 
            this.Txt_senha_cad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_senha_cad.BorderRadius = 6;
            this.Txt_senha_cad.BorderThickness = 0;
            this.Txt_senha_cad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_senha_cad.DefaultText = "";
            this.Txt_senha_cad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_senha_cad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_senha_cad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_senha_cad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_senha_cad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_senha_cad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_senha_cad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_senha_cad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_senha_cad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_senha_cad.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_senha_cad.IconRightOffset = new System.Drawing.Point(10, -10);
            this.Txt_senha_cad.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_senha_cad.Location = new System.Drawing.Point(265, 408);
            this.Txt_senha_cad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_senha_cad.Name = "Txt_senha_cad";
            this.Txt_senha_cad.PasswordChar = '*';
            this.Txt_senha_cad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_senha_cad.PlaceholderText = "Crie uma senha";
            this.Txt_senha_cad.SelectedText = "";
            this.Txt_senha_cad.Size = new System.Drawing.Size(503, 43);
            this.Txt_senha_cad.TabIndex = 2;
            this.Txt_senha_cad.TextChanged += new System.EventHandler(this.Txt_senha_cad_TextChanged);
            // 
            // Txt_email_cad
            // 
            this.Txt_email_cad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_email_cad.BorderRadius = 6;
            this.Txt_email_cad.BorderThickness = 0;
            this.Txt_email_cad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_email_cad.DefaultText = "";
            this.Txt_email_cad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_email_cad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_email_cad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_email_cad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_email_cad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_email_cad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_email_cad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_email_cad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_email_cad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_email_cad.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_email_cad.IconRightOffset = new System.Drawing.Point(10, -10);
            this.Txt_email_cad.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_email_cad.Location = new System.Drawing.Point(265, 340);
            this.Txt_email_cad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_email_cad.Name = "Txt_email_cad";
            this.Txt_email_cad.PasswordChar = '\0';
            this.Txt_email_cad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_email_cad.PlaceholderText = "Digite seu e-mail";
            this.Txt_email_cad.SelectedText = "";
            this.Txt_email_cad.Size = new System.Drawing.Size(503, 43);
            this.Txt_email_cad.TabIndex = 1;
            this.Txt_email_cad.TextChanged += new System.EventHandler(this.Txt_nome_cad_TextChanged);
            // 
            // Check_ver_senha
            // 
            this.Check_ver_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Check_ver_senha.AutoSize = true;
            this.Check_ver_senha.BackColor = System.Drawing.Color.Transparent;
            this.Check_ver_senha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Check_ver_senha.CheckedState.BorderRadius = 0;
            this.Check_ver_senha.CheckedState.BorderThickness = 0;
            this.Check_ver_senha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Check_ver_senha.CheckMarkColor = System.Drawing.SystemColors.ButtonFace;
            this.Check_ver_senha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_ver_senha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Check_ver_senha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Check_ver_senha.Location = new System.Drawing.Point(265, 458);
            this.Check_ver_senha.Margin = new System.Windows.Forms.Padding(2);
            this.Check_ver_senha.Name = "Check_ver_senha";
            this.Check_ver_senha.Size = new System.Drawing.Size(118, 21);
            this.Check_ver_senha.TabIndex = 8;
            this.Check_ver_senha.Text = "SENHA VISÍVEL";
            this.Check_ver_senha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Check_ver_senha.UncheckedState.BorderRadius = 0;
            this.Check_ver_senha.UncheckedState.BorderThickness = 0;
            this.Check_ver_senha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Check_ver_senha.UseVisualStyleBackColor = false;
            this.Check_ver_senha.CheckedChanged += new System.EventHandler(this.Check_ver_senha_CheckedChanged);
            // 
            // Txt_nome_cad
            // 
            this.Txt_nome_cad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_nome_cad.BorderRadius = 6;
            this.Txt_nome_cad.BorderThickness = 0;
            this.Txt_nome_cad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_nome_cad.DefaultText = "";
            this.Txt_nome_cad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_nome_cad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_nome_cad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nome_cad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nome_cad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_nome_cad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nome_cad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_nome_cad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_nome_cad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nome_cad.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_nome_cad.IconRightOffset = new System.Drawing.Point(10, -10);
            this.Txt_nome_cad.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_nome_cad.Location = new System.Drawing.Point(265, 276);
            this.Txt_nome_cad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nome_cad.Name = "Txt_nome_cad";
            this.Txt_nome_cad.PasswordChar = '\0';
            this.Txt_nome_cad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_nome_cad.PlaceholderText = "Digite seu nome";
            this.Txt_nome_cad.SelectedText = "";
            this.Txt_nome_cad.Size = new System.Drawing.Size(503, 43);
            this.Txt_nome_cad.TabIndex = 9;
            // 
            // Tela_cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 736);
            this.Controls.Add(this.Txt_nome_cad);
            this.Controls.Add(this.Check_ver_senha);
            this.Controls.Add(this.Link_ja_tem_cad);
            this.Controls.Add(this.Btn_cadastrar);
            this.Controls.Add(this.Lbl_caracteres_especiais);
            this.Controls.Add(this.Lbl_caracteres_min);
            this.Controls.Add(this.Txt_senha_cad);
            this.Controls.Add(this.Txt_email_cad);
            this.Controls.Add(this.Picture_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_cad";
            this.Text = "Kos Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_cad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Picture_box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_caracteres_min;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_caracteres_especiais;
        private Guna.UI2.WinForms.Guna2Button Btn_cadastrar;
        private System.Windows.Forms.LinkLabel Link_ja_tem_cad;
        private Guna.UI2.WinForms.Guna2TextBox Txt_senha_cad;
        private Guna.UI2.WinForms.Guna2TextBox Txt_email_cad;
        private Guna.UI2.WinForms.Guna2CheckBox Check_ver_senha;
        private Guna.UI2.WinForms.Guna2TextBox Txt_nome_cad;
    }
}