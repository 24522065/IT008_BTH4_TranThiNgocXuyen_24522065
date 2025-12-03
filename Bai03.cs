using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip_Click(object sender, EventArgs e)
        {

        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter =
                "Media Files|*.mp3;*.mp4;*.avi;*.mpeg;*.wav;*.midi|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStrip.Text = $"Hôm nay là ngày {DateTime.Now:dd/MM/yyyy} - Bây giờ là {DateTime.Now:HH:mm:ss}";
        }
    }
}
