namespace Tools.ControlLibrary.Buttons;

internal class AppSideBarMenuButton : Button
{
    public AppSideBarMenuButton()
    {
        Cursor = Cursors.Hand;
        FlatAppearance.BorderSize = 0;
        FlatStyle = FlatStyle.Flat;
        ForeColor = Color.White;
        Margin = new Padding(0);
        Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
    }
}
