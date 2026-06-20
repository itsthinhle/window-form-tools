namespace Tools.ControlLibrary.Buttons;

internal class AppSecondaryButton : Button
{
    public AppSecondaryButton()
    {
        BackColor = Color.White;
        Cursor = Cursors.Hand;
        FlatAppearance.BorderColor = Color.LightGray;
        FlatAppearance.MouseDownBackColor = Color.White;
        FlatAppearance.MouseOverBackColor = Color.White;
        FlatStyle = FlatStyle.Flat;
        Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ForeColor = Color.Black;
        Margin = new Padding(0);
        Size = new Size(200, 45);
    }
}
