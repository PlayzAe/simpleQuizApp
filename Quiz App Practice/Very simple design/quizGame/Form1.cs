using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Has Finished!" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok To try again!"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources._416732_steve_jobs_classic_portrait_desktop_wallpaper;
                    lblQuestion.Text = "Who is this?";

                    button1.Text = "Steve jobs";
                    button2.Text = "A black dude";
                    button3.Text = "Messi";
                    button4.Text = "Red";

                    correctAnswer = 1;
                    break;


                case 2:
                    pictureBox1.Image = Properties.Resources.amr_taha_aGQigjc_5TA_unsplash;
                    lblQuestion.Text = "Whats is the name of the game?";

                    button1.Text = "Rezero";
                    button2.Text = "Attack On Roblox";
                    button3.Text = "Call of duty";
                    button4.Text = "Fifa 23";

                    correctAnswer = 3;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.benjamin_lehman_gkZ_k3xf25w_unsplash;

                    lblQuestion.Text = "What job is he doing?";

                    button1.Text = "Cerfified Fornite gamer";
                    button2.Text = "Anti-Bacteria Hero";
                    button3.Text = "Hero 108";
                    button4.Text = "Doctor";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.karsten_winegeart_ENZ2YoXQS3I_unsplash;
                    lblQuestion.Text = "What animal is this?";

                    button1.Text = "Your mom 🫵🏿";
                    button2.Text = "Sheep";
                    button3.Text = "Dog";
                    button4.Text = "Apex's Player base";

                    correctAnswer = 3;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.pexels_jddaniel_2385477;
                    lblQuestion.Text = "What shoe brand is this?";

                    button1.Text = "Apple shoe max";
                    button2.Text = "Puma";
                    button3.Text = "Adidas";
                    button4.Text = "Air Jordans";

                    correctAnswer = 4;

                    break;

            }

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
