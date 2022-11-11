namespace WindowsFormsAppLabb3
{
    partial class PracticeWordsForm
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
            this.UsersAnswer = new System.Windows.Forms.TextBox();
            this.WordToGuess = new System.Windows.Forms.TextBox();
            this.LanguageFrom = new System.Windows.Forms.Label();
            this.LanguageTo = new System.Windows.Forms.Label();
            this.PracticeWords = new System.Windows.Forms.Label();
            this.PracticeButtonInForm = new System.Windows.Forms.Button();
            this.PracticeListBox = new System.Windows.Forms.ListBox();
            this.CancelButtonPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersAnswer
            // 
            this.UsersAnswer.Location = new System.Drawing.Point(189, 145);
            this.UsersAnswer.Name = "UsersAnswer";
            this.UsersAnswer.Size = new System.Drawing.Size(188, 23);
            this.UsersAnswer.TabIndex = 0;
            // 
            // WordToGuess
            // 
            this.WordToGuess.Location = new System.Drawing.Point(189, 71);
            this.WordToGuess.Name = "WordToGuess";
            this.WordToGuess.Size = new System.Drawing.Size(188, 23);
            this.WordToGuess.TabIndex = 1;
            // 
            // LanguageFrom
            // 
            this.LanguageFrom.AutoSize = true;
            this.LanguageFrom.Location = new System.Drawing.Point(231, 53);
            this.LanguageFrom.Name = "LanguageFrom";
            this.LanguageFrom.Size = new System.Drawing.Size(94, 15);
            this.LanguageFrom.TabIndex = 2;
            this.LanguageFrom.Text = "LanguangeFrom";
            // 
            // LanguageTo
            // 
            this.LanguageTo.AutoSize = true;
            this.LanguageTo.Location = new System.Drawing.Point(240, 127);
            this.LanguageTo.Name = "LanguageTo";
            this.LanguageTo.Size = new System.Drawing.Size(71, 15);
            this.LanguageTo.TabIndex = 3;
            this.LanguageTo.Text = "LanguageTo";
            // 
            // PracticeWords
            // 
            this.PracticeWords.AutoSize = true;
            this.PracticeWords.Location = new System.Drawing.Point(134, 9);
            this.PracticeWords.Name = "PracticeWords";
            this.PracticeWords.Size = new System.Drawing.Size(116, 15);
            this.PracticeWords.TabIndex = 4;
            this.PracticeWords.Text = "Practice some words";
            // 
            // PracticeButtonInForm
            // 
            this.PracticeButtonInForm.Location = new System.Drawing.Point(173, 191);
            this.PracticeButtonInForm.Name = "PracticeButtonInForm";
            this.PracticeButtonInForm.Size = new System.Drawing.Size(101, 47);
            this.PracticeButtonInForm.TabIndex = 5;
            this.PracticeButtonInForm.Text = "Practice";
            this.PracticeButtonInForm.UseVisualStyleBackColor = true;
            this.PracticeButtonInForm.Click += new System.EventHandler(this.GuessWordPratice);
            // 
            // PracticeListBox
            // 
            this.PracticeListBox.FormattingEnabled = true;
            this.PracticeListBox.ItemHeight = 15;
            this.PracticeListBox.Location = new System.Drawing.Point(12, 53);
            this.PracticeListBox.Name = "PracticeListBox";
            this.PracticeListBox.Size = new System.Drawing.Size(120, 169);
            this.PracticeListBox.TabIndex = 6;
            this.PracticeListBox.SelectedIndexChanged += new System.EventHandler(this.PracticeListBox_SelectedIndexChanged);
            // 
            // CancelButtonPractice
            // 
            this.CancelButtonPractice.Location = new System.Drawing.Point(292, 191);
            this.CancelButtonPractice.Name = "CancelButtonPractice";
            this.CancelButtonPractice.Size = new System.Drawing.Size(101, 47);
            this.CancelButtonPractice.TabIndex = 7;
            this.CancelButtonPractice.Text = "Cancel";
            this.CancelButtonPractice.UseVisualStyleBackColor = true;
            this.CancelButtonPractice.Click += new System.EventHandler(this.CancelButtonPractice_Click);
            // 
            // PracticeWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 298);
            this.Controls.Add(this.CancelButtonPractice);
            this.Controls.Add(this.PracticeListBox);
            this.Controls.Add(this.PracticeButtonInForm);
            this.Controls.Add(this.PracticeWords);
            this.Controls.Add(this.LanguageTo);
            this.Controls.Add(this.LanguageFrom);
            this.Controls.Add(this.WordToGuess);
            this.Controls.Add(this.UsersAnswer);
            this.Name = "PracticeWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PracticeWordsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsersAnswer;
        private TextBox WordToGuess;
        private Label LanguageFrom;
        private Label LanguageTo;
        private Label PracticeWords;
        private Button PracticeButtonInForm;
        private ListBox PracticeListBox;
        private Button CancelButtonPractice;
    }
}