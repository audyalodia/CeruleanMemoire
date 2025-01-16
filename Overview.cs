using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeruleanMémoire
{
    public partial class Overview : Form
    {

        private TimeSpan quizTime;
        private List<Flashcard> flashcards;

        public Overview()
        {
            InitializeComponent();
        }

        public Overview(List<Flashcard> flashcards, TimeSpan timeElapsed)
        {
            InitializeComponent();
            this.flashcards = flashcards ?? new List<Flashcard>();
            quizTime = timeElapsed;
            DisplayTime();
        }

        private void DisplayTime()
        {
            Result.Text = $"{quizTime.Minutes:D2}:{quizTime.Seconds:D2}";
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(flashcards, quizTime);
            mainForm.Show();
            this.Close();
        }
    }
}
