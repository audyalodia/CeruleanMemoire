namespace CeruleanMémoire
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.OverviewBtn = new System.Windows.Forms.Button();
            this.QuizBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocumentFlashcard = new System.Drawing.Printing.PrintDocument();
            this.printDialogFlashcard = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(819, 764);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ExitBtn.Size = new System.Drawing.Size(390, 56);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Quit";
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.PrintBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(819, 702);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.PrintBtn.Size = new System.Drawing.Size(390, 56);
            this.PrintBtn.TabIndex = 4;
            this.PrintBtn.Text = "Print Results";
            this.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // OverviewBtn
            // 
            this.OverviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.OverviewBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewBtn.Image = ((System.Drawing.Image)(resources.GetObject("OverviewBtn.Image")));
            this.OverviewBtn.Location = new System.Drawing.Point(819, 640);
            this.OverviewBtn.Name = "OverviewBtn";
            this.OverviewBtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.OverviewBtn.Size = new System.Drawing.Size(390, 56);
            this.OverviewBtn.TabIndex = 3;
            this.OverviewBtn.Text = "Overview";
            this.OverviewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OverviewBtn.UseVisualStyleBackColor = false;
            this.OverviewBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuizBtn
            // 
            this.QuizBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.QuizBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizBtn.Image = ((System.Drawing.Image)(resources.GetObject("QuizBtn.Image")));
            this.QuizBtn.Location = new System.Drawing.Point(819, 578);
            this.QuizBtn.Name = "QuizBtn";
            this.QuizBtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.QuizBtn.Size = new System.Drawing.Size(390, 56);
            this.QuizBtn.TabIndex = 2;
            this.QuizBtn.Text = "Start Quiz";
            this.QuizBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuizBtn.UseVisualStyleBackColor = false;
            this.QuizBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateBtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBtn.Image")));
            this.CreateBtn.Location = new System.Drawing.Point(819, 516);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.CreateBtn.Size = new System.Drawing.Size(390, 56);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.Text = "Create Deck";
            this.CreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(771, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 509);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printDialogFlashcard
            // 
            this.printDialogFlashcard.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(143)))), ((int)(((byte)(182)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.OverviewBtn);
            this.Controls.Add(this.QuizBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button QuizBtn;
        private System.Windows.Forms.Button OverviewBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Drawing.Printing.PrintDocument printDocumentFlashcard;
        private System.Windows.Forms.PrintDialog printDialogFlashcard;
    }
}

