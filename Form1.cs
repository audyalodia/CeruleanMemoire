using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Bson;

namespace CeruleanMémoire
{
    public partial class Form1 : Form
    {

        private List<Flashcard> flashcards; // deklarasi flashcard
        private TimeSpan lastQuizTime;

        public Form1()
        {
            InitializeComponent();
            flashcards = new List<Flashcard>(); 
            lastQuizTime = TimeSpan.Zero;
        }

        public Form1(List<Flashcard> flashcards, TimeSpan lastQuizTime = default(TimeSpan)) : this()
        {
            InitializeComponent();
            this.flashcards = flashcards ?? new List<Flashcard>();
            this.lastQuizTime = lastQuizTime != default(TimeSpan) ? lastQuizTime : TimeSpan.Zero;
        }

        public void SetLastQuizTime(TimeSpan timeElapsed)
        {
            lastQuizTime = timeElapsed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printDocumentFlashcard.PrintPage += PrintDocumentFlashcard_PrintPage;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (printDialogFlashcard.ShowDialog() == DialogResult.OK) {
                printDocumentFlashcard.Print();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var createDeckForm = new CreateDeck(flashcards);
            this.Hide();
            createDeckForm.FormClosed += (s, args) => this.Close();
            createDeckForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // cek apakah ada flashcard yang sudah disimpan
                if (flashcards == null || flashcards.Count == 0)
                {
                    MessageBox.Show("Tidak ada flashcard yang disimpan, silahkan buat deck terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // pass data flashcard ke form StartQuiz
                StartQuiz startQuizForm = new StartQuiz(flashcards);
                startQuizForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka form Start Quiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // cek jika sudah ada quiz yang dimulai
            if (lastQuizTime == TimeSpan.Zero)
            {
                MessageBox.Show("Belum ada ringkasan yang bisa diberikan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Overview overviewForm = new Overview(lastQuizTime);
            overviewForm.Show();
            this.Close();
        }

        private void PrintDocumentFlashcard_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // set posisi text dan spasi antar text
            int yPosition = 50;
            int lineHeight = 50;

            // judul
            e.Graphics.DrawString("List Flashcards", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, yPosition);
            yPosition += lineHeight * 2;

            // Overview waktu
            string summary = $"Waktu belajar: {lastQuizTime.Minutes:D2}:{lastQuizTime.Seconds:D2}";
            e.Graphics.DrawString(summary, new Font("Arial", 12), Brushes.Black, 50, yPosition);
            yPosition += lineHeight;

            // perulangan untuk list flashcards
            foreach (var flashcard in flashcards) 
            {
                e.Graphics.DrawString($"Question: {flashcard.Question}", new Font("Arial", 12), Brushes.Black, 50, yPosition);
                yPosition += lineHeight;

                e.Graphics.DrawString($"Answer: {flashcard.Answer}", new Font("Arial", 12), Brushes.Black, 50, yPosition);
                yPosition += lineHeight * 2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Yakin mau berhenti belajar?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // jika user pilih yes, maka tutup aplikasi
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
