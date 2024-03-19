using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace BastardGame
{
    public partial class Form1 : Form
    {

        int counter;
        Random randGen = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //wait 2 secs, close program
            Thread.Sleep(2000);
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //wait 1 sec, make buttons invisible, make textbox visible
            Thread.Sleep(1000);
            Refresh();
            startButton.Visible = false;
            exitButton.Visible = false;
            textLabel.Visible = true;

            

            if (counter == 0)
            {
                textLabel.Text = "Click to proceed...";
            }

        }

        private void textLabel_Click(object sender, EventArgs e)
        {
            counter++;
            Refresh();

            int decisionSwitch = 99;



            switch (counter)
            {
                case 1: //prologue; change image, add text

                    pictureBox.BackgroundImage = null;
                    Refresh();
                    pictureBox.BackColor = Color.Black;
                    Refresh();

                    textLabel.Text = "";
                    string text1 = "SCHOOL IS A JUNGLE.";
                    foreach (char c in text1)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(100);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(500);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue1;
                    break;

                case 2:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue2;
                    Refresh();

                    textLabel.Text = "";
                    string text2 = "MANNY KIM IS A LION AT THE HEAD OF THE FOOD CHAIN.";
                    foreach (char c in text2)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(25);
                        textLabel.Refresh();

                    }
                    break;

                case 3:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue3;
                    Refresh();

                    textLabel.Text = "";
                    string text3 = "THE STONGEST OF ALL WHO NEVER LOOKS AT A GUY LIKE ME.";
                    foreach (char c in text3)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(25);
                        textLabel.Refresh();

                    }
                    break;

                case 4:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue4;
                    Refresh();

                    textLabel.Text = "";
                    string text4 = "PANN HAN IS A WOLF WANDERING BY HIS SIDE.";
                    foreach (char c in text4)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(25);
                        textLabel.Refresh();

                    }
                    break;

                case 5:
                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue5;
                    Refresh();

                    textLabel.Text = "";
                    string text5 = "HE DOESN'T DIRECTLY HARASS ME, BUT HE COULD DEVOUR ME AT ANY MOMENT";
                    foreach (char c in text5)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(25);
                        textLabel.Refresh();

                    }
                    break;
            }
            //textLabel.Text = $"{counter}";
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {


            if (counter == 1)
            {
                counter = 5;
            }
            //DisplayPage();
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {

        }

        //private void DisplayPage();
        //{
        ////dwadwad
        //}
    }
}
