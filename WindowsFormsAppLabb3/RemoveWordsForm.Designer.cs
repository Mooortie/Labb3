namespace WindowsFormsAppLabb3
{
    partial class RemoveWordsForm
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
            this.listboxRemoveWords = new System.Windows.Forms.ListBox();
            this.listviewRemoveWord = new System.Windows.Forms.ListView();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CanelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxRemoveWords
            // 
            this.listboxRemoveWords.FormattingEnabled = true;
            this.listboxRemoveWords.ItemHeight = 15;
            this.listboxRemoveWords.Location = new System.Drawing.Point(12, 25);
            this.listboxRemoveWords.Name = "listboxRemoveWords";
            this.listboxRemoveWords.Size = new System.Drawing.Size(120, 169);
            this.listboxRemoveWords.TabIndex = 0;
            this.listboxRemoveWords.SelectedIndexChanged += new System.EventHandler(this.listboxRemoveWords_SelectedIndexChanged);
            // 
            // listviewRemoveWord
            // 
            this.listviewRemoveWord.Location = new System.Drawing.Point(176, 25);
            this.listviewRemoveWord.Name = "listviewRemoveWord";
            this.listviewRemoveWord.Size = new System.Drawing.Size(175, 169);
            this.listviewRemoveWord.TabIndex = 1;
            this.listviewRemoveWord.UseCompatibleStateImageBehavior = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(379, 25);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 59);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CanelButton
            // 
            this.CanelButton.Location = new System.Drawing.Point(379, 103);
            this.CanelButton.Name = "CanelButton";
            this.CanelButton.Size = new System.Drawing.Size(75, 60);
            this.CanelButton.TabIndex = 3;
            this.CanelButton.Text = "Cancel";
            this.CanelButton.UseVisualStyleBackColor = true;
            this.CanelButton.Click += new System.EventHandler(this.CanelButton_Click);
            // 
            // RemoveWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 216);
            this.Controls.Add(this.CanelButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.listviewRemoveWord);
            this.Controls.Add(this.listboxRemoveWords);
            this.Name = "RemoveWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RemoveWordsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listboxRemoveWords;
        private ListView listviewRemoveWord;
        private Button RemoveButton;
        private Button CanelButton;
    }
}