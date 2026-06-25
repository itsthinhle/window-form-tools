using Tools.Models.Settings;

namespace Tools.Services;

internal interface IFormSettingsService
{
    AppSettings AppSettings { get; }

    public void Load();

    public void Save();
}
