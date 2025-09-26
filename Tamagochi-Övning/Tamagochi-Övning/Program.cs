Tamagotchi tama = new();

List<string> words = File.ReadAllLines("words.txt").ToList();

foreach (string w in words)
{
    tama.Teach(w);
}

tama.Teach("Hola");
tama.PrintStats();
tama.ReduceBoredom();
tama.PrintStats();

Console.ReadLine();