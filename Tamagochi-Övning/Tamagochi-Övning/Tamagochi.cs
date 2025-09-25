using System.Globalization;

public class Tamagochi
{
    private int hunger;
    private int boredom;
    List<string> words = [];
    private bool IsAlive;
    string name;

    public void Feed()
    {

    }

    public void Hi()
    {

    }

    public void Teach(string word)
    {

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

    private void ReduceBordedom()
    {

    }
}