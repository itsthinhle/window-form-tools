namespace Tools.ControlLibrary.Buttons;

internal class AppPrimaryButton : Button
{
    public AppPrimaryButton()
    {
        BackColor = Color.Black;
        Cursor = Cursors.Hand;
        FlatAppearance.MouseDownBackColor = Color.Black;
        FlatAppearance.MouseOverBackColor = Color.Black;
        FlatStyle = FlatStyle.Flat;
        Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ForeColor = Color.White;
        Margin = new Padding(0);
        Size = new Size(200, 45);
    }
}
