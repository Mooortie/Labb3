namespace WindowsFormsAppLabb3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FoundList = new System.Windows.Forms.ListBox();
            this.NewList = new System.Windows.Forms.Button();
            this.ListInfo = new System.Windows.Forms.Label();
            this.AddWords = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.ViewInformation = new System.Windows.Forms.ListView();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoundList
            // 
            this.FoundList.FormattingEnabled = true;
            this.FoundList.ItemHeight = 15;
            this.FoundList.Location = new System.Drawing.Point(12, 93);
            this.FoundList.Name = "FoundList";
            this.FoundList.Size = new System.Drawing.Size(111, 169);
            this.FoundList.TabIndex = 0;
            this.FoundList.SelectedIndexChanged += new System.EventHandler(this.FoundList_SelectedIndexChanged);
            // 
            // NewList
            // 
            this.NewList.Location = new System.Drawing.Point(12, 25);
            this.NewList.Name = "NewList";
            this.NewList.Size = new System.Drawing.Size(84, 29);
            this.NewList.TabIndex = 2;
            this.NewList.Text = "New List";
            this.NewList.UseVisualStyleBackColor = true;
            this.NewList.Click += new System.EventHandler(this.NewList_Click);
            // 
            // ListInfo
            // 
            this.ListInfo.AutoSize = true;
            this.ListInfo.Location = new System.Drawing.Point(12, 75);
            this.ListInfo.Name = "ListInfo";
            this.ListInfo.Size = new System.Drawing.Size(65, 15);
            this.ListInfo.TabIndex = 3;
            this.ListInfo.Text = "Select a list";
            // 
            // AddWords
            // 
            this.AddWords.Location = new System.Drawing.Point(128, 25);
            this.AddWords.Name = "AddWords";
            this.AddWords.Size = new System.Drawing.Size(84, 29);
            this.AddWords.TabIndex = 4;
            this.AddWords.Text = "Add Words";
            this.AddWords.UseVisualStyleBackColor = true;
            this.AddWords.Click += new System.EventHandler(this.AddWords_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(232, 25);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(84, 29);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(338, 25);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(84, 29);
            this.Count.TabIndex = 6;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // ViewInformation
            // 
            this.ViewInformation.Location = new System.Drawing.Point(149, 93);
            this.ViewInformation.Name = "ViewInformation";
            this.ViewInformation.Size = new System.Drawing.Size(377, 169);
            this.ViewInformation.TabIndex = 9;
            this.ViewInformation.UseCompatibleStateImageBehavior = false;
            // 
            // PracticeButton
            // 
            this.PracticeButton.Location = new System.Drawing.Point(442, 25);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(84, 29);
            this.PracticeButton.TabIndex = 10;
            this.PracticeButton.Text = "Practice";
            this.PracticeButton.UseVisualStyleBackColor = true;
            this.PracticeButton.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 293);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.ViewInformation);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.AddWords);
            this.Controls.Add(this.ListInfo);
            this.Controls.Add(this.NewList);
            this.Controls.Add(this.FoundList);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox FoundList;
        private Button NewList;
        private Label ListInfo;
        private Button AddWords;
        private Button Remove;
        private Button Count;
        private ListView ViewInformation;
        private Button PracticeButton;
    }
}