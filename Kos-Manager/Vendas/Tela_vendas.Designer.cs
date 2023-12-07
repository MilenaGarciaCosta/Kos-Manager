namespace Kos_Manager
{
    partial class Tela_vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_vendas));
            this.Dgv_venda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_deletar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_atualizar = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_funcionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_nome_produto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txt_quantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_valor_produto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_adicionar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_venda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_venda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_venda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_venda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_venda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_venda.ColumnHeadersHeight = 4;
            this.Dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_venda.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_venda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Dgv_venda.Location = new System.Drawing.Point(22, 450);
            this.Dgv_venda.Name = "Dgv_venda";
            this.Dgv_venda.ReadOnly = true;
            this.Dgv_venda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dgv_venda.RowHeadersVisible = false;
            this.Dgv_venda.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Dgv_venda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_venda.Size = new System.Drawing.Size(1015, 220);
            this.Dgv_venda.TabIndex = 141;
            this.Dgv_venda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_venda.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dgv_venda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dgv_venda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dgv_venda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dgv_venda.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Dgv_venda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Dgv_venda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Dgv_venda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_venda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Dgv_venda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dgv_venda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv_venda.ThemeStyle.HeaderStyle.Height = 4;
            this.Dgv_venda.ThemeStyle.ReadOnly = true;
            this.Dgv_venda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv_venda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv_venda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_venda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_venda.ThemeStyle.RowsStyle.Height = 22;
            this.Dgv_venda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv_venda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv_venda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_venda_CellContentClick);
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
            this.Btn_deletar.Location = new System.Drawing.Point(893, 398);
            this.Btn_deletar.Name = "Btn_deletar";
            this.Btn_deletar.Size = new System.Drawing.Size(144, 39);
            this.Btn_deletar.TabIndex = 140;
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
            this.Btn_atualizar.Location = new System.Drawing.Point(743, 398);
            this.Btn_atualizar.Name = "Btn_atualizar";
            this.Btn_atualizar.ShadowDecoration.Depth = 5;
            this.Btn_atualizar.ShadowDecoration.Enabled = true;
            this.Btn_atualizar.Size = new System.Drawing.Size(144, 39);
            this.Btn_atualizar.TabIndex = 139;
            this.Btn_atualizar.Text = "Atualizar";
            this.Btn_atualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
            // 
            // cmb_funcionario
            // 
            this.cmb_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_funcionario.BackColor = System.Drawing.Color.Transparent;
            this.cmb_funcionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_funcionario.BorderRadius = 10;
            this.cmb_funcionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_funcionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_funcionario.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_funcionario.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_funcionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmb_funcionario.ItemHeight = 30;
            this.cmb_funcionario.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_funcionario.Location = new System.Drawing.Point(22, 244);
            this.cmb_funcionario.Name = "cmb_funcionario";
            this.cmb_funcionario.Size = new System.Drawing.Size(452, 36);
            this.cmb_funcionario.TabIndex = 138;
            // 
            // cmb_status
            // 
            this.cmb_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_status.BorderRadius = 10;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmb_status.FocusedColor = System.Drawing.Color.Transparent;
            this.cmb_status.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmb_status.ItemHeight = 30;
            this.cmb_status.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb_status.Location = new System.Drawing.Point(585, 244);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(452, 36);
            this.cmb_status.TabIndex = 137;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(585, 213);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(126, 25);
            this.guna2HtmlLabel2.TabIndex = 136;
            this.guna2HtmlLabel2.Text = "Status da venda";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(585, 122);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(135, 25);
            this.guna2HtmlLabel5.TabIndex = 135;
            this.guna2HtmlLabel5.Text = "Valor do produto";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(22, 298);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(205, 25);
            this.guna2HtmlLabel4.TabIndex = 134;
            this.guna2HtmlLabel4.Text = "Quantidade (no mínimo 1)";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 212);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(187, 25);
            this.guna2HtmlLabel1.TabIndex = 133;
            this.guna2HtmlLabel1.Text = "Responsável pela venda";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
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
            this.cmb_nome_produto.Location = new System.Drawing.Point(22, 157);
            this.cmb_nome_produto.Name = "cmb_nome_produto";
            this.cmb_nome_produto.Size = new System.Drawing.Size(452, 36);
            this.cmb_nome_produto.TabIndex = 131;
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
            this.Txt_quantidade.Location = new System.Drawing.Point(24, 330);
            this.Txt_quantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_quantidade.Name = "Txt_quantidade";
            this.Txt_quantidade.PasswordChar = '\0';
            this.Txt_quantidade.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_quantidade.PlaceholderText = "Digite aqui";
            this.Txt_quantidade.SelectedText = "";
            this.Txt_quantidade.Size = new System.Drawing.Size(452, 36);
            this.Txt_quantidade.TabIndex = 130;
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
            this.Btn_adicionar.Location = new System.Drawing.Point(593, 398);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(144, 39);
            this.Btn_adicionar.TabIndex = 128;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click_1);
            // 
            // Txt_valor_produto
            // 
            this.Txt_valor_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_valor_produto.BorderRadius = 6;
            this.Txt_valor_produto.BorderThickness = 0;
            this.Txt_valor_produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_valor_produto.DefaultText = "";
            this.Txt_valor_produto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_valor_produto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_valor_produto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_valor_produto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_valor_produto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_valor_produto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_valor_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_valor_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_valor_produto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_valor_produto.IconRight = global::Kos_Manager.Properties.Resources.asterisco;
            this.Txt_valor_produto.IconRightOffset = new System.Drawing.Point(10, -10);
            this.Txt_valor_produto.IconRightSize = new System.Drawing.Size(10, 10);
            this.Txt_valor_produto.Location = new System.Drawing.Point(585, 157);
            this.Txt_valor_produto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_valor_produto.Name = "Txt_valor_produto";
            this.Txt_valor_produto.PasswordChar = '\0';
            this.Txt_valor_produto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_valor_produto.PlaceholderText = "Digite aqui";
            this.Txt_valor_produto.SelectedText = "";
            this.Txt_valor_produto.Size = new System.Drawing.Size(452, 36);
            this.Txt_valor_produto.TabIndex = 127;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(22, 126);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(265, 25);
            this.guna2HtmlLabel3.TabIndex = 126;
            this.guna2HtmlLabel3.Text = "Nome do produto (nomenclatura)";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_adicionar
            // 
            this.Lbl_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_adicionar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_adicionar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_adicionar.Location = new System.Drawing.Point(469, 58);
            this.Lbl_adicionar.Name = "Lbl_adicionar";
            this.Lbl_adicionar.Size = new System.Drawing.Size(87, 32);
            this.Lbl_adicionar.TabIndex = 125;
            this.Lbl_adicionar.Text = "VENDAS";
            this.Lbl_adicionar.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tela_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1058, 679);
            this.Controls.Add(this.Dgv_venda);
            this.Controls.Add(this.Btn_deletar);
            this.Controls.Add(this.Btn_atualizar);
            this.Controls.Add(this.cmb_funcionario);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmb_nome_produto);
            this.Controls.Add(this.Txt_quantidade);
            this.Controls.Add(this.Btn_adicionar);
            this.Controls.Add(this.Txt_valor_produto);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Lbl_adicionar);
            this.Name = "Tela_vendas";
            this.Text = "Tela_vendas";
            this.Load += new System.EventHandler(this.Tela_vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Dgv_venda;
        private Guna.UI2.WinForms.Guna2Button Btn_deletar;
        private Guna.UI2.WinForms.Guna2Button Btn_atualizar;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_funcionario;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_nome_produto;
        private Guna.UI2.WinForms.Guna2TextBox Txt_quantidade;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_valor_produto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_adicionar;
    }
}