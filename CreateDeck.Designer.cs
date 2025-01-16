namespace CeruleanMémoire
{
    partial class CreateDeck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDeck));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Question = new System.Windows.Forms.Label();
            this.QuestionTxt = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.Label();
            this.AnswerTxt = new System.Windows.Forms.TextBox();
            this.FlashcardDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToFlashcard = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.QuestionCountTxt = new System.Windows.Forms.Label();
            this.AnswerCountTxt = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlashcardDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(199, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1633, 911);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1573, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 127);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(325, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 127);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.Question.Font = new System.Drawing.Font("Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(341, 345);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(100, 31);
            this.Question.TabIndex = 8;
            this.Question.Text = "Question:";
            // 
            // QuestionTxt
            // 
            this.QuestionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(189)))), ((int)(((byte)(237)))));
            this.QuestionTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTxt.Location = new System.Drawing.Point(347, 398);
            this.QuestionTxt.Name = "QuestionTxt";
            this.QuestionTxt.Size = new System.Drawing.Size(559, 43);
            this.QuestionTxt.TabIndex = 9;
            this.QuestionTxt.TextChanged += new System.EventHandler(this.QuestionTxt_TextChanged);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.Answer.Font = new System.Drawing.Font("Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(341, 468);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(84, 31);
            this.Answer.TabIndex = 10;
            this.Answer.Text = "Answer:";
            // 
            // AnswerTxt
            // 
            this.AnswerTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(189)))), ((int)(((byte)(237)))));
            this.AnswerTxt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTxt.Location = new System.Drawing.Point(347, 517);
            this.AnswerTxt.Name = "AnswerTxt";
            this.AnswerTxt.Size = new System.Drawing.Size(559, 43);
            this.AnswerTxt.TabIndex = 11;
            this.AnswerTxt.TextChanged += new System.EventHandler(this.AnswerTxt_TextChanged);
            // 
            // FlashcardDgv
            // 
            this.FlashcardDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.FlashcardDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlashcardDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.FlashcardDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.FlashcardDgv.Location = new System.Drawing.Point(990, 374);
            this.FlashcardDgv.Name = "FlashcardDgv";
            this.FlashcardDgv.RowHeadersWidth = 51;
            this.FlashcardDgv.RowTemplate.Height = 24;
            this.FlashcardDgv.Size = new System.Drawing.Size(677, 359);
            this.FlashcardDgv.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Questions";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 260;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Answers";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 260;
            // 
            // AddToFlashcard
            // 
            this.AddToFlashcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.AddToFlashcard.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToFlashcard.Image = ((System.Drawing.Image)(resources.GetObject("AddToFlashcard.Image")));
            this.AddToFlashcard.Location = new System.Drawing.Point(594, 601);
            this.AddToFlashcard.Name = "AddToFlashcard";
            this.AddToFlashcard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddToFlashcard.Size = new System.Drawing.Size(291, 45);
            this.AddToFlashcard.TabIndex = 13;
            this.AddToFlashcard.Text = "Add to Flashcard";
            this.AddToFlashcard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToFlashcard.UseVisualStyleBackColor = false;
            this.AddToFlashcard.Click += new System.EventHandler(this.AddToFlashcard_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.SaveBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(362, 601);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(212, 45);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save Deck";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(529, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(968, 175);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.HomeBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(1514, 780);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(153, 45);
            this.HomeBtn.TabIndex = 16;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // QuestionCountTxt
            // 
            this.QuestionCountTxt.AutoSize = true;
            this.QuestionCountTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.QuestionCountTxt.Font = new System.Drawing.Font("Josefin Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionCountTxt.Location = new System.Drawing.Point(796, 444);
            this.QuestionCountTxt.Name = "QuestionCountTxt";
            this.QuestionCountTxt.Size = new System.Drawing.Size(0, 24);
            this.QuestionCountTxt.TabIndex = 17;
            this.QuestionCountTxt.Click += new System.EventHandler(this.QuestionTxt_TextChanged);
            // 
            // AnswerCountTxt
            // 
            this.AnswerCountTxt.AutoSize = true;
            this.AnswerCountTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.AnswerCountTxt.Font = new System.Drawing.Font("Josefin Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCountTxt.Location = new System.Drawing.Point(796, 561);
            this.AnswerCountTxt.Name = "AnswerCountTxt";
            this.AnswerCountTxt.Size = new System.Drawing.Size(0, 24);
            this.AnswerCountTxt.TabIndex = 18;
            this.AnswerCountTxt.TextChanged += new System.EventHandler(this.AnswerTxt_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(1553, 320);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(114, 45);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CreateDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(143)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AnswerCountTxt);
            this.Controls.Add(this.QuestionCountTxt);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddToFlashcard);
            this.Controls.Add(this.FlashcardDgv);
            this.Controls.Add(this.AnswerTxt);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.QuestionTxt);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateDeck";
            this.Text = "CreateDeck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlashcardDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox QuestionTxt;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox AnswerTxt;
        private System.Windows.Forms.DataGridView FlashcardDgv;
        private System.Windows.Forms.Button AddToFlashcard;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label QuestionCountTxt;
        private System.Windows.Forms.Label AnswerCountTxt;
        private System.Windows.Forms.Button DeleteBtn;
    }
}