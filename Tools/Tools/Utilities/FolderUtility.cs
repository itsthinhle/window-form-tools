namespace Tools.Utilities;

internal class FolderUtility
{
    public static string BrowseFolder()
    {
        using FolderBrowserDialog folderBrowserDialog = new();
        return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : "";
    }
}
