namespace Kos_Manager
{
    partial class Tela_splash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_splash));
            this.Progress_splash = new Guna.UI2.WinForms.Guna2Panel();
            this.Progress_color_splash = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo_splash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Progress_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_splash)).BeginInit();
            this.SuspendLayout();
            // 
            // Progress_splash
            // 
            this.Progress_splash.Location = new System.Drawing.Point(12, 374);
            this.Progress_splash.Name = "Progress_splash";
            this.Progress_splash.Size = new System.Drawing.Size(616, 18);
            this.Progress_splash.TabIndex = 0;
            // 
            // Progress_color_splash
            // 
            this.Progress_color_splash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.Progress_color_splash.Location = new System.Drawing.Point(12, 374);
            this.Progress_color_splash.Name = "Progress_color_splash";
            this.Progress_color_splash.Size = new System.Drawing.Size(68, 18);
            this.Progress_color_splash.TabIndex = 1;
            // 
            // Logo_splash
            // 
            this.Logo_splash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo_splash.Image = global::Kos_Manager.Properties.Resources.logo_splash;
            this.Logo_splash.ImageRotate = 0F;
            this.Logo_splash.Location = new System.Drawing.Point(208, 93);
            this.Logo_splash.Name = "Logo_splash";
            this.Logo_splash.Size = new System.Drawing.Size(232, 184);
            this.Logo_splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_splash.TabIndex = 2;
            this.Logo_splash.TabStop = false;
            // 
            // Progress_timer
            // 
            this.Progress_timer.Enabled = true;
            this.Progress_timer.Interval = 15;
            this.Progress_timer.Tick += new System.EventHandler(this.Progress_timer_Tick);
            // 
            // Tela_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(640, 404);
            this.Controls.Add(this.Logo_splash);
            this.Controls.Add(this.Progress_color_splash);
            this.Controls.Add(this.Progress_splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 404);
            this.Name = "Tela_splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kos Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_splash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Progress_splash;
        private Guna.UI2.WinForms.Guna2Panel Progress_color_splash;
        private Guna.UI2.WinForms.Guna2PictureBox Logo_splash;
        private System.Windows.Forms.Timer Progress_timer;
    }
}

