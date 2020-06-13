using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Wheels_Management
{
    public partial class HomePage : Form
    { WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        public HomePage()
        {
            InitializeComponent();
            player.URL = "music.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
        }
    }
}
