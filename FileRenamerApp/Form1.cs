using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace FileRenamerApp
{
    public partial class Form1 : Form
    {

        public static void ShowToast(string message, int duration = 2000, bool playSound = true)
        {
            Form toast = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false,
                TopMost = true,
                BackColor = Color.FromArgb(45, 45, 48),
                Size = new Size(250, 60),
                Opacity = 0.9
            };

            toast.Controls.Add(new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White
            });

            var screen = Screen.PrimaryScreen.WorkingArea;
            toast.Location = new Point(screen.Right - toast.Width - 10, screen.Bottom - toast.Height - 10);

            toast.Shown += async (s, e) =>
            {
                if (playSound)
                {
                    SystemSounds.Exclamation.Play(); // Default Windows notification sound
                }

                await Task.Delay(duration);
                toast.Close();
            };

            toast.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear existing items and columns in the list view
                SelectedFilesListView.Items.Clear();
                SelectedFilesListView.Columns.Clear();

                // Add headers for the name and extension
                SelectedFilesListView.View = View.Details;
                SelectedFilesListView.Columns.Add("File Name", 200);
                SelectedFilesListView.Columns.Add("Extension", 80);

                // Display the selected file paths in a list view
                foreach (string file in openFileDialog.FileNames)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string extension = Path.GetExtension(file);

                    ListViewItem item = new ListViewItem(new[] { fileName, extension });
                    item.Tag = file; // Store the full file path in the Tag property
                    SelectedFilesListView.Items.Add(item);
                }

                // Update the label to display the number of files selected
                SelectedFilesCountLabel.Text = $"{SelectedFilesListView.Items.Count} file(s) selected";
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            int numberOfOccurrences;
            if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter the number of occurrences:", "Number of Occurrences", "5"), out numberOfOccurrences))
            {
                try
                {
                    foreach (ListViewItem item in SelectedFilesListView.Items)
                    {
                        string filePath = (string)item.Tag; // Retrieve the full file path from the Tag property
                        string fileName = item.SubItems[0].Text; // File Name from the first column
                        string extension = item.SubItems[1].Text; // Extension from the second column

                        // Check if the file exists
                        if (File.Exists(filePath))
                        {
                            // Generate the randomized file name based on the specified number of occurrences
                            string separator = (numberOfOccurrences > 1) ? "-" : "";
                            string randomizedFileName = GenerateRandomizedFileName("", numberOfOccurrences, separator) + extension;

                            // Create the new file path with the directory and the randomized file name
                            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), randomizedFileName);

                            // Rename the file
                            File.Move(filePath, newFilePath);

                            // Update the displayed file path in the list view
                            item.SubItems[0].Text = Path.GetFileNameWithoutExtension(newFilePath);
                            item.SubItems[1].Text = Path.GetExtension(newFilePath);

                            // Update the stored file path in the Tag property
                            item.Tag = newFilePath;
                        }
                        else
                        {
                            // Handle the case where the file doesn't exist
                            ShowToast($"❌ File does not exist: {filePath}", 4000, false);
                        }
                    }

                    ShowToast("✅ Files renamed successfully!", 4000, true);

                    // Clear the list view after renaming
                    SelectedFilesListView.Items.Clear();
                    SelectedFilesCountLabel.Text = "0 file(s) selected";
                }
                catch (Exception ex)
                {
                    ShowToast($"❌ Error renaming files: {ex.Message}", 6000, false);
                }
            }
        }

        private void ChangeExtensionButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newExtension = Microsoft.VisualBasic.Interaction.InputBox("Enter new extension:", "New Extension", "");

                if (string.IsNullOrEmpty(newExtension))
                {
                    ShowToast("❌ Please enter a valid extension.", 4000, false);
                    return;
                }

                foreach (ListViewItem item in SelectedFilesListView.Items)
                {
                    string filePath = (string)item.Tag; // Retrieve the full file path from the Tag property
                    string fileName = item.SubItems[0].Text; // File Name from the first column

                    // Check if the file exists
                    if (File.Exists(filePath))
                    {
                        // Extract the file name without extension
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                        // Ensure the user entered a dot in the extension and correct it
                        string newExtensionWithDot = newExtension.StartsWith(".") ? newExtension : "." + newExtension;

                        // Create the new file path with the updated extension
                        string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), fileNameWithoutExtension + newExtensionWithDot);

                        try
                        {
                            // Rename the file with the updated extension
                            File.Move(filePath, newFilePath);

                            // Update the displayed file path and extension in the list view
                            item.SubItems[0].Text = Path.GetFileNameWithoutExtension(newFilePath);
                            item.SubItems[1].Text = newExtensionWithDot;
                            item.Tag = newFilePath;
                        }
                        catch (Exception ex)
                        {
                            ShowToast($"❌ Error renaming file {fileName}: {ex.Message}", 6000, false);
                        }
                    }
                    else
                    {
                        // Handle the case where the file doesn't exist
                        ShowToast($"❌ File does not exist: {filePath}", 4000, false);
                    }
                }

                ShowToast("✅ File extensions changed successfully!", 4000, true);

                // Clear the list view after changing extensions
                SelectedFilesListView.Items.Clear();
                SelectedFilesCountLabel.Text = "0 file(s) selected";
            }
            catch (Exception ex)
            {
                ShowToast($"❌ Error changing file extensions: {ex.Message}", 6000, false);
            }
        }

        private string GenerateRandomizedFileName(string baseName, int numberOfOccurrences, string separator)
        {
            Random random = new Random();

            // Generate the first set of 5 numbers in the range of 0 to 99999
            string randomizedNumber = random.Next(0, 100000).ToString("D5");

            // Generate the rest of the occurrences with sets of 5 numbers and separators
            randomizedNumber += string.Join("", Enumerable.Range(1, numberOfOccurrences - 1)
                .Select(_ => separator + random.Next(0, 100000).ToString("D5")));

            return baseName + randomizedNumber;
        }

        private void SaveNamesToTxtButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedFilesListView.Items.Count == 0)
                {
                    ShowToast("ℹ️ No files selected.", 3000, false);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files|*.txt";
                saveFileDialog.Title = "Save Names to Text File";
                saveFileDialog.FileName = "FileNamesList.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (ListViewItem item in SelectedFilesListView.Items)
                        {
                            string fileName = item.SubItems[0].Text; // File Name from the first column
                            writer.WriteLine(fileName);
                        }
                    }

                    ShowToast($"✅ File names saved to {filePath} successfully!", 4000, true);
                }
            }
            catch (Exception ex)
            {
                ShowToast($"❌ Error saving file names: {ex.Message}", 6000, false);
            }
        }

        private void lblAboutThisProgram_Click(object sender, EventArgs e)
        {
            ShowToast("This program was made by Yutti Vong Chylong.\nDiscord: mranime", 5000, true);
        }
    }
}