namespace Kos_Manager
{
    partial class Tela_reg_autoria
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
            this.textBoxLogs = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogs.DefaultText = "";
            this.textBoxLogs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxLogs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogs.Location = new System.Drawing.Point(12, 133);
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.PasswordChar = '\0';
            this.textBoxLogs.PlaceholderText = "";
            this.textBoxLogs.SelectedText = "";
            this.textBoxLogs.Size = new System.Drawing.Size(330, 131);
            this.textBoxLogs.TabIndex = 0;
            this.textBoxLogs.TextChanged += new System.EventHandler(this.TextBoxLogs_TextChanged);
            // 
            // Tela_reg_autoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1103, 622);
            this.Controls.Add(this.textBoxLogs);
            this.Name = "Tela_reg_autoria";
            this.Text = "Tela_reg_autoria";
            this.Load += new System.EventHandler(this.Tela_reg_autoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxLogs;
    }
}