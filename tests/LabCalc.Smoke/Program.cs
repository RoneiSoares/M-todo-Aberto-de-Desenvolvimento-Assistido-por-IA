using LabCalc;

var cases = new[]
{
    (Value: 2.344m, Decimals: 2, Expected: 2.34m),
    (Value: 2.345m, Decimals: 2, Expected: 2.35m),
    (Value: -2.345m, Decimals: 2, Expected: -2.35m)
};

var failures = 0;

foreach (var test in cases)
{
    var actual = Calculator.RoundForDisplay(test.Value, test.Decimals);
    if (actual != test.Expected)
    {
        failures++;
        Console.Error.WriteLine($"FAIL: {test.Value} -> esperado {test.Expected}, obtido {actual}");
    }
    else
    {
        Console.WriteLine($"OK: {test.Value} -> {actual}");
    }
}

if (failures > 0)
{
    Console.Error.WriteLine($"SMOKE FALHOU: {failures} cenário(s).");
    Environment.Exit(1);
}

Console.WriteLine("SMOKE OK: 3/3 cenários.");
