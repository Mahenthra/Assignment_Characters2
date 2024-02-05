namespace Characters;

public class Ranger : Character
{
    public Ranger(string name, string description) : base(name, description)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} Takes a bow and fire it!");
    }
}