namespace Characters;

public class Rogue : Character
{
    public Rogue(string name, string description) : base(name, description)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} strikes with a machete");
    }
}