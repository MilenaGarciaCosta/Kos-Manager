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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_vendas));
            this.Child_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Txt_buscar_venda = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lbl_venda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_adicionar = new Guna.UI2.WinForms.Guna2Button();
            this.Child_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Child_panel
            // 
            this.Child_panel.BackColor = System.Drawing.Color.Transparent;
            this.Child_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Child_panel.Controls.Add(this.Btn_adicionar);
            this.Child_panel.Controls.Add(this.Txt_buscar_venda);
            this.Child_panel.Controls.Add(this.Lbl_venda);
            this.Child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Child_panel.Location = new System.Drawing.Point(0, 0);
            this.Child_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Child_panel.Name = "Child_panel";
            this.Child_panel.Size = new System.Drawing.Size(1471, 766);
            this.Child_panel.TabIndex = 18;
            this.Child_panel.UseTransparentBackground = true;
            this.Child_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Child_panel_Paint);
            // 
            // Txt_buscar_venda
            // 
            this.Txt_buscar_venda.BorderRadius = 10;
            this.Txt_buscar_venda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_buscar_venda.DefaultText = "";
            this.Txt_buscar_venda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_buscar_venda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_buscar_venda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_venda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_buscar_venda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_buscar_venda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_venda.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_buscar_venda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Txt_buscar_venda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_buscar_venda.Location = new System.Drawing.Point(851, 199);
            this.Txt_buscar_venda.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_buscar_venda.Name = "Txt_buscar_venda";
            this.Txt_buscar_venda.PasswordChar = '\0';
            this.Txt_buscar_venda.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Txt_buscar_venda.PlaceholderText = "Buscar por algo aqui";
            this.Txt_buscar_venda.SelectedText = "";
            this.Txt_buscar_venda.Size = new System.Drawing.Size(380, 48);
            this.Txt_buscar_venda.TabIndex = 17;
            // 
            // Lbl_venda
            // 
            this.Lbl_venda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_venda.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_venda.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_venda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_venda.Location = new System.Drawing.Point(696, 74);
            this.Lbl_venda.Margin = new System.Windows.Forms.Padding(4);
            this.Lbl_venda.Name = "Lbl_venda";
            this.Lbl_venda.Size = new System.Drawing.Size(110, 39);
            this.Lbl_venda.TabIndex = 16;
            this.Lbl_venda.Text = "VENDAS";
            this.Lbl_venda.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
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
            this.Btn_adicionar.Location = new System.Drawing.Point(231, 199);
            this.Btn_adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_adicionar.Name = "Btn_adicionar";
            this.Btn_adicionar.ShadowDecoration.Depth = 5;
            this.Btn_adicionar.ShadowDecoration.Enabled = true;
            this.Btn_adicionar.Size = new System.Drawing.Size(192, 48);
            this.Btn_adicionar.TabIndex = 18;
            this.Btn_adicionar.Text = "Adicionar";
            this.Btn_adicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Tela_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1471, 766);
            this.Controls.Add(this.Child_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_vendas";
            this.Text = "Tela_vendas";
            this.Child_panel.ResumeLayout(false);
            this.Child_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Child_panel;
        private Guna.UI2.WinForms.Guna2Button Btn_adicionar;
        private Guna.UI2.WinForms.Guna2TextBox Txt_buscar_venda;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_venda;
    }
}