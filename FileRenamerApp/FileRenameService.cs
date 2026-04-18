namespace FileRenamerApp;

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

        foreach (string filePath in part1Files)
        {
            if (!File.Exists(filePath)) continue;

            string directory = Path.GetDirectoryName(filePath)!;
            string extension = Path.GetExtension(filePath);
            string newFilePath = Path.Combine(directory, counter.ToString("D" + digits) + extension);

            File.Move(filePath, newFilePath);
            counter++;
        }

        foreach (string filePath in part2Files)
        {
            if (!File.Exists(filePath)) continue;

            string directory = Path.GetDirectoryName(filePath)!;
            string extension = Path.GetExtension(filePath);
            string newFilePath = Path.Combine(directory, counter.ToString("D" + digits) + extension);

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

        string outputFolder = Path.Combine(
            Path.GetDirectoryName(rootFolder)!,
            Path.GetFileName(rootFolder) + "_PhotoMerged"
        );

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
            string newFilePath = Path.Combine(outputFolder, counter.ToString("D" + digits) + extension);
            File.Copy(imagePath, newFilePath, true);
            counter++;
        }
    }

    public static string GenerateRandomName(string baseName, int occurrences, string separator)
    {
        Random random = new Random();
        string first = random.Next(0, 100000).ToString("D5");
        string rest = string.Join("", Enumerable.Range(1, occurrences - 1)
            .Select(_ => separator + random.Next(0, 100000).ToString("D5")));
        return baseName + first + rest;
    }

    public static Dictionary<string, string> RenameWithRandomNames(string[] filePaths, int occurrences)
    {
        string separator = occurrences > 1 ? "-" : "";
        var results = new Dictionary<string, string>();

        foreach (string filePath in filePaths)
        {
            if (!File.Exists(filePath)) continue;

            string extension = Path.GetExtension(filePath);
            string newFilePath = Path.Combine(
                Path.GetDirectoryName(filePath)!,
                GenerateRandomName("", occurrences, separator) + extension
            );

            File.Move(filePath, newFilePath);
            results[filePath] = newFilePath;
        }

        return results;
    }

    public static Dictionary<string, string> ChangeExtensions(string[] filePaths, string newExtension)
    {
        string newExtWithDot = newExtension.StartsWith(".") ? newExtension : "." + newExtension;
        var results = new Dictionary<string, string>();

        foreach (string filePath in filePaths)
        {
            if (!File.Exists(filePath)) continue;

            string newFilePath = Path.Combine(
                Path.GetDirectoryName(filePath)!,
                Path.GetFileNameWithoutExtension(filePath) + newExtWithDot
            );

            File.Move(filePath, newFilePath);
            results[filePath] = newFilePath;
        }

        return results;
    }
}
