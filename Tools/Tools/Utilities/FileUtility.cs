namespace Tools.Utilities;

public class FileUtility
{
    public static string Browse(string filter)
    {
        using OpenFileDialog openFileDialog = new()
        {
            Filter = filter
        };

        return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : "";
    }
}
