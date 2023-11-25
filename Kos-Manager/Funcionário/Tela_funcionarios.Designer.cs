namespace Kos_Manager
{
    partial class Tela_funcionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_funcionarios));
            this.Dgv_funcionario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_deletar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_status_funcionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_nivel_funcionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_senha_funcionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_email_funcionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_nome_funcionario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_funcionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_funcionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_funcionario.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_funcionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_funcionario.ColumnHeadersHeight = 4;
            this.Dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_funcionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_funcionario.GridColor = System.Drawing.Color.Silver;
            this.Dgv_funcionario.Location = new System.Drawing.Point(16, 550);
            this.Dgv_funcionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_funcionario.Name = "Dgv_funcionario";
            this.Dgv_funcionario.RowHeadersVisible = false;
            this.Dgv_funcionario.RowHeadersWidth = 51;
            this.Dgv_funcionario.Size = new System.Drawing.Size(1439, 271);
            this.Dgv_funcionario.TabIndex = 92;
            this.Dgv_funcionario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_funcionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dgv_funcionario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dgv_funcionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dgv_funcionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dgv_funcionario.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.Dgv_funcionario.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.Dgv_funcionario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dgv_funcionario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_funcionario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_funcionario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dgv_funcionario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv_funcionario.ThemeStyle.HeaderStyle.Height = 4;
            this.Dgv_funcionario.ThemeStyle.ReadOnly = false;
            this.Dgv_funcionario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_funcionario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_funcionario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_funcionario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_funcionario.ThemeStyle.RowsStyle.Height = 22;
            this.Dgv_funcionario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_funcionario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionario_CellContentClick);
            // 
            // Btn_atualizar
            // 
            this.Btn_atualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_atualizar.Animated = true;
            this.Btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_atualizar.BorderRadius = 10;
            this.Btn_atualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_atualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_atualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_atualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_atualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.Btn_atualizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_atualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_atualizar.Image")));
            this.Btn_atualizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_atualizar.ImageSize = new System.Drawing.Size(17, 17);
            this.Btn_atualizar.Location = new System.Drawing.Point(1063, 490);
            this.Btn_atualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_atualizar.Name = "Btn_atualizar";
            this.Btn_atualizar.ShadowDecoration.Depth = 5;
            this.Btn_atualizar.ShadowDecoration.Enabled = true;
            this.Btn_atualizar.Size = new System.Drawing.Size(192, 48);
            this.Btn_atualizar.TabIndex = 91;
            this.Btn_atualizar.Text = "Atualizar";
            this.Btn_atualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click_2);
            // 
            // Btn_deletar
            // 
            this.Btn_deletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_deletar.Animated = true;
            this.Btn_deletar.BorderRadius = 10;
            this.Btn_deletar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_deletar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_deletar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_deletar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_deletar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Btn_deletar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_deletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_deletar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_deletar.Image")));
            this.Btn_deletar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_deletar.ImageSize = new System.Drawing.Size(17, 17);
            this.Btn_deletar.Location = new System.Drawing.Point(1263, 490);
            this.Btn_deletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_deletar.Name = "Btn_deletar";
            this.Btn_deletar.Size = new System.Drawing.Size(192, 48);
            this.Btn_deletar.TabIndex = 90;
            this.Btn_deletar.Text = "Deletar";
            this.Btn_deletar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_deletar.Click += new System.EventHandler(this.Btn_deletar_Click_1);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(16, 348);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(62, 32);
            this.guna2HtmlLabel7.TabIndex = 89;
            this.guna2HtmlLabel7.Text = "Status";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_status_funcionario
            // 
            this.cmb_status_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_status_funcionario.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status_funcionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_status_funcionario.BorderRadius = 10;
            this.cmb_status_funcionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status_funcionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_status_funcionario.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_status_funcionario.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_status_funcionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmb_status_funcionario.ItemHeight = 30;
            this.cmb_status_funcionario.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_status_funcionario.Location = new System.Drawing.Point(16, 388);
            this.cmb_status_funcionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_status_funcionario.Name = "cmb_status_funcionario";
            this.cmb_status_funcionario.Size = new System.Drawing.Size(601, 36);
            this.cmb_status_funcionario.TabIndex = 88;
            // 
            // cmb_nivel_funcionario
            // 
            this.cmb_nivel_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_nivel_funcionario.BackColor = System.Drawing.Color.Transparent;
            this.cmb_nivel_funcionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_nivel_funcionario.BorderRadius = 10;
            this.cmb_nivel_funcionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_nivel_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivel_funcionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_nivel_funcionario.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_nivel_funcionario.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_nivel_funcionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_nivel_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmb_nivel_funcionario.ItemHeight = 30;
            this.cmb_nivel_funcionario.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_nivel_funcionario.Location = new System.Drawing.Point(16, 281);
            this.cmb_nivel_funcionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_nivel_funcionario.Name = "cmb_nivel_funcionario";
            this.cmb_nivel_funcionario.Size = new System.Drawing.Size(601, 36);
            this.cmb_nivel_funcionario.TabIndex = 87;
            // 
            // Btn_adicionar
            // 
            this.Btn_adicionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_adicionar.Animated = true;
            this.Btn_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_adicionar.BorderRadius = 10;
            this.Btn_adicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_adicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_adicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_adicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_adicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.Btn_adicionar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_adicionar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_adicionar.Image")));
            this.Btn_adicionar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_adicionar.ImageSize = new System.Drawing.Size(19, 19);
            this.Btn_adicionar.Location = new System.Drawing.Point(863, 490);
            this.Btn_adicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(192, 48);
            this.Btn_adicionar.TabIndex = 85;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click_2);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 762);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1471, 74);
            this.guna2Panel2.TabIndex = 83;
            // 
            // Txt_senha_funcionario
            // 
            this.Txt_senha_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_senha_funcionario.BorderRadius = 6;
            this.Txt_senha_funcionario.BorderThickness = 0;
            this.Txt_senha_funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_senha_funcionario.DefaultText = "";
            this.Txt_senha_funcionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_senha_funcionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_senha_funcionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_senha_funcionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_senha_funcionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_senha_funcionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_senha_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_senha_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_senha_funcionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_senha_funcionario.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_senha_funcionario.IconRightOffset = new System.Drawing.Point(10, -5);
            this.Txt_senha_funcionario.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_senha_funcionario.Location = new System.Drawing.Point(852, 288);
            this.Txt_senha_funcionario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_senha_funcionario.Name = "Txt_senha_funcionario";
            this.Txt_senha_funcionario.PasswordChar = '\0';
            this.Txt_senha_funcionario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_senha_funcionario.PlaceholderText = "Digite aqui";
            this.Txt_senha_funcionario.SelectedText = "";
            this.Txt_senha_funcionario.Size = new System.Drawing.Size(603, 44);
            this.Txt_senha_funcionario.TabIndex = 82;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(852, 247);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(60, 32);
            this.guna2HtmlLabel6.TabIndex = 81;
            this.guna2HtmlLabel6.Text = "Senha";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_email_funcionario
            // 
            this.Txt_email_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_email_funcionario.BorderRadius = 6;
            this.Txt_email_funcionario.BorderThickness = 0;
            this.Txt_email_funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_email_funcionario.DefaultText = "";
            this.Txt_email_funcionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_email_funcionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_email_funcionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_email_funcionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_email_funcionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_email_funcionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_email_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_email_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_email_funcionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_email_funcionario.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_email_funcionario.IconRightOffset = new System.Drawing.Point(10, -5);
            this.Txt_email_funcionario.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_email_funcionario.Location = new System.Drawing.Point(852, 169);
            this.Txt_email_funcionario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_email_funcionario.Name = "Txt_email_funcionario";
            this.Txt_email_funcionario.PasswordChar = '\0';
            this.Txt_email_funcionario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_email_funcionario.PlaceholderText = "Digite aqui";
            this.Txt_email_funcionario.SelectedText = "";
            this.Txt_email_funcionario.Size = new System.Drawing.Size(603, 44);
            this.Txt_email_funcionario.TabIndex = 80;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(852, 130);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(62, 32);
            this.guna2HtmlLabel5.TabIndex = 79;
            this.guna2HtmlLabel5.Text = "E-mail";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(16, 240);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(153, 32);
            this.guna2HtmlLabel4.TabIndex = 78;
            this.guna2HtmlLabel4.Text = "Nível de Acesso";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_nome_funcionario
            // 
            this.Txt_nome_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_nome_funcionario.BorderRadius = 6;
            this.Txt_nome_funcionario.BorderThickness = 0;
            this.Txt_nome_funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_nome_funcionario.DefaultText = "";
            this.Txt_nome_funcionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_nome_funcionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_nome_funcionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nome_funcionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_nome_funcionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_nome_funcionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nome_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_nome_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_nome_funcionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_nome_funcionario.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_nome_funcionario.IconRightOffset = new System.Drawing.Point(10, -5);
            this.Txt_nome_funcionario.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_nome_funcionario.Location = new System.Drawing.Point(16, 169);
            this.Txt_nome_funcionario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_nome_funcionario.Name = "Txt_nome_funcionario";
            this.Txt_nome_funcionario.PasswordChar = '\0';
            this.Txt_nome_funcionario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_nome_funcionario.PlaceholderText = "Digite aqui";
            this.Txt_nome_funcionario.SelectedText = "";
            this.Txt_nome_funcionario.Size = new System.Drawing.Size(603, 44);
            this.Txt_nome_funcionario.TabIndex = 77;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(16, 128);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(208, 32);
            this.guna2HtmlLabel3.TabIndex = 76;
            this.guna2HtmlLabel3.Text = "Nome do funcionario\r\n";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(588, 38);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(206, 39);
            this.guna2HtmlLabel1.TabIndex = 75;
            this.guna2HtmlLabel1.Text = "FUNCIONÁRIOS";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tela_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1471, 836);
            this.Controls.Add(this.Dgv_funcionario);
            this.Controls.Add(this.Btn_atualizar);
            this.Controls.Add(this.Btn_deletar);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.cmb_status_funcionario);
            this.Controls.Add(this.cmb_nivel_funcionario);
            this.Controls.Add(this.Btn_adicionar);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.Txt_senha_funcionario);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.Txt_email_funcionario);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.Txt_nome_funcionario);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_funcionarios";
            this.Text = "Kos Manager";
            this.Load += new System.EventHandler(this.Tela_funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Dgv_funcionario;
        private Guna.UI2.WinForms.Guna2Button Btn_atualizar;
        private Guna.UI2.WinForms.Guna2Button Btn_deletar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status_funcionario;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_nivel_funcionario;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox Txt_senha_funcionario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox Txt_email_funcionario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox Txt_nome_funcionario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}