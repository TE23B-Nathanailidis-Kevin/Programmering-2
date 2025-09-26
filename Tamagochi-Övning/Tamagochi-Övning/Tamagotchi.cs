using System.Globalization;
using System.Reflection.Metadata;

public class Tamagotchi
{
    private int hunger = Random.Shared.Next(3);
    private int boredom;
    private List<string> words = new List<string>() { "Hej" }; 
     private bool IsAlive;
    public string Name;

    public Tamagotchi()
    {
        List<string> names = ["Sandor", "Calin", "Gustav"];
        int i = Random.Shared.Next(names.Count);
        Name = names[i];
    }

    string name;

    public void Feed()
    {
        hunger--; 
    }

    public void Hi()
    {
      
        int wordNummer = Random.Shared.Next(words.Count);
        Console.WriteLine($" [{Name}] says: {words[wordNummer]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
    }

    public void Tick()
    {
    hunger++;
    boredom++;
    if (hunger > 10 || boredom > 10)
    {
      IsAlive = false;
    }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Boredom: {boredom} hunger: {hunger}");
    }

    public bool GetAlive()
    {
        return true;
    }

    public void ReduceBoredom()
    {
        boredom--;
    }
}