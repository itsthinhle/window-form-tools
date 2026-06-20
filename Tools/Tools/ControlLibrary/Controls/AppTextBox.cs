namespace Tools.ControlLibrary.Controls;

internal class AppTextBox : TextBox
{
    public AppTextBox()
    {
        Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(0);
    }
}
