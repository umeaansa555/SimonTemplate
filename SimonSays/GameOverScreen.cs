using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
            Form1.endingMusic.Play();
            Form1.endingMusic.Volume = 5;
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern
            lengthLabel.Text += $"{Form1.pattern.Count}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen
            Form1.endingMusic.Stop();

            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
