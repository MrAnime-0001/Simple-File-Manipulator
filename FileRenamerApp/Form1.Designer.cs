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
            menuStrip1 = new MenuStrip();
            tsmiRenameService = new ToolStripMenuItem();
            btnCombinePartsSequentially = new ToolStripMenuItem();
            btnMergeAndRenameFolders = new ToolStripMenuItem();
            btnRenameSingleBatch = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            SelectedFilesListView.Location = new Point(12, 116);
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
            SelectedFilesCountLabel.Location = new Point(12, 76);
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
            BrowseButton.Location = new Point(12, 27);
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
            RenameButton.Location = new Point(12, 386);
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
            ChangeExtensionButton.Location = new Point(12, 438);
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
            lblAboutThisProgram.Location = new Point(178, 539);
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
            SaveNamesToTxtButton.Location = new Point(12, 490);
            SaveNamesToTxtButton.Name = "SaveNamesToTxtButton";
            SaveNamesToTxtButton.Size = new Size(280, 46);
            SaveNamesToTxtButton.TabIndex = 6;
            SaveNamesToTxtButton.Text = "Save File Names to Text File";
            SaveNamesToTxtButton.UseVisualStyleBackColor = false;
            SaveNamesToTxtButton.Click += SaveNamesToTxtButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiRenameService });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(304, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRenameService
            // 
            tsmiRenameService.DropDownItems.AddRange(new ToolStripItem[] { btnRenameSingleBatch, btnCombinePartsSequentially, btnMergeAndRenameFolders });
            tsmiRenameService.Name = "tsmiRenameService";
            tsmiRenameService.Size = new Size(99, 20);
            tsmiRenameService.Text = "RenameService";
            // 
            // btnCombinePartsSequentially
            // 
            btnCombinePartsSequentially.Name = "btnCombinePartsSequentially";
            btnCombinePartsSequentially.Size = new Size(220, 22);
            btnCombinePartsSequentially.Text = "Sequential Merge";
            btnCombinePartsSequentially.Click += btnCombinePartsSequentially_Click;
            // 
            // btnMergeAndRenameFolders
            // 
            btnMergeAndRenameFolders.Name = "btnMergeAndRenameFolders";
            btnMergeAndRenameFolders.Size = new Size(220, 22);
            btnMergeAndRenameFolders.Text = "Merge And Rename Folders";
            btnMergeAndRenameFolders.Click += btnMergeAndRenameFolders_Click;
            // 
            // btnRenameSingleBatch
            // 
            btnRenameSingleBatch.Name = "btnRenameSingleBatch";
            btnRenameSingleBatch.Size = new Size(220, 22);
            btnRenameSingleBatch.Text = "Rename Single Batch";
            btnRenameSingleBatch.Click += btnRenameSingleBatch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(304, 562);
            Controls.Add(SaveNamesToTxtButton);
            Controls.Add(lblAboutThisProgram);
            Controls.Add(ChangeExtensionButton);
            Controls.Add(RenameButton);
            Controls.Add(BrowseButton);
            Controls.Add(SelectedFilesCountLabel);
            Controls.Add(SelectedFilesListView);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple File Manipulator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiRenameService;
        private ToolStripMenuItem btnCombinePartsSequentially;
        private ToolStripMenuItem btnMergeAndRenameFolders;
        private ToolStripMenuItem btnRenameSingleBatch;
    }
}