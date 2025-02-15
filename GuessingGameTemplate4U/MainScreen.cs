﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class MainScreen : UserControl
    {

        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = randNum.Next(1, 101);

        public MainScreen()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            
            int guess = Convert.ToInt16(inputBox.Text);

            //TODO add guess to List of guesses on Form1

            Form1.guesses.Add(guess);


            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";
                Refresh();
                Thread.Sleep(1000);

                //TODO close this screen and open a Results Screen (you need to create this)

                //make button find out which form it's on
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //add instance of result screen
                ResultScreen rs = new ResultScreen();

                //centre
                rs.Location = new Point((f.Width - rs.Width) / 2, (f.Height - rs.Height) / 2);

                //uc and focus
                f.Controls.Add(rs);
                rs.Focus();
            }

            inputBox.Text = "";
            inputBox.Focus();
        }

    }
}
