namespace FileRenamerApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BrowseButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog { Multiselect = true };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
            FileListManager.LoadFiles(SelectedFilesListView, SelectedFilesCountLabel, openFileDialog.FileNames);
    }

    private void RenameButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(
            Microsoft.VisualBasic.Interaction.InputBox("Enter the number of occurrences:", "Number of Occurrences", "5"),
            out int occurrences))
            return;

        try
        {
            string[] filePaths = SelectedFilesListView.Items
                .Cast<ListViewItem>()
                .Select(i => (string)i.Tag!)
                .ToArray();

            var renamed = FileRenameService.RenameWithRandomNames(filePaths, occurrences);

            foreach (ListViewItem item in SelectedFilesListView.Items)
            {
                string oldPath = (string)item.Tag!;
                if (renamed.TryGetValue(oldPath, out string? newPath))
                {
                    item.SubItems[0].Text = Path.GetFileNameWithoutExtension(newPath);
                    item.SubItems[1].Text = Path.GetExtension(newPath);
                    item.Tag = newPath;
                }
                else
                {
                    ToastService.ShowToast($"❌ File does not exist: {oldPath}", 4000, false);
                }
            }

            ToastService.ShowToast("✅ Files renamed successfully!", 4000, true);
            FileListManager.ClearList(SelectedFilesListView, SelectedFilesCountLabel);
        }
        catch (Exception ex)
        {
            ToastService.ShowToast($"❌ Error renaming files: {ex.Message}", 6000, false);
        }
    }

    private void ChangeExtensionButton_Click(object sender, EventArgs e)
    {
        try
        {
            string newExtension = Microsoft.VisualBasic.Interaction.InputBox("Enter new extension:", "New Extension", "");

            if (string.IsNullOrEmpty(newExtension))
            {
                ToastService.ShowToast("❌ Please enter a valid extension.", 4000, false);
                return;
            }

            string[] filePaths = SelectedFilesListView.Items
                .Cast<ListViewItem>()
                .Select(i => (string)i.Tag!)
                .ToArray();

            var changed = FileRenameService.ChangeExtensions(filePaths, newExtension);

            foreach (ListViewItem item in SelectedFilesListView.Items)
            {
                string oldPath = (string)item.Tag!;
                if (changed.TryGetValue(oldPath, out string? newPath))
                {
                    item.SubItems[0].Text = Path.GetFileNameWithoutExtension(newPath);
                    item.SubItems[1].Text = Path.GetExtension(newPath);
                    item.Tag = newPath;
                }
                else
                {
                    ToastService.ShowToast($"❌ File does not exist: {oldPath}", 4000, false);
                }
            }

            ToastService.ShowToast("✅ File extensions changed successfully!", 4000, true);
            FileListManager.ClearList(SelectedFilesListView, SelectedFilesCountLabel);
        }
        catch (Exception ex)
        {
            ToastService.ShowToast($"❌ Error changing file extensions: {ex.Message}", 6000, false);
        }
    }

    private void SaveNamesToTxtButton_Click(object sender, EventArgs e)
    {
        try
        {
            bool saved = FileExportService.SaveNamesToTxt(SelectedFilesListView);
            if (SelectedFilesListView.Items.Count == 0)
                ToastService.ShowToast("ℹ️ No files selected.", 3000, false);
            else if (saved)
                ToastService.ShowToast("✅ File names saved successfully!", 4000, true);
        }
        catch (Exception ex)
        {
            ToastService.ShowToast($"❌ Error saving file names: {ex.Message}", 6000, false);
        }
    }

    private void lblAboutThisProgram_Click(object sender, EventArgs e)
    {
        ToastService.ShowToast("This program was made by Yutti Vong Chylong.\nDiscord: mranime", 5000, true);
    }

    private void btnRenameSingleBatch_Click(object sender, EventArgs e)
    {
        try
        {
            FileListManager.ClearList(SelectedFilesListView, SelectedFilesCountLabel);

            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Select files for batch rename"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            string[] files = dialog.FileNames;
            if (files.Length == 0)
            {
                ToastService.ShowToast("ℹ️ No files selected.", 3000, false);
                return;
            }

            FileRenameService.RenameSequential(files, Array.Empty<string>());
            ToastService.ShowToast($"✅ Renamed {files.Length} files successfully!", 4000, true);
            FileListManager.ClearList(SelectedFilesListView, SelectedFilesCountLabel);
        }
        catch (Exception ex)
        {
            ToastService.ShowToast($"❌ Error: {ex.Message}", 6000, false);
        }
    }

    private void btnCombinePartsSequentially_Click(object sender, EventArgs e)
    {
        try
        {
            FileListManager.ClearList(SelectedFilesListView, SelectedFilesCountLabel);

            OpenFileDialog dialog1 = new OpenFileDialog { Multiselect = true, Title = "Select files for Part 1" };
            if (dialog1.ShowDialog() != DialogResult.OK) return;
            string[] part1Files = dialog1.FileNames;

            OpenFileDialog dialog2 = new OpenFileDialog { Multiselect = true, Title = "Select files for Part 2" };
            if (dialog2.ShowDialog() != DialogResult.OK) return;
            string[] part2Files = dialog2.FileNames;

            if (part1Files.Length + part2Files.Length == 0)
            {
                ToastService.ShowToast("ℹ️ No files selected.", 3000, false);
                return;
            }

            FileRenameService.RenameSequential(part1Files, part2Files);
            ToastService.ShowToast($"✅ Renamed {part1Files.Length + part2Files.Length} files successfully!", 4000, true);
            FileListManager.ClearList(SelectedFilesListView, SelectedFilesCountLabel);
        }
        catch (Exception ex)
        {
            ToastService.ShowToast($"❌ Error: {ex.Message}", 6000, false);
        }
    }

    private void btnMergeAndRenameFolders_Click(object sender, EventArgs e)
    {
        try
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Select the root folder containing subfolders (01, 02, 03, ...)"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            FileRenameService.MergeAndRenameSubfolders(dialog.SelectedPath);
            ToastService.ShowToast("✅ Merge + rename complete!", 4000, true);
        }
        catch (Exception ex)
        {
            ToastService.ShowToast($"❌ Error: {ex.Message}", 6000, false);
        }
    }
}
