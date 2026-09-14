using LabCalc;

var input = 2.345m;
var result = Calculator.RoundForDisplay(input, 2);

Console.WriteLine("LabCalc 1.1.0-dev");
Console.WriteLine($"RoundForDisplay({input}, 2) = {result}");
