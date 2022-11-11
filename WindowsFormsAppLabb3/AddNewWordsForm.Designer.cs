namespace WindowsFormsAppLabb3
{
    partial class AddNewWordsForm
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
            this.WordsAddLabel = new System.Windows.Forms.Label();
            this.AddWordsListbox = new System.Windows.Forms.ListBox();
            this.AddLanguageOne = new System.Windows.Forms.Label();
            this.AddLanguageTwo = new System.Windows.Forms.Label();
            this.AddLanguageThree = new System.Windows.Forms.Label();
            this.firstWord = new System.Windows.Forms.TextBox();
            this.secondWord = new System.Windows.Forms.TextBox();
            this.thirdWord = new System.Windows.Forms.TextBox();
            this.ADDBUTTON = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordsAddLabel
            // 
            this.WordsAddLabel.AutoSize = true;
            this.WordsAddLabel.Location = new System.Drawing.Point(174, 9);
            this.WordsAddLabel.Name = "WordsAddLabel";
            this.WordsAddLabel.Size = new System.Drawing.Size(142, 15);
            this.WordsAddLabel.TabIndex = 0;
            this.WordsAddLabel.Text = "Add words to selected list";
            // 
            // AddWordsListbox
            // 
            this.AddWordsListbox.FormattingEnabled = true;
            this.AddWordsListbox.ItemHeight = 15;
            this.AddWordsListbox.Location = new System.Drawing.Point(12, 52);
            this.AddWordsListbox.Name = "AddWordsListbox";
            this.AddWordsListbox.Size = new System.Drawing.Size(120, 184);
            this.AddWordsListbox.TabIndex = 1;
            this.AddWordsListbox.SelectedIndexChanged += new System.EventHandler(this.AddWordsListbox_SelectedIndexChanged_1);
            // 
            // AddLanguageOne
            // 
            this.AddLanguageOne.AutoSize = true;
            this.AddLanguageOne.Location = new System.Drawing.Point(167, 52);
            this.AddLanguageOne.Name = "AddLanguageOne";
            this.AddLanguageOne.Size = new System.Drawing.Size(59, 15);
            this.AddLanguageOne.TabIndex = 2;
            this.AddLanguageOne.Text = "Language";
            // 
            // AddLanguageTwo
            // 
            this.AddLanguageTwo.AutoSize = true;
            this.AddLanguageTwo.Location = new System.Drawing.Point(267, 52);
            this.AddLanguageTwo.Name = "AddLanguageTwo";
            this.AddLanguageTwo.Size = new System.Drawing.Size(59, 15);
            this.AddLanguageTwo.TabIndex = 3;
            this.AddLanguageTwo.Text = "Language";
            // 
            // AddLanguageThree
            // 
            this.AddLanguageThree.AutoSize = true;
            this.AddLanguageThree.Location = new System.Drawing.Point(375, 52);
            this.AddLanguageThree.Name = "AddLanguageThree";
            this.AddLanguageThree.Size = new System.Drawing.Size(59, 15);
            this.AddLanguageThree.TabIndex = 4;
            this.AddLanguageThree.Text = "Language";
            // 
            // firstWord
            // 
            this.firstWord.Location = new System.Drawing.Point(138, 95);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(100, 23);
            this.firstWord.TabIndex = 5;
            // 
            // secondWord
            // 
            this.secondWord.Location = new System.Drawing.Point(244, 95);
            this.secondWord.Name = "secondWord";
            this.secondWord.Size = new System.Drawing.Size(100, 23);
            this.secondWord.TabIndex = 6;
            // 
            // thirdWord
            // 
            this.thirdWord.Location = new System.Drawing.Point(350, 95);
            this.thirdWord.Name = "thirdWord";
            this.thirdWord.Size = new System.Drawing.Size(100, 23);
            this.thirdWord.TabIndex = 7;
            // 
            // ADDBUTTON
            // 
            this.ADDBUTTON.Location = new System.Drawing.Point(138, 145);
            this.ADDBUTTON.Name = "ADDBUTTON";
            this.ADDBUTTON.Size = new System.Drawing.Size(149, 91);
            this.ADDBUTTON.TabIndex = 8;
            this.ADDBUTTON.Text = "ADD";
            this.ADDBUTTON.UseVisualStyleBackColor = true;
            this.ADDBUTTON.Click += new System.EventHandler(this.ADDBUTTON_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(301, 145);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(149, 91);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNewWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 260);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ADDBUTTON);
            this.Controls.Add(this.thirdWord);
            this.Controls.Add(this.secondWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.AddLanguageThree);
            this.Controls.Add(this.AddLanguageTwo);
            this.Controls.Add(this.AddLanguageOne);
            this.Controls.Add(this.AddWordsListbox);
            this.Controls.Add(this.WordsAddLabel);
            this.Name = "AddNewWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewWordsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddWords;
        private Label WordsAddLabel;
        private ListBox AddWordsListbox;
        private Label AddLanguageOne;
        private Label AddLanguageTwo;
        private Label AddLanguageThree;
        private TextBox firstWord;
        private TextBox secondWord;
        private TextBox thirdWord;
        private Button ADDBUTTON;
        private Button CancelButton;
    }
}