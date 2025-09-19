// Enemy martin = new();
// martin.Name = "Martin";
// martin.Hp = 5;
// martin.Damage = -2;

// Enemy micke = new()
// {
//     Name = "Micke",
//     Hp = 100,
//     Damage = 15
// };

// martin.Hp++;

// martin.Hp -= micke.Damage;
// Window();


// static void Window()
// {
//     Console.WriteLine("""
//        _.-;;-._
//       '-..-'|   ||   |
//       '-..-'|_.-;;-._|
//       '-..-'|   ||   |
//       '-..-'|_.-''-._|
//     """);
//     Console.ReadLine();
// }

// Typewriter("Hej");
// Console.ReadLine();
// void Typewriter(string text)
// {
//   for (int i = 0; i < text.Length; i++)
//   {
//     Console.WriteLine(text[i]);
//     Thread.Sleep(1000);
//   }
// }

string s = GetScrambled();
Console.WriteLine(s);

Console.ReadLine();

static string GetScrambled()
{
  string text = Console.ReadLine();
  string scrambled = "";

  for (int i = 0; i < text.Length; i++)
  {
    int r = Random.Shared.Next(2);
    if (r == 0)
    {
      scrambled += text[i].ToString().ToLower();
    }
    if (r == 1)
    {
      scrambled += text[i].ToString().ToUpper();
    }

  }
  return scrambled;
}
