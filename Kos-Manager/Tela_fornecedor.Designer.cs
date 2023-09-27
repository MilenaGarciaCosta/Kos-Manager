namespace Kos_Manager
{
    partial class Tela_fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_fornecedor));
            this.Child_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_buscar_fornecedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_fornecedor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Child_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Child_panel
            // 
            this.Child_panel.BackColor = System.Drawing.Color.Transparent;
            this.Child_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Child_panel.Controls.Add(this.guna2HtmlLabel2);
            this.Child_panel.Controls.Add(this.Btn_adicionar);
            this.Child_panel.Controls.Add(this.Txt_buscar_fornecedor);
            this.Child_panel.Controls.Add(this.Lbl_fornecedor);
            this.Child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Child_panel.Location = new System.Drawing.Point(0, 0);
            this.Child_panel.Name = "Child_panel";
            this.Child_panel.Size = new System.Drawing.Size(1103, 622);
            this.Child_panel.TabIndex = 16;
            this.Child_panel.UseTransparentBackground = true;
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
            this.Btn_adicionar.Location = new System.Drawing.Point(657, 162);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(144, 39);
            this.Btn_adicionar.TabIndex = 18;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click_1);
            // 
            // Txt_buscar_fornecedor
            // 
            this.Txt_buscar_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_buscar_fornecedor.BorderRadius = 10;
            this.Txt_buscar_fornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_buscar_fornecedor.DefaultText = "";
            this.Txt_buscar_fornecedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_buscar_fornecedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_buscar_fornecedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_fornecedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_fornecedor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_buscar_fornecedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_fornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_buscar_fornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_buscar_fornecedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_fornecedor.Location = new System.Drawing.Point(321, 162);
            this.Txt_buscar_fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_buscar_fornecedor.Name = "Txt_buscar_fornecedor";
            this.Txt_buscar_fornecedor.PasswordChar = '\0';
            this.Txt_buscar_fornecedor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_buscar_fornecedor.PlaceholderText = "Buscar por nome ou produto";
            this.Txt_buscar_fornecedor.SelectedText = "";
            this.Txt_buscar_fornecedor.Size = new System.Drawing.Size(285, 39);
            this.Txt_buscar_fornecedor.TabIndex = 17;
            // 
            // Lbl_fornecedor
            // 
            this.Lbl_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_fornecedor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_fornecedor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_fornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_fornecedor.Location = new System.Drawing.Point(463, 59);
            this.Lbl_fornecedor.Name = "Lbl_fornecedor";
            this.Lbl_fornecedor.Size = new System.Drawing.Size(164, 32);
            this.Lbl_fornecedor.TabIndex = 16;
            this.Lbl_fornecedor.Text = "FORNECEDORES\r\n";
            this.Lbl_fornecedor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(321, 132);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(247, 23);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Nome do fornecedor ou produto\r\n";
            // 
            // Tela_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1103, 622);
            this.Controls.Add(this.Child_panel);
            this.Name = "Tela_fornecedor";
            this.Text = "Kos Manager";
            this.Load += new System.EventHandler(this.Tela_fornecedor_Load);
            this.Child_panel.ResumeLayout(false);
            this.Child_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Child_panel;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar_fornecedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_fornecedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}