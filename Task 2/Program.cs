using Task_2;

Calculator calc = new Calculator();
calc.PrintWelcome();

Console.WriteLine($"Add: {calc.Add(5, 3)}");
Console.WriteLine($"Multiply (both): {calc.Multiply(4, 5)}");
Console.WriteLine($"Multiply (optional): {calc.Multiply(4)}");