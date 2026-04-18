namespace FileRenamerApp;

public static class FileExportService
{
    public static bool SaveNamesToTxt(ListView listView)
    {
        if (listView.Items.Count == 0)
            return false;

        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            Filter = "Text Files|*.txt",
            Title = "Save Names to Text File",
            FileName = "FileNamesList.txt"
        };

        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return false;

        using StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
        foreach (ListViewItem item in listView.Items)
            writer.WriteLine(item.SubItems[0].Text);

        return true;
    }
}
