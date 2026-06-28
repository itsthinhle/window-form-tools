namespace Tools.Utilities;

internal class FolderUtility
{
    public static string Browse()
    {
        using FolderBrowserDialog folderBrowserDialog = new();
        return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : "";
    }
}
