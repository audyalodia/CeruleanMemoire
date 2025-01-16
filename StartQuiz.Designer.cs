namespace CeruleanMémoire
{
    partial class StartQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartQuiz));
            this.FlashcardTxt = new System.Windows.Forms.Label();
            this.FlipBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlashcardTxt
            // 
            this.FlashcardTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.FlashcardTxt.Font = new System.Drawing.Font("Josefin Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashcardTxt.Location = new System.Drawing.Point(528, 344);
            this.FlashcardTxt.Name = "FlashcardTxt";
            this.FlashcardTxt.Size = new System.Drawing.Size(859, 357);
            this.FlashcardTxt.TabIndex = 0;
            this.FlashcardTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlipBtn
            // 
            this.FlipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.FlipBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipBtn.Location = new System.Drawing.Point(1419, 253);
            this.FlipBtn.Name = "FlipBtn";
            this.FlipBtn.Size = new System.Drawing.Size(110, 53);
            this.FlipBtn.TabIndex = 1;
            this.FlipBtn.Text = "Flip";
            this.FlipBtn.UseVisualStyleBackColor = false;
            this.FlipBtn.Click += new System.EventHandler(this.FlipBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.NextBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(1419, 735);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(110, 53);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.HomeBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(909, 859);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(185, 53);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CeruleanMémoire.Properties.Resources.Untitled_design__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(267, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1453, 719);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.Timer.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(457, 257);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(0, 35);
            this.Timer.TabIndex = 5;
            this.Timer.Click += new System.EventHandler(this.Timer_Tick);
            // 
            // StartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(143)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.FlipBtn);
            this.Controls.Add(this.FlashcardTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartQuiz";
            this.Text = "StartQuiz";
            this.Load += new System.EventHandler(this.StartQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlashcardTxt;
        private System.Windows.Forms.Button FlipBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Timer;
    }
}