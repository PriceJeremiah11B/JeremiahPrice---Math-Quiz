﻿using System;
using System.Windows.Forms;

namespace JeremiahPrice___Math_Quiz
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        int addend1;
        int addend2;

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //should talk to the labels, but does not show random numbers.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();



            sum.Value = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
