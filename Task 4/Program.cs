using Task_4;

Player p1 = new Player();
Player p2 = new Player("Manil", 5, 100);

Console.WriteLine($"p1: {p1.playerName}, {p1.level}, {p1.health}");
Console.WriteLine($"p2: {p2.playerName}, {p2.level}, {p2.health}");