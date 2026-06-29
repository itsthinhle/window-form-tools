namespace Tools.ControlLibrary.Texts;

internal class AppRichTextBox : RichTextBox
{
    public AppRichTextBox()
    {
        Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(0);
    }
}
