using System;
using System.CodeDom.Compiler;
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
    public partial class StartQuiz : Form
    {

        private List<Flashcard> flashcards; // load list flashcard
        private int currentFlashcardIndex = 0; // set indeks 0
        private bool showingQuestion = true; // track question and answer
        private Timer quizTimer; // timer set up
        private DateTime startTime;

        public StartQuiz(List<Flashcard> flashcards)
        {
            InitializeComponent();
            this.flashcards = flashcards;

            // acak list flashcard
            ShuffleFlashcards();
            DisplayFlashcard();
        }

        private void ShuffleFlashcards()
        {
            var random = new Random();
            for (int i = flashcards.Count - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = flashcards[i];
                flashcards[i] = flashcards[j]; 
                flashcards[j] = temp;  
            }
        }
        private void DisplayFlashcard()
        {
            if (flashcards.Count == 0)
            {
                FlashcardTxt.Text = "Tidak ada flashcards yang disimpan.";
                FlipBtn.Enabled = false;
                return;
            }

            var flashcard = flashcards[currentFlashcardIndex];
            FlashcardTxt.Text = showingQuestion ? flashcard.Question : flashcard.Answer;

        }
        private async void FlipBtn_Click(object sender, EventArgs e)
        {
            FlashcardTxt.Text = "";
            await Task.Delay(300);
            showingQuestion = !showingQuestion;
            DisplayFlashcard();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (flashcards.Count == 0) return;
            {
                currentFlashcardIndex = (currentFlashcardIndex + 1) % flashcards.Count;
                showingQuestion = true;
                DisplayFlashcard();
            }
        }

        private void StartQuiz_Load(object sender, EventArgs e)
        {
            quizTimer = new Timer();
            quizTimer.Interval = 1000;
            quizTimer.Tick += Timer_Tick;

            startTime = DateTime.Now;
            quizTimer.Start();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            quizTimer.Stop();
            TimeSpan timeElapsed = DateTime.Now - startTime;
            
            Form1 mainform = new Form1(flashcards, timeElapsed);
            mainform.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - startTime;
            Timer.Text = $"Waktu: {timeElapsed.Minutes:D2}:{timeElapsed.Seconds:D2}";
        }

        private void FlashcardTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
