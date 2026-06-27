using Tools.Models.AppSettings;

namespace Tools.Services;

internal interface IAppSettingsService
{
    AppSettings AppSettings { get; }

    public void Load();

    public void Save();
}
