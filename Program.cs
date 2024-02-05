    namespace Characters;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Character randomCharacter = GetRandomCharacter();
        Weapon randomWeapon = GetRandomWeapon();
        
        randomCharacter.Attack();
        Console.WriteLine($"Equipped with {randomWeapon.Description} - {randomWeapon.AttackMessage}");
    }

    static Character GetRandomCharacter()
    {
        string[] characterTypes = { "Fighter", "Wizard", "Rogue", "Ranger" };
        string randomType = characterTypes[new Random().Next(characterTypes.Length)];

        switch (randomType)
        {
            case "Fighter":
                return new Fighter("Random Fighter", "A strong and skilled warrior.");
            case "Wizard":
                return new Wizard("Random Wizard", "A magical spellcaster.");
            case "Rogue":
                return new Rogue("Random Rogue", "A sneaky and agile adventurer.");
            case "Ranger":
                return new Ranger("Random Ranger", "A skilled archer and tracker.");
            default:
                throw new InvalidOperationException("Invalid character type");
        }
    }
    
    static Weapon GetRandomWeapon()
    {
        string[] weaponTypes = { "Sword", "Dagger", "Bow", "Staff", "Wand" };
        string randomType = weaponTypes[new Random().Next(weaponTypes.Length)];

        switch (randomType)
        {
            case "Sword":
                return new Sword("Sharp Sword", "slashes enemies");
            case "Dagger":
                return new Dagger("Stealthy Dagger", "stabs foes from the shadows");
            case "Bow":
                return new Bow("Long Bow", "shoots arrows at a distance");
            case "Staff":
                return new Staff("Mystical Staff", "channels magical energy");
            case "Wand":
                return new Wand("Enchanted Wand", "casts powerful spells");
            default:
                throw new InvalidOperationException("Invalid weapon type");
        }
    }
}