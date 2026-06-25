using Microsoft.Extensions.DependencyInjection;

namespace Tools.Services;

internal class FormSwitchingService(IServiceProvider serviceProvider) : IFormSwitchingService
{
    private Form? _activeForm;

    public void ShowForm<T>(Panel panel) where T : Form
    {
        if (_activeForm is T)
        {
            return;
        }

        _activeForm?.Dispose();

        _activeForm = serviceProvider.GetRequiredService<T>();
        _activeForm.TopLevel = false;
        _activeForm.FormBorderStyle = FormBorderStyle.None;
        _activeForm.Dock = DockStyle.Fill;

        panel.Controls.Clear();
        panel.Controls.Add(_activeForm);

        _activeForm.Show();
    }
}
