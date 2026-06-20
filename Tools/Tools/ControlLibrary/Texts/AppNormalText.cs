namespace Tools.ControlLibrary.Texts;

internal class AppNormalText : Label
{
    public AppNormalText()
    {
        Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(0, 0, 0, 9);
    }
}
