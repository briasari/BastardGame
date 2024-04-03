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
        int opt1;
        int opt2;
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
            proceedLabel.Visible = true;
            Refresh();


            if (page == 0)
            {
                textLabel.Text = "[PROLOGUE]";
            }

        }

        private void textLabel_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                prologue++;
                DisplayPagePrologue();
            }
            else
            {
                page++;
                DisplayPageMain();
            }

           


        }

        private void optionButton1_Click(object sender, EventArgs e)
        {

            if (page == 13)
            {
                opt1++;
                page = 14;
                DisplayPageMain();
            }
            
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            
            if (page == 13)
            {
                opt2++;
                page = 14;
                DisplayPageMain();
            }
            

        }

        private void DisplayPagePrologue()
        {
            charPictureBox.Parent = pictureBox;

            switch (prologue)
            {
               case 1: //prologue; change image, add text

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 2:
                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;

                case 3:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;

                case 4:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;

                case 5:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 6:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 7:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 8:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 9:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 11:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 12:

                    proceedLabel.Visible = false;

                    Refresh();

                    textLabel.Text = "";
                    string text12 = "YOU ALWAYS STAY BEHIND IN THE CLASSROOM DURING GYM CLASS BECAUSE YOU SAY YOU'RE NOT FEELING WELL!";
                    foreach (char c in text12)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 13:

                    proceedLabel.Visible = false;

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


                    proceedLabel.Visible = true;

                    break;


                case 14:

                    proceedLabel.Visible = false;

                    textLabel.Text = "";
                    string text14 = "I'M JUST A WEAK HERBIVORE AT THE BOTTOM OF THIS JUNGLE.";
                    foreach (char c in text14)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 15:

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue10;
                    //charPictureBox.BackgroundImage = Properties.Resources.jin;
                    //charPictureBox.Visible = true;
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


                    proceedLabel.Visible = true;

                    break;


                case 16:

                    proceedLabel.Visible = false;

                    //charPictureBox.Visible = false;
                    nameLabel.Visible = false;

                    Refresh();

                    textLabel.Text = "";
                    string text16 = "BEAU PARK KNEES ME IN THE STOMACH UNEXPECTEDLY, KNOCKING THE AIR OUT OF ME. ALL I CAN DO IS COUGH AS HE GRABS ME AND SHAKES ME BY THE COLLAR.";
                    foreach (char c in text16)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(2000);
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


                    proceedLabel.Visible = true;

                    break;


                case 17:

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue12;
                    charPictureBox.Visible = false;
                    //charPictureBox.BackgroundImage = Properties.Resources.jin;
                   // charPictureBox.Visible = true;
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

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue13;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;

                    Refresh();

                    textLabel.Text = "";
                    string text172 = "BEAU PARK PUNCHES ME IN THE CHEST. HE LOOKS EVEN ANGRIER.";
                    foreach (char c in text172)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(2000);
                    Refresh();

                    //charPictureBox.BackgroundImage = Properties.Resources.jin;
                    //charPictureBox.Visible = true;
                    nameLabel.Text = "JIN SEON";
                    nameLabel.Visible = true;

                    Refresh();

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue14;

                    pictureBox.Refresh();

                    textLabel.Text = "";
                    string text173 = "UMPH... IT WASN'T M--... *COUGH*";
                    foreach (char c in text173)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 18:

                    proceedLabel.Visible = false;

                    //charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue15;

                    Refresh();

                    textLabel.Text = "";
                    string text18 = "BEAU PARK DOESN'T LISTEN.";
                    foreach (char c in text18)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1500);

                    Refresh();

                    charPictureBox.BackgroundImage = Properties.Resources.bp_angry;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "BEAU PARK";
                    nameLabel.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text182 = "I KNOW IT WAS YOU, A$$HOLE!";
                    foreach (char c in text182)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 19:

                    proceedLabel.Visible = false;

                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue16;

                    Refresh();

                    textLabel.Text = "";
                    string text19 = "BEAU PARK SHOVES ME TO THE GROUND.";
                    foreach (char c in text19)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1500);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue17;

                    Refresh();

                    textLabel.Text = "";
                    string text192 = "HIS FOOT COMES STOMPING DOWN ON MY RIBS AS HE SPOUTS CURSES.";
                    foreach (char c in text192)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue18;

                    Refresh();

                    textLabel.Text = "";
                    string text193 = "I SCREAM OUT";
                    foreach (char c in text193)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue19;

                    Refresh();

                    textLabel.Text = "";
                    string text194 = "EVEN IF I TOLD HIM THE TRUTH, HIS INFERIRORITY COMPLEX WOULDN'T LISTEN.";
                    foreach (char c in text194)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 20:

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue20;

                    Refresh();

                    textLabel.Text = "";
                    string text20 = ".....!!";
                    foreach (char c in text20)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(750);

                    textLabel.Text = "";
                    string text202 = "MY HEART THUMPS ALARMINGLY IN MY CHEST";
                    foreach (char c in text202)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 21:

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue21;
                    ////charPictureBox.BackgroundImage = Properties.Resources.jin_urgent;
                    //charPictureBox.Visible = true;
                    nameLabel.Visible = true;
                    nameLabel.Text = "JIN SEON";

                    Refresh();

                    textLabel.Text = "";
                    string text21 = "S-STOP.. *HUFF*";
                    foreach (char c in text21)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    } 

                    Thread.Sleep(750);

                    textLabel.Text = "";
                    string text212 = "*HUFF* I-IT'S DANGEROUS...";
                    foreach (char c in text212)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }


                    proceedLabel.Visible = true;

                    break;


                case 22:

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue22;
                    nameLabel.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text22 = "AS BEAU PARK LOOKS DOWN AT ME, MY VISION BLURS. HIS VOICE SOUNDS MUFFLED.";
                    foreach (char c in text22)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(2000);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue23;

                    textLabel.Text = "";
                    string text222 = "I... CAN HARDLY TELL UP FROM DOWN.";
                    foreach (char c in text222)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1500);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue24;
                    textLabel.Text = "...";
                    Refresh();
                    Thread.Sleep(1500);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue25;
                    Refresh();
                    Thread.Sleep(1500);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue26;
                    nameLabel.Visible = true;
                    nameLabel.Text = "???";
                    textLabel.Text = "?!";
                    Refresh();
                    Thread.Sleep(1500);

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue27;
                    nameLabel.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text223 = "AS MY EYELIDS GROW HEAVIER AND HEAVIER, SOMEONE ENTERS MY LINE OF SIGHT.";
                    foreach (char c in text223)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(2000);

                    nameLabel.Text = "???";
                    nameLabel.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text224 = "STOP IT!";
                    foreach (char c in text224)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1500);

                    nameLabel.Visible = false;
                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue28;
                    Refresh();

                    textLabel.Text = "";
                    string text225 = "VAGUELY, I CAN MAKE OUT THE SOUND OF YELLING.";
                    foreach (char c in text225)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    pictureBox.BackgroundImage = Properties.Resources.bstd_prologue29;

                    Refresh();

                    Thread.Sleep(1500);

                    pictureBox.BackgroundImage = null;
                    pictureBox.BackColor = Color.Black;

                    Refresh();

                    textLabel.Text = "";
                    string text226 = "AND THEN THE WORLD GOES BLACK.";
                    foreach (char c in text226)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(75);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    textLabel.Text = "";
                    string text227 = "[PROLOGUE] END ; [MAIN STORY] START";
                    foreach (char c in text227)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(75);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1500);

                    prologue = 100;

                    proceedButton.Visible = true;

                    break;

            }

        }

        private void DisplayPageMain()
        {

            charPictureBox.Parent = pictureBox;

            switch (page)
            {
                case 1:

                    proceedLabel.Visible = false;

                    textLabel.Text = "...";
                    pictureBox.BackgroundImage = Properties.Resources.bstd_homescreen;

                    Refresh();

                    Thread.Sleep(2500);

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.chap1_1;
                    pictureBox.Refresh();

                    Thread.Sleep(3000);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_2;
                    pictureBox.Refresh();

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_3;
                    pictureBox.Refresh();

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_4;
                    pictureBox.Refresh();

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_5;
                    pictureBox.Refresh();

                    Thread.Sleep(1250);

                    //rustling clothes noise
                    pictureBox.BackgroundImage = Properties.Resources.chap1_6;
                    pictureBox.Refresh();

                    textLabel.Text = "";
                    string text1 = "...WHERE AM I?";
                    foreach (char c in text1)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(100);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(500);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 2:

                    proceedLabel.Visible = false;

                    nameLabel.Text = "???";
                    nameLabel.Visible = true;

                    pictureBox.BackgroundImage = Properties.Resources.chap1_7;

                    Refresh();

                    textLabel.Text = "";
                    string text2 = "OH, YOU'RE AWAKE!";
                    foreach (char c in text2)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1250);

                    Refresh();

                    nameLabel.Text = "JIN SEON";
                    Refresh();

                    textLabel.Text = "";
                    string text1two = "!?";
                    foreach (char c in text1two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Refresh();
                    Thread.Sleep(750);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 3:

                    proceedLabel.Visible = false;

                    nameLabel.Text = "MR. PARK";
                    pictureBox.BackgroundImage = Properties.Resources.chap1_8;
                    charPictureBox.BackgroundImage = Properties.Resources.gymteach;
                    charPictureBox.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text3 = "MAN~ THAT WAS REALLY CLOSE.";
                    foreach (char c in text3)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();

                    }

                    Thread.Sleep(1000);

                    textLabel.Text = "";
                    string text3two = "WHAT THE HECK HAPPENED?";
                    foreach (char c in text3two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1000);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 4:

                    charPictureBox.Visible = false;
                    proceedLabel.Visible = false;

                    nameLabel.Text = "JIN SEON";
                    nameLabel.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_9;
                    Refresh();

                    textLabel.Text = "";
                    string text4 = "WHAT?";
                    foreach (char c in text4)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(75);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    textLabel.Text = "......";
                    nameLabel.Visible = false;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_10;
                    Refresh();

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_11;
                    pictureBox.Refresh();

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_12;
                    pictureBox.Refresh();

                    Thread.Sleep(1250);

                    proceedLabel.Visible= true;
                    Refresh();

                    break;

                case 5:

                    proceedLabel.Visible = false;

                    nameLabel.Text = "MR. PARK";
                    nameLabel.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_13;
                    charPictureBox.BackgroundImage = Properties.Resources.gymteach;
                    charPictureBox.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text5 = "SHE CALLED THE AMBULANCE AND SAVED YOU.";
                    foreach (char c in text5)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Refresh();

                    Thread.Sleep(750);

                    textLabel.Text = "";
                    string text5two = "SAY HI, THIS IS OUR NEW TRANSFER STUDENT.";
                    foreach (char c in text5two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 6:

                    proceedLabel.Visible = false;
                    Refresh();

                    nameLabel.Text = "???";
                    pictureBox.BackgroundImage = Properties.Resources.chap1_14;
                    charPictureBox.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text6 = "HI THERE.";
                    foreach (char c in text6)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1250);

                    textLabel.Text = "";
                    string text6two = "I'M KYUN YOON, BUT YOU CAN CALL ME YOUR LIFE LIFE SAVIOR";
                    foreach (char c in text6two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_15;
                    nameLabel.Text = "JIN SEON";
                    textLabel.Text = "....";

                    Thread.Sleep(1000);

                    nameLabel.Text = "KYUN YOON";
                    nameLabel.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_16;
                    charPictureBox.BackgroundImage= Properties.Resources.ky_smile;
                    charPictureBox.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text6three = "I EXPECT YOU TO REPAY ME FOR THIS.";
                    foreach (char c in text6three)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1500);

                    nameLabel.Text = "JIN SEON";
                    nameLabel.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_17;
                    charPictureBox.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text6four = "...KYUN.....YOON...";
                    foreach (char c in text6four)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(120);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 7:

                    proceedLabel.Visible = false;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_18;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text7 = "MR. PARK'S PHONE BUZZED IN HIS POCKET.";
                    foreach (char c in text7)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_19;
                    nameLabel.Text = "MR PARK";
                    nameLabel.Visible = true;
                    charPictureBox.BackgroundImage = Properties.Resources.gymteach;
                    charPictureBox.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text7two = "AH. ONE SEC, PHONE CALL.";
                    foreach (char c in text7two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 8:

                    proceedLabel.Visible = false;

                    pictureBox.BackgroundImage = Properties.Resources.chap1_20;
                    nameLabel.Visible = false;
                    charPictureBox.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text8 = "AS MR. PARK ANSWERED HIS PHONE, KYUN YOON APPROACHED ME.";
                    foreach (char c in text8)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1000);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_21;
                    nameLabel.Visible = true;
                    nameLabel.Text = "KYUN YOON";
                    charPictureBox.BackgroundImage = Properties.Resources.ky_smile;
                    charPictureBox.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text8two = "I DIDN'T TELL HIM WHAT REALLY HAPPENED... IT'S PROBABLY BETTER LIKE THAT, HUH?";
                    foreach (char c in text8two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1500);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 9:

                    pictureBox.BackgroundImage = Properties.Resources.chap1_22;
                    proceedLabel.Visible = false;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text9 = "I NODDED MY HEAD.";
                    foreach (char c in text9)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 10:
                    pictureBox.BackgroundImage = Properties.Resources.chap1_23;
                    proceedLabel.Visible = false;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    Refresh();

                    textLabel.Text = "";
                    string text10 = "MR. PARK HUNG UP HIS PHONE AND TURNED BACK TO US.";
                    foreach (char c in text10)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1250);

                    pictureBox.BackgroundImage = Properties.Resources.chap1_24;
                    charPictureBox.BackgroundImage = Properties.Resources.gymteach;
                    charPictureBox.Visible = true;
                    nameLabel.Text = "MR. PARK";
                    nameLabel.Visible = true;
                    Refresh();

                    textLabel.Text = "";
                    string text10two = "AH, JIN. YOUR ";
                    foreach (char c in text10two)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    textLabel.ForeColor = Color.Maroon;
                    textLabel.Refresh();

                    string text10three = "FATHER ";
                    foreach (char c in text10three)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(200);
                        textLabel.Refresh();
                    }

                    textLabel.ForeColor = Color.White;
                    textLabel.Refresh();

                    string text10four = "SAYS HE'S ALMOST HERE. I'LL STAY HERE UNTIL HE ARRIVES";
                    foreach (char c in text10four)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }
                 
                    proceedLabel.Visible = true;
                    Refresh();

                    break;

                case 11:

                    pictureBox.BackgroundImage = Properties.Resources.chap1_25;
                    textLabel.Text = "...";
                    proceedLabel.Visible = false;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    //play heartbeat sound
                    //wait 2000 milis
                    nameLabel.Visible = true;
                    nameLabel.Text = "JIN SEON";

                    Refresh();

                    textLabel.Text = "";
                    string text11 = "WHO DID YOU SAY... IS COMING?";
                    foreach (char c in text11)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(125);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1250);
                    proceedLabel.Visible = true;

                    break;

                case 12:

                    proceedLabel.Visible = false;

                    nameLabel.Text = "MR. PARK";
                    pictureBox.BackgroundImage = Properties.Resources.chap1_26;
                    charPictureBox.BackgroundImage = Properties.Resources.gymteach;
                    charPictureBox.Visible = true;

                    Refresh();

                    textLabel.Text = "";
                    string text12 = "YOUR FATHER, HE SAID HE'S ALMOST HERE.";
                    foreach (char c in text12)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = false;
                    Refresh();

                    break;

                case 13:

                    proceedLabel.Visible = false;
                    charPictureBox.Visible = false;
                    nameLabel.Visible = false;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_27;

                    Refresh();

                    textLabel.Text = "";
                    string text13 = "I TURNED TO KYUN YOON...";
                    foreach (char c in text13)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(100);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(1750);

                    optionButton1.Text = "COLDLY TELL KYUN YOON TO LEAVE";
                    optionButton1.Visible = true;
                    optionButton2.Text = "ANGRILY KICK KYUN YOON OUT";
                    optionButton2.Visible = true;

                    Refresh();

                    break;

                case 14:

                    proceedLabel.Visible = false;
                    nameLabel.Visible = true;
                    nameLabel.Text = "JIN SEON";
                    pictureBox.BackgroundImage = Properties.Resources.chap1_28;

                    Refresh();

                    textLabel.Text = "";
                    string text14 = "GET OUT.";
                    foreach (char c in text14)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = true;

                    Refresh();

                    break;

                case 15:

                    proceedLabel.Visible = false;
                    nameLabel.Visible = false;
                    nameLabel.Text = "KYUN YOON";
                    pictureBox.BackgroundImage = Properties.Resources.chap1_29;
                    textLabel.Text = "...";

                    Refresh();

                    Thread.Sleep(1750);

                    charPictureBox.BackgroundImage = Properties.Resources.ky_angry;
                    charPictureBox.Visible = true;
                    nameLabel.Visible = true;
                    pictureBox.BackgroundImage = Properties.Resources.chap1_30;

                    textLabel.Text = "";
                    string text15 = "...!? HUH?";
                    foreach (char c in text15)
                    {
                        textLabel.Text += c;
                        Thread.Sleep(35);
                        textLabel.Refresh();
                    }

                    Thread.Sleep(750);

                    proceedLabel.Visible = true;

                    Refresh();

                    break;

                case 16:

                    proceedLabel.Visible = false;

                    Refresh();

                    if (opt1 == 1)
                    {
                        charPictureBox.BackgroundImage = Properties.Resources.ky_angry;
                        charPictureBox.Visible = false;
                        nameLabel.Text = "JIN SEON";
                        nameLabel.Visible = true;
                        pictureBox.BackgroundImage = Properties.Resources.chap1_31;

                        Refresh();

                        textLabel.Text = "";
                        string text16 = "YOU'RE THE TRANSFER STUDENT... KYUN YOON, RIGHT?... I SAID GET OUT.";
                        foreach (char c in text16)
                        {
                            textLabel.Text += c;
                            Thread.Sleep(35);
                            textLabel.Refresh();
                        }

                        Thread.Sleep(1250);

                        page = 17;
                        DisplayPageMain();

                    }

                    if (opt2 == 1)
                    {

                        page = 17;
                        DisplayPageMain();

                    }

                    Refresh();

                    break;

                case 17:

                    proceedLabel.Visible = false;

                    Refresh();



                    Thread.Sleep(750);

                    proceedLabel.Visible = true;



                    break;
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            page = 0;

            if (page == 0)
            {
                page++;
                DisplayPageMain();
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            page = 9;
            DisplayPageMain();
        }
    }
}
