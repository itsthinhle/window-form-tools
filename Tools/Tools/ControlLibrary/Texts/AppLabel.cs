namespace Tools.ControlLibrary.Texts;

internal class AppLabel : Label
{
    public AppLabel()
    {
        Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Margin = new Padding(0, 0, 0, 9);
    }
}
