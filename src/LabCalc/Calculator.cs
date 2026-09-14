namespace LabCalc;

public static class Calculator
{
    public static decimal RoundForDisplay(decimal value, int decimals)
    {
        if (decimals < 0 || decimals > 28)
            throw new ArgumentOutOfRangeException(nameof(decimals));

        return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
    }
}
