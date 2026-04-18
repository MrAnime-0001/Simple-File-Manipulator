namespace FileRenamerApp;

public static class FileListManager
{
    public static void LoadFiles(ListView listView, Label countLabel, string[] filePaths)
    {
        listView.Items.Clear();
        listView.Columns.Clear();
        listView.View = View.Details;
        listView.Columns.Add("File Name", 200);
        listView.Columns.Add("Extension", 80);

        foreach (string file in filePaths)
        {
            ListViewItem item = new ListViewItem(new[]
            {
                Path.GetFileNameWithoutExtension(file),
                Path.GetExtension(file)
            });
            item.Tag = file;
            listView.Items.Add(item);
        }

        countLabel.Text = $"{listView.Items.Count} file(s) selected";
    }

    public static void ClearList(ListView listView, Label countLabel)
    {
        listView.Items.Clear();
        countLabel.Text = "0 file(s) selected";
    }
}
