namespace Characters;

public class Fighter : Character
{
    public Fighter(string name, string description) : base(name, description)
    {
        
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} Chop the head of with a sword!");
    }

}   