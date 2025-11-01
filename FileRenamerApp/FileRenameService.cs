public static class FileRenameService
{

    public static void RenameSingleBatch(string[] files)
    {
        RenameSequential(files, Array.Empty<string>());
    }

    public static void RenameSequential(string[] part1Files, string[] part2Files)
    {
        int totalFiles = part1Files.Length + part2Files.Length;

        if (totalFiles == 0)
            return;

        int digits = totalFiles.ToString().Length;
        int counter = 1;

        // Rename Part 1
        foreach (string filePath in part1Files)
        {
            if (!File.Exists(filePath)) continue;

            string directory = Path.GetDirectoryName(filePath);
            string extension = Path.GetExtension(filePath);
            string newFileName = counter.ToString("D" + digits) + extension;
            string newFilePath = Path.Combine(directory, newFileName);

            File.Move(filePath, newFilePath);
            counter++;
        }

        // Rename Part 2
        foreach (string filePath in part2Files)
        {
            if (!File.Exists(filePath)) continue;

            string directory = Path.GetDirectoryName(filePath);
            string extension = Path.GetExtension(filePath);
            string newFileName = counter.ToString("D" + digits) + extension;
            string newFilePath = Path.Combine(directory, newFileName);

            File.Move(filePath, newFilePath);
            counter++;
        }
    }

    public static void MergeAndRenameSubfolders(string rootFolder)
    {
        string[] subFolders = Directory.GetDirectories(rootFolder)
                                       .OrderBy(f => f)
                                       .ToArray();

        if (subFolders.Length == 0)
            return;

        string parentDir = Path.GetDirectoryName(rootFolder);
        string rootName = Path.GetFileName(rootFolder);
        string outputFolder = Path.Combine(parentDir, rootName + "_PhotoMerged");

        if (!Directory.Exists(outputFolder))
            Directory.CreateDirectory(outputFolder);

        string[] supportedExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp" };

        List<string> allImages = new List<string>();

        foreach (var folder in subFolders)
        {
            allImages.AddRange(
                Directory.GetFiles(folder)
                .Where(f => supportedExtensions.Contains(Path.GetExtension(f).ToLower()))
            );
        }

        if (allImages.Count == 0)
            return;

        int digits = allImages.Count.ToString().Length;
        int counter = 1;

        foreach (var imagePath in allImages)
        {
            string extension = Path.GetExtension(imagePath);
            string newFileName = counter.ToString("D" + digits) + extension;
            string newFilePath = Path.Combine(outputFolder, newFileName);

            File.Copy(imagePath, newFilePath, true);
            counter++;
        }
    }
}
