using Task_5;

Console.Write("Enter the day (e.g. Sunday): ");
string? input = Console.ReadLine()?.Trim();

DayType dayType;
if (string.Equals(input, "Friday", StringComparison.OrdinalIgnoreCase) ||
    string.Equals(input, "Saturday", StringComparison.OrdinalIgnoreCase))
{
    dayType = DayType.Weekend;
}
else
{
    dayType = DayType.Weekday;
}
Console.WriteLine($"It is: {dayType}");

Book book1 = new Book("Clean Code", "Robert Martin", 1500.0);
Book book2 = book1 with { title = "The Pragmatic Programmer", price = 1800.0 };

Console.WriteLine(book1);

var (title, author, price) = book2;
Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");