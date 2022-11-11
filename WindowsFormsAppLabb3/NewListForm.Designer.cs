namespace WindowsFormsAppLabb3
{
    partial class NewListForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CreateNewList = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.CloseNewList = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.LanguageTwo = new System.Windows.Forms.Label();
            this.LanguageOne = new System.Windows.Forms.Label();
            this.LanguageTextboxOne = new System.Windows.Forms.TextBox();
            this.LanguageTextboxTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(21, 165);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveNewList);
            // 
            // CreateNewList
            // 
            this.CreateNewList.AutoSize = true;
            this.CreateNewList.Location = new System.Drawing.Point(62, 9);
            this.CreateNewList.Name = "CreateNewList";
            this.CreateNewList.Size = new System.Drawing.Size(93, 15);
            this.CreateNewList.TabIndex = 1;
            this.CreateNewList.Text = "Create a new list";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(26, 51);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(197, 23);
            this.FileNameTextBox.TabIndex = 2;
            this.FileNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // CloseNewList
            // 
            this.CloseNewList.Location = new System.Drawing.Point(136, 165);
            this.CloseNewList.Name = "CloseNewList";
            this.CloseNewList.Size = new System.Drawing.Size(75, 23);
            this.CloseNewList.TabIndex = 9;
            this.CloseNewList.Text = "Close";
            this.CloseNewList.UseVisualStyleBackColor = true;
            this.CloseNewList.Click += new System.EventHandler(this.CloseNewList_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(81, 33);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(57, 15);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "FileName";
            // 
            // LanguageTwo
            // 
            this.LanguageTwo.AutoSize = true;
            this.LanguageTwo.Location = new System.Drawing.Point(122, 88);
            this.LanguageTwo.Name = "LanguageTwo";
            this.LanguageTwo.Size = new System.Drawing.Size(101, 15);
            this.LanguageTwo.TabIndex = 4;
            this.LanguageTwo.Text = "Second Language";
            // 
            // LanguageOne
            // 
            this.LanguageOne.AutoSize = true;
            this.LanguageOne.Location = new System.Drawing.Point(12, 88);
            this.LanguageOne.Name = "LanguageOne";
            this.LanguageOne.Size = new System.Drawing.Size(84, 15);
            this.LanguageOne.TabIndex = 5;
            this.LanguageOne.Text = "First Language";
            // 
            // LanguageTextboxOne
            // 
            this.LanguageTextboxOne.Location = new System.Drawing.Point(12, 115);
            this.LanguageTextboxOne.Name = "LanguageTextboxOne";
            this.LanguageTextboxOne.Size = new System.Drawing.Size(100, 23);
            this.LanguageTextboxOne.TabIndex = 6;
            // 
            // LanguageTextboxTwo
            // 
            this.LanguageTextboxTwo.Location = new System.Drawing.Point(123, 115);
            this.LanguageTextboxTwo.Name = "LanguageTextboxTwo";
            this.LanguageTextboxTwo.Size = new System.Drawing.Size(100, 23);
            this.LanguageTextboxTwo.TabIndex = 7;
            // 
            // NewListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 224);
            this.Controls.Add(this.LanguageTextboxTwo);
            this.Controls.Add(this.LanguageTextboxOne);
            this.Controls.Add(this.LanguageOne);
            this.Controls.Add(this.LanguageTwo);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.CloseNewList);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.CreateNewList);
            this.Controls.Add(this.SaveButton);
            this.Name = "NewListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveButton;
        private Label CreateNewList;
        private TextBox FileNameTextBox;
        private Button CloseNewList;
        private Label FileName;
        private Label LanguageTwo;
        private Label LanguageOne;
        private TextBox LanguageTextboxOne;
        private TextBox LanguageTextboxTwo;
    }
}