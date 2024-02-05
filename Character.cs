namespace Characters;

public class Character
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Character(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attack!");
    }
    
}