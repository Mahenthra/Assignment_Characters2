using System.Security.Cryptography.X509Certificates;

namespace Characters;

public class Wizard : Character
{
    public Wizard(string name, string description) : base(name, description)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} Shots fddireball to blast the energy");
    }
}