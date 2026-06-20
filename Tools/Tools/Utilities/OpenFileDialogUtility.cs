namespace Tools.Utilities;

internal class OpenFileDialogUtility
{
    public static string BuildFilterForOpenFileDialog(
        string description,
        IEnumerable<string> fileExtensions,
        bool includeAllFiles = false)
    {
        // Pattern: "Description ({pattern})|{pattern}|All Files (*.*)|*.*"
        // Example: "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*"
        string pattern = string.Join(";", fileExtensions.Select(ext => $"*{ext}"));
        return includeAllFiles
            ? $"{description} ({pattern})|{pattern}|All Files (*.*)|*.*"
            : $"{description} ({pattern})|{pattern}";
    }
}
