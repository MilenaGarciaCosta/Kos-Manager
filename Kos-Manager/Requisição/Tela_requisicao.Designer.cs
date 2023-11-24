namespace Kos_Manager
{
    partial class Tela_requisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_requisicao));
            this.Dgv_requisita = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmb_nome_produto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_status_requisicao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_deletar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_quantidade = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_requisita)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_requisita
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_requisita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_requisita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_requisita.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_requisita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_requisita.ColumnHeadersHeight = 4;
            this.Dgv_requisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_requisita.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_requisita.GridColor = System.Drawing.Color.Silver;
            this.Dgv_requisita.Location = new System.Drawing.Point(26, 447);
            this.Dgv_requisita.Name = "Dgv_requisita";
            this.Dgv_requisita.RowHeadersVisible = false;
            this.Dgv_requisita.RowHeadersWidth = 51;
            this.Dgv_requisita.Size = new System.Drawing.Size(1051, 220);
            this.Dgv_requisita.TabIndex = 108;
            this.Dgv_requisita.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_requisita.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dgv_requisita.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dgv_requisita.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dgv_requisita.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dgv_requisita.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.Dgv_requisita.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.Dgv_requisita.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dgv_requisita.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_requisita.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_requisita.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dgv_requisita.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv_requisita.ThemeStyle.HeaderStyle.Height = 4;
            this.Dgv_requisita.ThemeStyle.ReadOnly = false;
            this.Dgv_requisita.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_requisita.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_requisita.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_requisita.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_requisita.ThemeStyle.RowsStyle.Height = 22;
            this.Dgv_requisita.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_requisita.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_requisita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_requisita_CellContentClick);
            // 
            // cmb_nome_produto
            // 
            this.cmb_nome_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_nome_produto.BackColor = System.Drawing.Color.Transparent;
            this.cmb_nome_produto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_nome_produto.BorderRadius = 10;
            this.cmb_nome_produto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_nome_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nome_produto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_nome_produto.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_nome_produto.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_nome_produto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_nome_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmb_nome_produto.ItemHeight = 30;
            this.cmb_nome_produto.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_nome_produto.Location = new System.Drawing.Point(26, 171);
            this.cmb_nome_produto.Name = "cmb_nome_produto";
            this.cmb_nome_produto.Size = new System.Drawing.Size(452, 36);
            this.cmb_nome_produto.TabIndex = 104;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(625, 140);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(50, 25);
            this.guna2HtmlLabel7.TabIndex = 103;
            this.guna2HtmlLabel7.Text = "Status";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.guna2HtmlLabel7.Click += new System.EventHandler(this.guna2HtmlLabel7_Click);
            // 
            // cmb_status_requisicao
            // 
            this.cmb_status_requisicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_status_requisicao.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status_requisicao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_status_requisicao.BorderRadius = 10;
            this.cmb_status_requisicao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status_requisicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status_requisicao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_status_requisicao.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_status_requisicao.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_status_requisicao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status_requisicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmb_status_requisicao.ItemHeight = 30;
            this.cmb_status_requisicao.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_status_requisicao.Location = new System.Drawing.Point(625, 171);
            this.cmb_status_requisicao.Name = "cmb_status_requisicao";
            this.cmb_status_requisicao.Size = new System.Drawing.Size(452, 36);
            this.cmb_status_requisicao.TabIndex = 102;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 232);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(93, 25);
            this.guna2HtmlLabel3.TabIndex = 97;
            this.guna2HtmlLabel3.Text = "Quantidade";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(26, 140);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(265, 25);
            this.guna2HtmlLabel6.TabIndex = 96;
            this.guna2HtmlLabel6.Text = "Nome do produto (nomenclatura)";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(475, 39);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 32);
            this.guna2HtmlLabel1.TabIndex = 92;
            this.guna2HtmlLabel1.Text = "REQUISIÇÃO\r\n";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_id
            // 
            this.Txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_id.BorderColor = System.Drawing.Color.Empty;
            this.Txt_id.BorderRadius = 6;
            this.Txt_id.BorderThickness = 0;
            this.Txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_id.DefaultText = "";
            this.Txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_id.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_id.IconRightOffset = new System.Drawing.Point(10, -5);
            this.Txt_id.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_id.Location = new System.Drawing.Point(42, 354);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.PasswordChar = '\0';
            this.Txt_id.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_id.PlaceholderText = "";
            this.Txt_id.SelectedText = "";
            this.Txt_id.Size = new System.Drawing.Size(89, 36);
            this.Txt_id.TabIndex = 122;
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
            this.Btn_deletar.Location = new System.Drawing.Point(933, 398);
            this.Btn_deletar.Name = "Btn_deletar";
            this.Btn_deletar.Size = new System.Drawing.Size(144, 39);
            this.Btn_deletar.TabIndex = 107;
            this.Btn_deletar.Text = "Deletar";
            this.Btn_deletar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_deletar.Click += new System.EventHandler(this.Btn_deletar_Click);
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
            this.Btn_atualizar.Location = new System.Drawing.Point(783, 398);
            this.Btn_atualizar.Name = "Btn_atualizar";
            this.Btn_atualizar.ShadowDecoration.Depth = 5;
            this.Btn_atualizar.ShadowDecoration.Enabled = true;
            this.Btn_atualizar.Size = new System.Drawing.Size(144, 39);
            this.Btn_atualizar.TabIndex = 106;
            this.Btn_atualizar.Text = "Atualizar";
            this.Btn_atualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
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
            this.Btn_adicionar.Location = new System.Drawing.Point(633, 398);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(144, 39);
            this.Btn_adicionar.TabIndex = 100;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // Txt_quantidade
            // 
            this.Txt_quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_quantidade.BorderRadius = 6;
            this.Txt_quantidade.BorderThickness = 0;
            this.Txt_quantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_quantidade.DefaultText = "";
            this.Txt_quantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_quantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_quantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_quantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_quantidade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_quantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_quantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_quantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_quantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_quantidade.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_quantidade.IconRightOffset = new System.Drawing.Point(10, -5);
            this.Txt_quantidade.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_quantidade.Location = new System.Drawing.Point(26, 264);
            this.Txt_quantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_quantidade.Name = "Txt_quantidade";
            this.Txt_quantidade.PasswordChar = '\0';
            this.Txt_quantidade.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_quantidade.PlaceholderText = "Digite aqui";
            this.Txt_quantidade.SelectedText = "";
            this.Txt_quantidade.Size = new System.Drawing.Size(452, 36);
            this.Txt_quantidade.TabIndex = 98;
            // 
            // Tela_requisicao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1103, 679);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.Dgv_requisita);
            this.Controls.Add(this.Btn_deletar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Btn_atualizar);
            this.Controls.Add(this.cmb_nome_produto);
            this.Controls.Add(this.Btn_adicionar);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.Txt_quantidade);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.cmb_status_requisicao);
            this.Name = "Tela_requisicao";
            this.Text = "Tela_requisicao";
            this.Load += new System.EventHandler(this.Tela_requisicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_requisita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Dgv_requisita;
        private Guna.UI2.WinForms.Guna2Button Btn_deletar;
        private Guna.UI2.WinForms.Guna2Button Btn_atualizar;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_nome_produto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status_requisicao;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_quantidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox Txt_id;
    }
}