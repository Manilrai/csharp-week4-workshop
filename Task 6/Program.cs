int marks, total;

Console.Write("Enter marks: ");
while (!int.TryParse(Console.ReadLine(), out marks))
{
    Console.Write("Invalid. Enter marks again: ");
}

Console.Write("Enter total: ");
while (!int.TryParse(Console.ReadLine(), out total) || total == 0)
{
    Console.Write("Invalid. Enter total again (non-zero): ");
}
    

// Breakpoint 1: next line (before calculation)
//double percentage = marks / total * 100;
double percentage = (double)marks / total * 100;
// Breakpoint 2: next line (after calculation)
Console.WriteLine($"Percentage: {percentage}");