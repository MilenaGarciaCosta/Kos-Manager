using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kos_Manager
{
    public partial class Tela_splash : Form
    {
        public Tela_splash()
        {
            InitializeComponent();
        }

        private void Progress_timer_Tick(object sender, EventArgs e)
        {
            Progress_color_splash.Width += 3;
            if(Progress_color_splash.Width >= 616)
            {
                Progress_timer.Stop();
                Tela_login tlgn = new Tela_login();
                tlgn.Show();
                this.Hide();
            }
        }
    }
}
