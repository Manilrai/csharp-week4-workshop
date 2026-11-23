using Task_3;

ParameterDemo demo = new ParameterDemo();

int number = 5;
demo.Increase(ref number);
Console.WriteLine($"After Increase: {number}");

demo.GetFullName(out string fullName);
Console.WriteLine($"Full name: {fullName}");

int total = demo.SumAll(10, 20, 30, 40);
Console.WriteLine($"Sum: {total}");