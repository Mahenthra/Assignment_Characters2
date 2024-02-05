namespace Characters;

public class Weapon
{
    public string Description { get; set; }
    public string AttackMessage { get; set; }

    public Weapon(string description, string attackMessage)
    {
        Description = description;
        AttackMessage = attackMessage;
    }
}