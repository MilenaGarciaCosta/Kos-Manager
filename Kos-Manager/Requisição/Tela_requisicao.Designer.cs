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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_requisicao));
            this.Child_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Pnl_mat_prima = new Guna.UI2.WinForms.Guna2Panel();
            this.Lbl_estoque = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_requisitar = new Guna.UI2.WinForms.Guna2Button();
            this.Child_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Child_panel
            // 
            this.Child_panel.BackColor = System.Drawing.Color.Transparent;
            this.Child_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Child_panel.Controls.Add(this.Pnl_mat_prima);
            this.Child_panel.Controls.Add(this.Lbl_estoque);
            this.Child_panel.Controls.Add(this.Btn_requisitar);
            this.Child_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Child_panel.Location = new System.Drawing.Point(0, 0);
            this.Child_panel.Name = "Child_panel";
            this.Child_panel.Size = new System.Drawing.Size(1023, 609);
            this.Child_panel.TabIndex = 18;
            this.Child_panel.UseTransparentBackground = true;
            this.Child_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Child_panel_Paint);
            // 
            // Pnl_mat_prima
            // 
            this.Pnl_mat_prima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_mat_prima.AutoScroll = true;
            this.Pnl_mat_prima.Location = new System.Drawing.Point(41, 257);
            this.Pnl_mat_prima.Name = "Pnl_mat_prima";
            this.Pnl_mat_prima.Size = new System.Drawing.Size(959, 340);
            this.Pnl_mat_prima.TabIndex = 54;
            // 
            // Lbl_estoque
            // 
            this.Lbl_estoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_estoque.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_estoque.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_estoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(210)))), ((int)(((byte)(197)))));
            this.Lbl_estoque.Location = new System.Drawing.Point(439, 56);
            this.Lbl_estoque.Name = "Lbl_estoque";
            this.Lbl_estoque.Size = new System.Drawing.Size(137, 32);
            this.Lbl_estoque.TabIndex = 38;
            this.Lbl_estoque.Text = "REQUISIÇÕES";
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
            this.Btn_requisitar.Location = new System.Drawing.Point(437, 126);
            this.Btn_requisitar.Name = "Btn_requisitar";
            this.Btn_requisitar.ShadowDecoration.Depth = 5;
            this.Btn_requisitar.ShadowDecoration.Enabled = true;
            this.Btn_requisitar.Size = new System.Drawing.Size(144, 39);
            this.Btn_requisitar.TabIndex = 37;
            this.Btn_requisitar.Text = "Requisitar";
            this.Btn_requisitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_requisitar.Click += new System.EventHandler(this.Btn_requisitar_Click);
            // 
            // Tela_requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1023, 609);
            this.Controls.Add(this.Child_panel);
            this.Name = "Tela_requisicao";
            this.Text = "Tela_requisicao";
            this.Child_panel.ResumeLayout(false);
            this.Child_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Child_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lbl_estoque;
        private Guna.UI2.WinForms.Guna2Button Btn_requisitar;
        private Guna.UI2.WinForms.Guna2Panel Pnl_mat_prima;
    }
}