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

        int page;
        int prologue;
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



            if (page == 0)
            {
                textLabel.Text = "Click to proceed...";
            }

        }

        private void textLabel_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                prologue++;
            }

            DisplayPage();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {


            if (page == 1)
            {
                page = 5;
            }
            //DisplayPage();
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {

            prologue = 5;
            DisplayPage();

        }

        private void DisplayPage()
        {
            charPictureBox.Parent = pictureBox;

            switch (prologue)
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
                    Refresh();

                    break;


                case 2:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue2;
                    Refresh();

                    textLabel.Text = "";
                    string text2 = "MANNY KIM IS A LION AT THE HEAD OF THE FOOD CHAIN.";
                    foreach (char c in text2)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;

                case 3:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue3;
                    Refresh();

                    textLabel.Text = "";
                    string text3 = "THE STONGEST OF ALL WHO NEVER LOOKS AT A GUY LIKE ME.";
                    foreach (char c in text3)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(0);

                    break;

                case 4:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue4;
                    Refresh();

                    textLabel.Text = "";
                    string text4 = "PANN HAN IS A WOLF WANDERING BY HIS SIDE.";
                    foreach (char c in text4)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;

                case 5:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue5;
                    Refresh();

                    textLabel.Text = "";
                    string text5 = "HE DOESN'T DIRECTLY HARASS ME, BUT HE COULD DEVOUR ME AT ANY MOMENT.";
                    foreach (char c in text5)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 6:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue6;
                    charPictureBox.BackgroundImage = Properties.Resources.bp_angry;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "BEAU PARK";
                    nameLabel.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text6 = "IT'S YOU, ISN'T IT?!";
                    foreach (char c in text6)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 7:

                    //charPictureBox.BackgroundImage= Properties.Resources.jin_confused
                    nameLabel.Text = "JIN SEON";
                    nameLabel.Refresh();

                    textLabel.Text = "";
                    string text7 = ".....";
                    foreach (char c in text7)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    textLabel.Text = "";
                    string text72 = "W-WHAT?";
                    foreach (char c in text72)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1500);

                    break;


                case 8:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue7;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;

                    Refresh();

                    textLabel.Text = "";
                    string text8 = "BEAU PARK IS A HYENA.";
                    foreach (char c in text8)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 9:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue8;

                    Refresh();

                    textLabel.Text = "";
                    string text9 = "HE POSES A VERY REAL THREAT TO ME";
                    foreach (char c in text9)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 10:

                    Refresh();

                    textLabel.Text = "";
                    string text10 = "AND HE'S A PATHETIC COWARD WHO TAKES OUT HIS REPRESSED URGES ON ME BECAUSE I'M WEAKER THAN HIM.";
                    foreach (char c in text10)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 11:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue6;
                    charPictureBox.BackgroundImage = Properties.Resources.bp_angry;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "BEAU PARK";
                    nameLabel.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text11 = "THE MORE I THINK ABOUT IT, SOMETHING'S NOT RIGHT...!";
                    foreach (char c in text11)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 12:

                    Refresh();

                    textLabel.Text = "";
                    string text12 = "YOU ALWAYS STAY BEHIND IN THE CLASSROOM DURING GYM CLASS BECAUSE YOU SAY YOU'RE NOT FEELING WELL!";
                    foreach (char c in text12)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 13:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue9;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;

                    Refresh();

                    textLabel.Text = "";
                    string text13 = "AND ME...";
                    foreach (char c in text13)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 14:

                    textLabel.Text = "";
                    string text14 = "I'M JUST A WEAK HERBIVORE AT THE BOTTOM OF THIS JUNGLE.";
                    foreach (char c in text14)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 15:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue10;
                    //charPictureBox.BackgroundImage = Properties.Resources.jin;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "JIN SEON";
                    nameLabel.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text15 = "UGH!";
                    foreach (char c in text15)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 16:

                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;

                    Refresh();

                    textLabel.Text = "";
                    string text16 = "BEAU PARK KNEES YOU IN THE STOMACH UNEXPECTEDLY, ALMOST KNOCKING THE AIR OUT OF YOU. ALL YOU CAN DO IS COUGH AS BEAU PARK GRABS YOU AND SHAKES YOU BY THE COLLAR.";
                    foreach (char c in text16)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);
                    Refresh();

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue11;
                    charPictureBox.BackgroundImage = Properties.Resources.bp_angry;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "BEAU PARK";
                    nameLabel.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text162 = "YOU TOOK MY WALLET, DIDN'T YOU?! YOU LITTLE GLASS-EYE FREAK!";
                    foreach (char c in text162)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;


                case 17:

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue12;
                    //charPictureBox.BackgroundImage = Properties.Resources.jin;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "JIN SEON";
                    nameLabel.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text17 = "I DON'T KNOW WHAT YOU'RE TAL-...";
                    foreach (char c in text17)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);
                    Refresh();

                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;

                    textLabel.Text = "";
                    string text172 = "BEAU PARK PUNCHES YOU IN THE CHEST. HE LOOKS EVEN ANGRIER.";
                    foreach (char c in text172)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);
                    Refresh();

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue13;
                    //charPictureBox.BackgroundImage = Properties.Resources.jin;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "JIN SEON";
                    nameLabel.Visible = true;

                    Refresh();

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue14;

                    Refresh();

                    textLabel.Text = "";
                    string text173 = "UMPH... IT WASN'T M--... *COUGH*";
                    foreach (char c in text173)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    break;

            }

        }
    }
}
