using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoTheThing()
        {
            Random rand = new Random();
            float wins = 0;
            int doors = (int) NumberOfDoors.Value;
            float attempts = (int)NumberOfAttempts.Value;


            for(int i = (int)attempts; i > 0; i--)
            {
                int winDoor = rand.Next(1, doors+1);
                int selectedDoor = rand.Next(1, doors+1);
                if (RadioSwitch.Checked)
                {
                    if (winDoor != selectedDoor)
                    {
                        wins++;
                    }
                }
                else
                {
                    if(winDoor == selectedDoor)
                    {
                        wins++;
                    }
                }
            }
            float dec = (wins / attempts) * 100;
            Math.Round(attempts);
            Math.Round(dec);

            dec = (int)dec;

            ResTextBox.Text = "You won " + wins + " out of " + attempts + " attempts. You won " + dec + "% of the time.";
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            DoTheThing();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Monty Hall Problem is where Monty presents you with three doors, one of which contains a prize. He asks you to pick one door, which remains closed. Monty opens one of the other doors that does not have the prize. \n This application is meant to illustrate the odds of winning by selecting to keep or switch doors and letting the program simulate the results a set number of times. \n You can change the number of doors to better illustrate the results, and change the number of attempts to increase the sample size.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Henrik Sigeman 2020. The application icon was made by Iconza");
        }
    }
}
