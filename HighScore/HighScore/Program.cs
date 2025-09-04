using System.Runtime.InteropServices;
List<string> names = [];
List<string> points = [];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Skriv namnet på en lärare");
    string teacher = Console.ReadLine();
    names.Add(teacher);
    Console.WriteLine("Skriv poäng som en lärare har");
    String poäng = Console.ReadLine();
    points.Add(poäng);
}
Console.Clear();

for (int i = 0; i < names.Count && i < points.Count; i++)
{
    Console.WriteLine($"{i + 1}) {names[i]} har {points[1]} poäng");
}

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

Console.ReadLine();