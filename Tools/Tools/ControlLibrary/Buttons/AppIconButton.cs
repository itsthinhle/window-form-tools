namespace Tools.ControlLibrary.Buttons;

internal class AppIconButton : Button
{
    public AppIconButton()
    {
        BackColor = Color.Transparent;
        BackgroundImageLayout = ImageLayout.Stretch;
        Cursor = Cursors.Hand;
        FlatAppearance.BorderSize = 0;
        FlatAppearance.MouseDownBackColor = Color.Transparent;
        FlatAppearance.MouseOverBackColor = Color.Transparent;
        FlatStyle = FlatStyle.Flat;
        Margin = new Padding(0);
        Size = new Size(31, 31);
        Text = "";
    }
}
