using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;
using System.IO;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //TODO: create a List to store the pattern. Must be accessable on other screens
        public static List<int> pattern = new List<int>();
        public static System.Windows.Media.MediaPlayer bgm = new System.Windows.Media.MediaPlayer();
        

        public Form1()
        {
            InitializeComponent();
            bgm.Open(new Uri(Application.StartupPath + "/Resources.034 - Laser Hockey.mp3"));
            bgm.MediaEnded += new EventHandler(bgm_MediaEnded);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Launch MenuScreen
            MenuScreen ms = new MenuScreen();

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);

            bgm.Play();
        }

        public static void bgm_MediaEnded (object sender, EventArgs e)
        {
            bgm.Stop();
            bgm.Play();
        }

    }
}
