using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CeruleanMémoire
{
    public partial class CreateDeck : Form
    {
        private List<Flashcard> flashcards = new List<Flashcard>(); //init flashcard
        private string deckFilePath = "deck.json"; // simpan deck ke json

        public CreateDeck()
        {
            InitializeComponent();
            flashcards = LoadDeckFromFile();
            UpdateFlashcardsUI();
        }

        public CreateDeck(List<Flashcard> flashcards)
        {
            InitializeComponent();
            this.flashcards = flashcards ?? LoadDeckFromFile(); // load data
            UpdateFlashcardsUI();
        }

        private void CreateDeck_Load(object sender, EventArgs e)
        {
            flashcards = LoadDeckFromFile();
            UpdateFlashcardsUI();
        }

        private int CalculateWordCount(string text)
        {
            if(string.IsNullOrEmpty(text))  return 0;
            return text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void FlashcardDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (flashcards.Count == 0)
            {
                MessageBox.Show("Tidak ada flashcards yang bisa disimpan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveDeckToFile (flashcards);
        }

        private void AddToFlashcard_Click(object sender, EventArgs e)
        {
            string question = QuestionTxt.Text;
            string answer = AnswerTxt.Text;

            // cek apakah textbox jawaban dan pertanyaan memiliki isi
            if (!string.IsNullOrEmpty(question) && !string.IsNullOrEmpty(answer))
            {

                // membuat flashcard baru
                Flashcard newFlashcard = new Flashcard(question, answer);
                flashcards.Add(newFlashcard);

                // menambahkan ke data grid view + pop up message box
                FlashcardDgv.Rows.Add(question, answer);
                MessageBox.Show("Berhasil ditambahkan!");

                // clean up input
                QuestionTxt.Clear();
                AnswerTxt.Clear();
            }
            else
            {
                MessageBox.Show("Tolong isi seluruh kolom.");
            }
        }

        private void SaveDeckToFile(List<Flashcard> flashcards)
        {
            try {
                var json = JsonConvert.SerializeObject(flashcards, Formatting.Indented);
                File.WriteAllText(deckFilePath, json);
                MessageBox.Show("Deck berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deck Tidak Berhasil Disimpan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Flashcard> LoadDeckFromFile()
        {
            try
            {
                if (!File.Exists(deckFilePath)){
                    return new List<Flashcard>(); 
                }
                var json = File.ReadAllText(deckFilePath); // baca file yang sudah ada 
                return JsonConvert.DeserializeObject<List<Flashcard>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deck Tidak Berhasil Dimuat: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Flashcard>();
            }
        }

        private void UpdateFlashcardsUI()
        {
            FlashcardDgv.Rows.Clear(); // reset data grid view

            foreach (var flashcard in flashcards)
            {
                FlashcardDgv.Rows.Add(flashcard.Question, flashcard.Answer);    
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            // kembali ke mainform
            Form1 mainForm = new Form1(flashcards);
            mainForm.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Question_Click_1(object sender, EventArgs e)
        {

        }

        private void QuestionTxt_TextChanged(object sender, EventArgs e)
        {
            int wordCount = CalculateWordCount(QuestionTxt.Text);
            QuestionCountTxt.Text = $"Word Count: {wordCount}";
        }

        private void AnswerTxt_TextChanged(object sender, EventArgs e)
        {
            int wordCount = CalculateWordCount(AnswerTxt.Text);
            AnswerCountTxt.Text = $"Word Count: {wordCount}";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
