using System.Text.Json;

namespace LabConfig;

public static class SettingsStore
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true
    };

    public static AppSettings Load(string path)
    {
        if (!File.Exists(path))
            return AppSettings.Default;

        try
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<AppSettings>(json, JsonOptions) ?? AppSettings.Default;
        }
        catch (JsonException)
        {
            return AppSettings.Default;
        }
    }

    public static void Save(string path, AppSettings settings)
    {
        var json = JsonSerializer.Serialize(settings, JsonOptions);
        File.WriteAllText(path, json);
    }
}
