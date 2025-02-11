using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            string userGuesses = string.Join(", ", Form1.guesses);
            guessesLabel.Text = $"you guessed:\n{userGuesses}";

            guessNumLabel.Text = $"you took {Form1.guesses.Count} tries";

        }
    }
}
