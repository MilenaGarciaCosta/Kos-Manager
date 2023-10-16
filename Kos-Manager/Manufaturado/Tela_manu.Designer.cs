namespace Kos_Manager
{
    partial class Tela_manu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_manu));
            this.Child_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_estoque = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_requisitar = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl_produto_manu = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_buscar_produto_manu = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.Child_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Child_panel
            // 
            this.Child_panel.BackColor = System.Drawing.Color.Transparent;
            this.Child_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Child_panel.Controls.Add(this.guna2HtmlLabel2);
            this.Child_panel.Controls.Add(this.Lbl_estoque);
            this.Child_panel.Controls.Add(this.Btn_requisitar);
            this.Child_panel.Controls.Add(this.Pnl_produto_manu);
            this.Child_panel.Controls.Add(this.Lbl_titulo);
            this.Child_panel.Controls.Add(this.Txt_buscar_produto_manu);
            this.Child_panel.Controls.Add(this.Btn_adicionar);
            this.Child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Child_panel.Location = new System.Drawing.Point(0, 0);
            this.Child_panel.Name = "Child_panel";
            this.Child_panel.Size = new System.Drawing.Size(1103, 622);
            this.Child_panel.TabIndex = 17;
            this.Child_panel.UseTransparentBackground = true;
            this.Child_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Child_panel_Paint);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(447, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(213, 23);
            this.guna2HtmlLabel2.TabIndex = 39;
            this.guna2HtmlLabel2.Text = "PRODUTO MANUFATURADO\r\n";
            // 
            // Lbl_estoque
            // 
            this.Lbl_estoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_estoque.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_estoque.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_estoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_estoque.Location = new System.Drawing.Point(507, 37);
            this.Lbl_estoque.Name = "Lbl_estoque";
            this.Lbl_estoque.Size = new System.Drawing.Size(96, 32);
            this.Lbl_estoque.TabIndex = 38;
            this.Lbl_estoque.Text = "ESTOQUE";
            this.Lbl_estoque.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_requisitar
            // 
            this.Btn_requisitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_requisitar.Animated = true;
            this.Btn_requisitar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_requisitar.BorderRadius = 10;
            this.Btn_requisitar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_requisitar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_requisitar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_requisitar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_requisitar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(53)))));
            this.Btn_requisitar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_requisitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_requisitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_requisitar.Image")));
            this.Btn_requisitar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_requisitar.ImageSize = new System.Drawing.Size(19, 19);
            this.Btn_requisitar.Location = new System.Drawing.Point(769, 150);
            this.Btn_requisitar.Name = "Btn_requisitar";
            this.Btn_requisitar.ShadowDecoration.Depth = 5;
            this.Btn_requisitar.ShadowDecoration.Enabled = true;
            this.Btn_requisitar.Size = new System.Drawing.Size(144, 39);
            this.Btn_requisitar.TabIndex = 37;
            this.Btn_requisitar.Text = "Requisitar";
            this.Btn_requisitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_requisitar.Click += new System.EventHandler(this.Btn_requisitar_Click);
            // 
            // Pnl_produto_manu
            // 
            this.Pnl_produto_manu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_produto_manu.AutoScroll = true;
            this.Pnl_produto_manu.Location = new System.Drawing.Point(32, 233);
            this.Pnl_produto_manu.Name = "Pnl_produto_manu";
            this.Pnl_produto_manu.Size = new System.Drawing.Size(1039, 353);
            this.Pnl_produto_manu.TabIndex = 36;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(228, 119);
            this.Lbl_titulo.MinimumSize = new System.Drawing.Size(229, 24);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(229, 24);
            this.Lbl_titulo.TabIndex = 35;
            this.Lbl_titulo.Text = "Nome do produto";
            // 
            // Txt_buscar_produto_manu
            // 
            this.Txt_buscar_produto_manu.BorderRadius = 10;
            this.Txt_buscar_produto_manu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_buscar_produto_manu.DefaultText = "";
            this.Txt_buscar_produto_manu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_buscar_produto_manu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_buscar_produto_manu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_produto_manu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_produto_manu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_buscar_produto_manu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_produto_manu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_buscar_produto_manu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_buscar_produto_manu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_produto_manu.Location = new System.Drawing.Point(228, 150);
            this.Txt_buscar_produto_manu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_buscar_produto_manu.Name = "Txt_buscar_produto_manu";
            this.Txt_buscar_produto_manu.PasswordChar = '\0';
            this.Txt_buscar_produto_manu.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_buscar_produto_manu.PlaceholderText = "Buscar por produto";
            this.Txt_buscar_produto_manu.SelectedText = "";
            this.Txt_buscar_produto_manu.Size = new System.Drawing.Size(285, 39);
            this.Txt_buscar_produto_manu.TabIndex = 34;
            // 
            // Btn_adicionar
            // 
            this.Btn_adicionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.Btn_adicionar.Location = new System.Drawing.Point(581, 150);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(144, 39);
            this.Btn_adicionar.TabIndex = 33;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // Tela_manu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1103, 622);
            this.Controls.Add(this.Child_panel);
            this.Name = "Tela_manu";
            this.Text = "Kos Manager";
            this.Load += new System.EventHandler(this.Tela_manu_Load);
            this.Child_panel.ResumeLayout(false);
            this.Child_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Child_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_estoque;
        private Guna.UI2.WinForms.Guna2Button Btn_requisitar;
        private Guna.UI2.WinForms.Guna2Panel Pnl_produto_manu;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_titulo;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar_produto_manu;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
    }
}