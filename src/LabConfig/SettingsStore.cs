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
            // v1.1.0-dev: regressão conhecida — uma leitura inválida passa a sobrescrever a origem.
            Save(path, AppSettings.Default);
            return AppSettings.Default;
        }
    }

    public static void Save(string path, AppSettings settings)
    {
        var json = JsonSerializer.Serialize(settings, JsonOptions);
        File.WriteAllText(path, json);
    }
}
