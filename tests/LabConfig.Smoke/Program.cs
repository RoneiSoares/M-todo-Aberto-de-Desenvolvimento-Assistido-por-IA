using LabConfig;

var failures = 0;
var root = Path.Combine(Path.GetTempPath(), $"labconfig-smoke-{Guid.NewGuid():N}");
Directory.CreateDirectory(root);

void Check(bool condition, string name)
{
    if (condition)
        Console.WriteLine($"OK: {name}");
    else
    {
        failures++;
        Console.Error.WriteLine($"FAIL: {name}");
    }
}

try
{
    var missing = Path.Combine(root, "missing.json");
    var missingSettings = SettingsStore.Load(missing);
    Check(missingSettings == AppSettings.Default, "arquivo ausente retorna padrão");
    Check(!File.Exists(missing), "arquivo ausente não é criado");

    var valid = Path.Combine(root, "valid.json");
    File.WriteAllText(valid, "{\"Theme\":\"dark\",\"RetryCount\":5}");
    var validSettings = SettingsStore.Load(valid);
    Check(validSettings.Theme == "dark" && validSettings.RetryCount == 5, "JSON válido é carregado");

    var malformed = Path.Combine(root, "malformed.json");
    var original = "{ invalid-json";
    File.WriteAllText(malformed, original);
    var malformedSettings = SettingsStore.Load(malformed);
    Check(malformedSettings == AppSettings.Default, "JSON inválido retorna padrão");
    Check(File.ReadAllText(malformed) == original, "JSON inválido é preservado");
}
finally
{
    Directory.Delete(root, recursive: true);
}

if (failures > 0)
{
    Console.Error.WriteLine($"SMOKE FALHOU: {failures} cenário(s).");
    Environment.Exit(1);
}

Console.WriteLine("SMOKE OK.");
