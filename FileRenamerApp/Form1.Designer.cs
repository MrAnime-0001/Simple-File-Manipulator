namespace FileRenamerApp
{
    partial class Form1
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
            SelectedFilesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SelectedFilesCountLabel = new Label();
            BrowseButton = new Button();
            RenameButton = new Button();
            ChangeExtensionButton = new Button();
            lblAboutThisProgram = new Label();
            SaveNamesToTxtButton = new Button();
            btnCombinePartsSequentially = new Button();
            btnMergeAndRenameFolders = new Button();
            SuspendLayout();
            // 
            // SelectedFilesListView
            // 
            SelectedFilesListView.BackColor = Color.FromArgb(30, 30, 30);
            SelectedFilesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            SelectedFilesListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedFilesListView.ForeColor = Color.White;
            SelectedFilesListView.FullRowSelect = true;
            SelectedFilesListView.GridLines = true;
            SelectedFilesListView.Location = new Point(12, 101);
            SelectedFilesListView.Name = "SelectedFilesListView";
            SelectedFilesListView.Size = new Size(280, 264);
            SelectedFilesListView.TabIndex = 0;
            SelectedFilesListView.UseCompatibleStateImageBehavior = false;
            SelectedFilesListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Extension";
            columnHeader2.Width = 80;
            // 
            // SelectedFilesCountLabel
            // 
            SelectedFilesCountLabel.AutoSize = true;
            SelectedFilesCountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedFilesCountLabel.ForeColor = Color.White;
            SelectedFilesCountLabel.Location = new Point(12, 61);
            SelectedFilesCountLabel.Name = "SelectedFilesCountLabel";
            SelectedFilesCountLabel.Size = new Size(146, 37);
            SelectedFilesCountLabel.TabIndex = 1;
            SelectedFilesCountLabel.Text = "Count: null";
            SelectedFilesCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.FromArgb(45, 45, 48);
            BrowseButton.FlatAppearance.BorderColor = Color.Gray;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseButton.ForeColor = Color.White;
            BrowseButton.Location = new Point(12, 12);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(280, 46);
            BrowseButton.TabIndex = 2;
            BrowseButton.Text = "BrowseButton";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // RenameButton
            // 
            RenameButton.BackColor = Color.FromArgb(45, 45, 48);
            RenameButton.FlatAppearance.BorderColor = Color.Gray;
            RenameButton.FlatStyle = FlatStyle.Flat;
            RenameButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RenameButton.ForeColor = Color.White;
            RenameButton.Location = new Point(12, 371);
            RenameButton.Name = "RenameButton";
            RenameButton.Size = new Size(280, 46);
            RenameButton.TabIndex = 3;
            RenameButton.Text = "Random File Rename";
            RenameButton.UseVisualStyleBackColor = false;
            RenameButton.Click += RenameButton_Click;
            // 
            // ChangeExtensionButton
            // 
            ChangeExtensionButton.BackColor = Color.FromArgb(45, 45, 48);
            ChangeExtensionButton.FlatAppearance.BorderColor = Color.Gray;
            ChangeExtensionButton.FlatStyle = FlatStyle.Flat;
            ChangeExtensionButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeExtensionButton.ForeColor = Color.White;
            ChangeExtensionButton.Location = new Point(12, 423);
            ChangeExtensionButton.Name = "ChangeExtensionButton";
            ChangeExtensionButton.Size = new Size(280, 46);
            ChangeExtensionButton.TabIndex = 4;
            ChangeExtensionButton.Text = "Change File Extension";
            ChangeExtensionButton.UseVisualStyleBackColor = false;
            ChangeExtensionButton.Click += ChangeExtensionButton_Click;
            // 
            // lblAboutThisProgram
            // 
            lblAboutThisProgram.AutoSize = true;
            lblAboutThisProgram.Cursor = Cursors.Hand;
            lblAboutThisProgram.ForeColor = SystemColors.Highlight;
            lblAboutThisProgram.Location = new Point(178, 628);
            lblAboutThisProgram.Name = "lblAboutThisProgram";
            lblAboutThisProgram.Size = new Size(114, 15);
            lblAboutThisProgram.TabIndex = 5;
            lblAboutThisProgram.Text = "About This Program";
            lblAboutThisProgram.Click += lblAboutThisProgram_Click;
            // 
            // SaveNamesToTxtButton
            // 
            SaveNamesToTxtButton.BackColor = Color.FromArgb(45, 45, 48);
            SaveNamesToTxtButton.FlatAppearance.BorderColor = Color.Gray;
            SaveNamesToTxtButton.FlatStyle = FlatStyle.Flat;
            SaveNamesToTxtButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SaveNamesToTxtButton.ForeColor = Color.White;
            SaveNamesToTxtButton.Location = new Point(12, 579);
            SaveNamesToTxtButton.Name = "SaveNamesToTxtButton";
            SaveNamesToTxtButton.Size = new Size(280, 46);
            SaveNamesToTxtButton.TabIndex = 6;
            SaveNamesToTxtButton.Text = "Save File Names to Text File";
            SaveNamesToTxtButton.UseVisualStyleBackColor = false;
            SaveNamesToTxtButton.Click += SaveNamesToTxtButton_Click;
            // 
            // btnCombinePartsSequentially
            // 
            btnCombinePartsSequentially.BackColor = Color.FromArgb(45, 45, 48);
            btnCombinePartsSequentially.FlatAppearance.BorderColor = Color.Gray;
            btnCombinePartsSequentially.FlatStyle = FlatStyle.Flat;
            btnCombinePartsSequentially.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCombinePartsSequentially.ForeColor = Color.White;
            btnCombinePartsSequentially.Location = new Point(12, 475);
            btnCombinePartsSequentially.Name = "btnCombinePartsSequentially";
            btnCombinePartsSequentially.Size = new Size(280, 46);
            btnCombinePartsSequentially.TabIndex = 7;
            btnCombinePartsSequentially.Text = "Sequential Merge";
            btnCombinePartsSequentially.UseVisualStyleBackColor = false;
            btnCombinePartsSequentially.Click += btnCombinePartsSequentially_Click;
            // 
            // btnMergeAndRenameFolders
            // 
            btnMergeAndRenameFolders.BackColor = Color.FromArgb(45, 45, 48);
            btnMergeAndRenameFolders.FlatAppearance.BorderColor = Color.Gray;
            btnMergeAndRenameFolders.FlatStyle = FlatStyle.Flat;
            btnMergeAndRenameFolders.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMergeAndRenameFolders.ForeColor = Color.White;
            btnMergeAndRenameFolders.Location = new Point(12, 527);
            btnMergeAndRenameFolders.Name = "btnMergeAndRenameFolders";
            btnMergeAndRenameFolders.Size = new Size(280, 46);
            btnMergeAndRenameFolders.TabIndex = 8;
            btnMergeAndRenameFolders.Text = "Merge And Rename Folders";
            btnMergeAndRenameFolders.UseVisualStyleBackColor = false;
            btnMergeAndRenameFolders.Click += btnMergeAndRenameFolders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(298, 645);
            Controls.Add(btnMergeAndRenameFolders);
            Controls.Add(btnCombinePartsSequentially);
            Controls.Add(SaveNamesToTxtButton);
            Controls.Add(lblAboutThisProgram);
            Controls.Add(ChangeExtensionButton);
            Controls.Add(RenameButton);
            Controls.Add(BrowseButton);
            Controls.Add(SelectedFilesCountLabel);
            Controls.Add(SelectedFilesListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple File Manipulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView SelectedFilesListView;
        private Label SelectedFilesCountLabel;
        private Button BrowseButton;
        private Button RenameButton;
        private Button ChangeExtensionButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lblAboutThisProgram;
        private Button SaveNamesToTxtButton;
        private Button btnCombinePartsSequentially;
        private Button btnMergeAndRenameFolders;
    }
}