namespace Kos_Manager
{
    partial class Tela_mat_prima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_mat_prima));
            this.Lbl_estoque = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txt_buscar_mat_prima = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_solicitar = new Guna.UI2.WinForms.Guna2Button();
            this.Child_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_mat_prima = new Guna.UI2.WinForms.Guna2Panel();
            this.Child_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_estoque
            // 
            this.Lbl_estoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_estoque.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_estoque.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_estoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_estoque.Location = new System.Drawing.Point(522, 56);
            this.Lbl_estoque.Name = "Lbl_estoque";
            this.Lbl_estoque.Size = new System.Drawing.Size(96, 32);
            this.Lbl_estoque.TabIndex = 16;
            this.Lbl_estoque.Text = "ESTOQUE";
            this.Lbl_estoque.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_estoque.Click += new System.EventHandler(this.Lbl_fornecedor_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(506, 94);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(126, 23);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "MATÉRIA PRIMA";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(251, 131);
            this.Lbl_titulo.MinimumSize = new System.Drawing.Size(229, 24);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(229, 24);
            this.Lbl_titulo.TabIndex = 22;
            this.Lbl_titulo.Text = "Nome do produto";
            // 
            // Txt_buscar_mat_prima
            // 
            this.Txt_buscar_mat_prima.BorderRadius = 10;
            this.Txt_buscar_mat_prima.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_buscar_mat_prima.DefaultText = "";
            this.Txt_buscar_mat_prima.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_buscar_mat_prima.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_buscar_mat_prima.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_mat_prima.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_mat_prima.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_buscar_mat_prima.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_mat_prima.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_buscar_mat_prima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_buscar_mat_prima.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_mat_prima.Location = new System.Drawing.Point(251, 162);
            this.Txt_buscar_mat_prima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_buscar_mat_prima.Name = "Txt_buscar_mat_prima";
            this.Txt_buscar_mat_prima.PasswordChar = '\0';
            this.Txt_buscar_mat_prima.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_buscar_mat_prima.PlaceholderText = "Buscar por algo aqui";
            this.Txt_buscar_mat_prima.SelectedText = "";
            this.Txt_buscar_mat_prima.Size = new System.Drawing.Size(285, 39);
            this.Txt_buscar_mat_prima.TabIndex = 17;
            this.Txt_buscar_mat_prima.TextChanged += new System.EventHandler(this.Txt_buscar_fornecedor_TextChanged);
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
            this.Btn_adicionar.Location = new System.Drawing.Point(588, 162);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(144, 39);
            this.Btn_adicionar.TabIndex = 18;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // Btn_solicitar
            // 
            this.Btn_solicitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_solicitar.Animated = true;
            this.Btn_solicitar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_solicitar.BorderRadius = 10;
            this.Btn_solicitar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_solicitar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_solicitar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_solicitar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_solicitar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(82)))), ((int)(((byte)(53)))));
            this.Btn_solicitar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Btn_solicitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Btn_solicitar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_solicitar.Image")));
            this.Btn_solicitar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Btn_solicitar.ImageSize = new System.Drawing.Size(19, 19);
            this.Btn_solicitar.Location = new System.Drawing.Point(757, 162);
            this.Btn_solicitar.Name = "Btn_solicitar";
            this.Btn_solicitar.ShadowDecoration.Depth = 5;
            this.Btn_solicitar.ShadowDecoration.Enabled = true;
            this.Btn_solicitar.Size = new System.Drawing.Size(144, 39);
            this.Btn_solicitar.TabIndex = 20;
            this.Btn_solicitar.Text = "Solicitar";
            this.Btn_solicitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_solicitar.Click += new System.EventHandler(this.Btn_solicitar_Click);
            // 
            // Child_panel
            // 
            this.Child_panel.BackColor = System.Drawing.Color.Transparent;
            this.Child_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Child_panel.Controls.Add(this.Pnl_mat_prima);
            this.Child_panel.Controls.Add(this.Lbl_titulo);
            this.Child_panel.Controls.Add(this.Btn_solicitar);
            this.Child_panel.Controls.Add(this.guna2HtmlLabel2);
            this.Child_panel.Controls.Add(this.Btn_adicionar);
            this.Child_panel.Controls.Add(this.Txt_buscar_mat_prima);
            this.Child_panel.Controls.Add(this.Lbl_estoque);
            this.Child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Child_panel.Location = new System.Drawing.Point(0, 0);
            this.Child_panel.Name = "Child_panel";
            this.Child_panel.Size = new System.Drawing.Size(1103, 622);
            this.Child_panel.TabIndex = 17;
            this.Child_panel.UseTransparentBackground = true;
            this.Child_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Child_panel_Paint);
            // 
            // Pnl_mat_prima
            // 
            this.Pnl_mat_prima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_mat_prima.AutoScroll = true;
            this.Pnl_mat_prima.Location = new System.Drawing.Point(34, 242);
            this.Pnl_mat_prima.Name = "Pnl_mat_prima";
            this.Pnl_mat_prima.Size = new System.Drawing.Size(1039, 353);
            this.Pnl_mat_prima.TabIndex = 23;
            this.Pnl_mat_prima.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_mat_prima_Paint);
            // 
            // Tela_mat_prima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1103, 622);
            this.Controls.Add(this.Child_panel);
            this.Name = "Tela_mat_prima";
            this.Text = "Kos Manager";
            this.Child_panel.ResumeLayout(false);
            this.Child_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_estoque;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_titulo;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar_mat_prima;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2Button Btn_solicitar;
        private Guna.UI2.WinForms.Guna2Panel Child_panel;
        private Guna.UI2.WinForms.Guna2Panel Pnl_mat_prima;
    }
}