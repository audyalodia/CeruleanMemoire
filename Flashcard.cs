using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeruleanMémoire
{
    public class Flashcard
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        // Inisialisasi flashcard untuk pertanyaan dan jawaban
        public Flashcard(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
