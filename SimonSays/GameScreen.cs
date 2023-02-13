﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        int guess;


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1
            Form1.pattern.Clear();
            //TODO: refresh
            Refresh();
            //TODO: pause for a bit
            Thread.Sleep(300);
            //TODO: run ComputerTurn()
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            Random rand = new Random();
            int newPattern = rand.Next(0, 4);
            Form1.pattern.Add(newPattern);
            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button

            //TODO: set guess value back to 0
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value in the pattern list at index [guess] equal to a green?
                // change button color
                // play sound
                // refresh
                // pause
                // set button colour back to original
                // add one to the guess variable
             
            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
                // call ComputerTurn() method
                // else call GameOver method
        }

        public void GameOver()
        {
            //TODO: Play a game over sound

            //TODO: close this screen and open the GameOverScreen

        }

        private void engine_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
