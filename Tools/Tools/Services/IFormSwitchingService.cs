namespace Tools.Services;

internal interface IFormSwitchingService
{
    public void ShowForm<T>(Panel panel) where T : Form;
}
