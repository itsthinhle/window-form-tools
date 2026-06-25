using System.Text.Json;
using Tools.Models.Settings;
using Tools.Models.VideoTrimming;

namespace Tools.Services;

internal class FormSettingsService : IFormSettingsService
{
    private readonly string _settingsFilePath =
        Path.Combine(Application.StartupPath, "Settings.json");

    private static readonly JsonSerializerOptions _jsonWriteOptions = new()
    {
        WriteIndented = true
    };

    public AppSettings AppSettings { get; private set; } = new();

    public void Load()
    {
        if (!File.Exists(_settingsFilePath))
        {
            Save();
            return;
        }

        string json = File.ReadAllText(_settingsFilePath);

        AppSettings = JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
    }

    public void Save()
    {
        string json = JsonSerializer.Serialize(AppSettings, _jsonWriteOptions);
        File.WriteAllText(_settingsFilePath, json);
    }
}
