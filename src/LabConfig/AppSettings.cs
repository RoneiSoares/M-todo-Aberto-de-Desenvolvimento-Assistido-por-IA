namespace LabConfig;

public sealed record AppSettings(string Theme, int RetryCount)
{
    public static AppSettings Default { get; } = new("light", 3);
}
