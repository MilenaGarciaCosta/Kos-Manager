namespace Kos_Manager
{
    partial class Tela_inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_inicial));
            this.Img_header_menu = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Img_header_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_header_menu
            // 
            this.Img_header_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Img_header_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Img_header_menu.Image = ((System.Drawing.Image)(resources.GetObject("Img_header_menu.Image")));
            this.Img_header_menu.ImageRotate = 0F;
            this.Img_header_menu.Location = new System.Drawing.Point(0, 0);
            this.Img_header_menu.Name = "Img_header_menu";
            this.Img_header_menu.Size = new System.Drawing.Size(1430, 88);
            this.Img_header_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_header_menu.TabIndex = 0;
            this.Img_header_menu.TabStop = false;
            // 
            // Tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1430, 792);
            this.Controls.Add(this.Img_header_menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_inicial";
            this.Text = "Kos Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Img_header_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Img_header_menu;
    }
}