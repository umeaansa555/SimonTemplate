﻿using System;
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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            Form1.titleMusic.Play();
            Form1.titleMusic.Volume = 2;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen
            Form1.titleMusic.Stop();
            Form1.ChangeScreen(this, new GameScreen());

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            Application.Exit();
        }
    }
}
