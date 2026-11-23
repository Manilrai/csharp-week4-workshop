using Task_1;

Student s1 = new Student();
s1.Name = "Dawa";
s1.Age = 21;
s1.Course = "BIT";

Student s2 = new Student();
s2.Name = "Sijal";
s2.Age = 20;
s2.Course = "BSc IT";

Console.WriteLine($"Student 1: {s1.Name}, {s1.Age}, {s1.Course}");
Console.WriteLine($"Student 2: {s2.Name}, {s2.Age}, {s2.Course}");
Console.WriteLine($"College (static): {Student.College}");