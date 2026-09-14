using LabConfig;

var path = Path.Combine(Path.GetTempPath(), $"labconfig-{Guid.NewGuid():N}.json");
var malformed = "{ invalid-json";
File.WriteAllText(path, malformed);

var settings = SettingsStore.Load(path);
var after = File.ReadAllText(path);

Console.WriteLine("LabConfig 1.0.0");
Console.WriteLine($"Theme={settings.Theme}; RetryCount={settings.RetryCount}");
Console.WriteLine($"OriginalPreserved={after == malformed}");

File.Delete(path);
