namespace Kos_Manager
{
    partial class Tela_solicitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_solicitacao));
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dgv_solicita = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_deletar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_fornecedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_nome_produto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_status_solicitacao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_quantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_adicionar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Child_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_solicitacao_marca = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_solicita)).BeginInit();
            this.Child_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(43, 233);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(50, 25);
            this.guna2HtmlLabel7.TabIndex = 119;
            this.guna2HtmlLabel7.Text = "Status";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dgv_solicita
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_solicita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_solicita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_solicita.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_solicita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_solicita.ColumnHeadersHeight = 4;
            this.Dgv_solicita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_solicita.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_solicita.GridColor = System.Drawing.Color.Silver;
            this.Dgv_solicita.Location = new System.Drawing.Point(24, 390);
            this.Dgv_solicita.Name = "Dgv_solicita";
            this.Dgv_solicita.RowHeadersVisible = false;
            this.Dgv_solicita.RowHeadersWidth = 51;
            this.Dgv_solicita.Size = new System.Drawing.Size(1053, 220);
            this.Dgv_solicita.TabIndex = 118;
            this.Dgv_solicita.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_solicita.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dgv_solicita.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dgv_solicita.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dgv_solicita.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dgv_solicita.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.Dgv_solicita.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.Dgv_solicita.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dgv_solicita.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_solicita.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_solicita.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dgv_solicita.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv_solicita.ThemeStyle.HeaderStyle.Height = 4;
            this.Dgv_solicita.ThemeStyle.ReadOnly = false;
            this.Dgv_solicita.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_solicita.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_solicita.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_solicita.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_solicita.ThemeStyle.RowsStyle.Height = 22;
            this.Dgv_solicita.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_solicita.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.Btn_deletar.Location = new System.Drawing.Point(933, 341);
            this.Btn_deletar.Name = "Btn_deletar";
            this.Btn_deletar.Size = new System.Drawing.Size(144, 39);
            this.Btn_deletar.TabIndex = 117;
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
            this.Btn_atualizar.Location = new System.Drawing.Point(783, 341);
            this.Btn_atualizar.Name = "Btn_atualizar";
            this.Btn_atualizar.ShadowDecoration.Depth = 5;
            this.Btn_atualizar.ShadowDecoration.Enabled = true;
            this.Btn_atualizar.Size = new System.Drawing.Size(144, 39);
            this.Btn_atualizar.TabIndex = 116;
            this.Btn_atualizar.Text = "Atualizar";
            this.Btn_atualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            // 
            // cmb_fornecedor
            // 
            this.cmb_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_fornecedor.BackColor = System.Drawing.Color.Transparent;
            this.cmb_fornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_fornecedor.BorderRadius = 10;
            this.cmb_fornecedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fornecedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_fornecedor.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_fornecedor.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_fornecedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_fornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.cmb_fornecedor.ItemHeight = 30;
            this.cmb_fornecedor.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_fornecedor.Location = new System.Drawing.Point(625, 178);
            this.cmb_fornecedor.Name = "cmb_fornecedor";
            this.cmb_fornecedor.Size = new System.Drawing.Size(452, 36);
            this.cmb_fornecedor.TabIndex = 115;
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
            this.cmb_nome_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.cmb_nome_produto.ItemHeight = 30;
            this.cmb_nome_produto.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_nome_produto.Location = new System.Drawing.Point(39, 94);
            this.cmb_nome_produto.Name = "cmb_nome_produto";
            this.cmb_nome_produto.Size = new System.Drawing.Size(452, 36);
            this.cmb_nome_produto.TabIndex = 113;
            // 
            // cmb_status_solicitacao
            // 
            this.cmb_status_solicitacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_status_solicitacao.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status_solicitacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_status_solicitacao.BorderRadius = 10;
            this.cmb_status_solicitacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status_solicitacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status_solicitacao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_status_solicitacao.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_status_solicitacao.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_status_solicitacao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status_solicitacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.cmb_status_solicitacao.ItemHeight = 30;
            this.cmb_status_solicitacao.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_status_solicitacao.Location = new System.Drawing.Point(39, 264);
            this.cmb_status_solicitacao.Name = "cmb_status_solicitacao";
            this.cmb_status_solicitacao.Size = new System.Drawing.Size(452, 36);
            this.cmb_status_solicitacao.TabIndex = 112;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(625, 147);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(90, 25);
            this.guna2HtmlLabel4.TabIndex = 111;
            this.guna2HtmlLabel4.Text = "Fornecedor";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(625, 63);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(143, 25);
            this.guna2HtmlLabel1.TabIndex = 110;
            this.guna2HtmlLabel1.Text = "Marca do Produto";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
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
            this.Btn_adicionar.Location = new System.Drawing.Point(633, 341);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(144, 39);
            this.Btn_adicionar.TabIndex = 109;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(43, 152);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(93, 25);
            this.guna2HtmlLabel5.TabIndex = 108;
            this.guna2HtmlLabel5.Text = "Quantidade";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
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
            this.Txt_quantidade.Location = new System.Drawing.Point(39, 178);
            this.Txt_quantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_quantidade.Name = "Txt_quantidade";
            this.Txt_quantidade.PasswordChar = '\0';
            this.Txt_quantidade.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_quantidade.PlaceholderText = "Digite aqui";
            this.Txt_quantidade.SelectedText = "";
            this.Txt_quantidade.Size = new System.Drawing.Size(452, 36);
            this.Txt_quantidade.TabIndex = 107;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(39, 63);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(265, 25);
            this.guna2HtmlLabel3.TabIndex = 106;
            this.guna2HtmlLabel3.Text = "Nome do produto (nomenclatura)";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_adicionar
            // 
            this.Lbl_adicionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_adicionar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_adicionar.Location = new System.Drawing.Point(481, 19);
            this.Lbl_adicionar.Name = "Lbl_adicionar";
            this.Lbl_adicionar.Size = new System.Drawing.Size(140, 32);
            this.Lbl_adicionar.TabIndex = 104;
            this.Lbl_adicionar.Text = "SOLICITAÇÃO";
            this.Lbl_adicionar.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Child_panel
            // 
            this.Child_panel.BackColor = System.Drawing.Color.Transparent;
            this.Child_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Child_panel.Controls.Add(this.Txt_solicitacao_marca);
            this.Child_panel.Controls.Add(this.guna2HtmlLabel7);
            this.Child_panel.Controls.Add(this.Dgv_solicita);
            this.Child_panel.Controls.Add(this.Btn_deletar);
            this.Child_panel.Controls.Add(this.Btn_atualizar);
            this.Child_panel.Controls.Add(this.cmb_fornecedor);
            this.Child_panel.Controls.Add(this.cmb_nome_produto);
            this.Child_panel.Controls.Add(this.cmb_status_solicitacao);
            this.Child_panel.Controls.Add(this.guna2HtmlLabel4);
            this.Child_panel.Controls.Add(this.guna2HtmlLabel1);
            this.Child_panel.Controls.Add(this.Btn_adicionar);
            this.Child_panel.Controls.Add(this.guna2HtmlLabel5);
            this.Child_panel.Controls.Add(this.Txt_quantidade);
            this.Child_panel.Controls.Add(this.guna2HtmlLabel3);
            this.Child_panel.Controls.Add(this.Lbl_adicionar);
            this.Child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Child_panel.Location = new System.Drawing.Point(0, 0);
            this.Child_panel.Name = "Child_panel";
            this.Child_panel.Size = new System.Drawing.Size(1103, 622);
            this.Child_panel.TabIndex = 19;
            this.Child_panel.UseTransparentBackground = true;
            this.Child_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Child_panel_Paint_1);
            // 
            // Txt_solicitacao_marca
            // 
            this.Txt_solicitacao_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_solicitacao_marca.BorderRadius = 6;
            this.Txt_solicitacao_marca.BorderThickness = 0;
            this.Txt_solicitacao_marca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_solicitacao_marca.DefaultText = "";
            this.Txt_solicitacao_marca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_solicitacao_marca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_solicitacao_marca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_solicitacao_marca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_solicitacao_marca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_solicitacao_marca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_solicitacao_marca.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_solicitacao_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_solicitacao_marca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_solicitacao_marca.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_solicitacao_marca.IconRightOffset = new System.Drawing.Point(10, -5);
            this.Txt_solicitacao_marca.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_solicitacao_marca.Location = new System.Drawing.Point(625, 104);
            this.Txt_solicitacao_marca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_solicitacao_marca.Name = "Txt_solicitacao_marca";
            this.Txt_solicitacao_marca.PasswordChar = '\0';
            this.Txt_solicitacao_marca.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_solicitacao_marca.PlaceholderText = "Digite aqui";
            this.Txt_solicitacao_marca.SelectedText = "";
            this.Txt_solicitacao_marca.Size = new System.Drawing.Size(452, 36);
            this.Txt_solicitacao_marca.TabIndex = 120;
            // 
            // Tela_solicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1103, 622);
            this.Controls.Add(this.Child_panel);
            this.Name = "Tela_solicitacao";
            this.Text = "Tela_solicitacao";
            this.Load += new System.EventHandler(this.Tela_solicitacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_solicita)).EndInit();
            this.Child_panel.ResumeLayout(false);
            this.Child_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2DataGridView Dgv_solicita;
        private Guna.UI2.WinForms.Guna2Button Btn_deletar;
        private Guna.UI2.WinForms.Guna2Button Btn_atualizar;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_fornecedor;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_nome_produto;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status_solicitacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox Txt_quantidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_adicionar;
        private Guna.UI2.WinForms.Guna2Panel Child_panel;
        private Guna.UI2.WinForms.Guna2TextBox Txt_solicitacao_marca;
    }
}