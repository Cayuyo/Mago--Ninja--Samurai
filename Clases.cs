
class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }

    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }

    // Construir método de ataque
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} atacó a {target.Name} causando {dmg} daño!");
        return target.Health;
    }
}


class Wizard : Human
{
    public Wizard(string name) : base(name, 3, 25, 3, 50) { }

    public override int Attack(Human target)
    {
        int damage = Intelligence * 3;
        target.Health -= damage;
        Health += damage;
        Console.WriteLine($"{Name} atacó a {target.Name} por {damage} de daño y se curó por {damage} de salud!");
        return target.Health;
    }

    public void Heal(Human target)
    {
        int healing = Intelligence * 3;
        target.Health += healing;
        Console.WriteLine($"{Name} curó a {target.Name} para obtener {healing} de salud!");
    }
}


class Ninja : Human
{
    public Ninja(string name) : base(name, 3, 175, 100, 100) { }

    public override int Attack(Human target)
    {
        int damage = Dexterity;
        if (new Random().Next(0, 100) < 20)
        {
            damage += 10;
        }
        target.Health -= damage;
        Console.WriteLine($"{Name} atacó a {target.Name} causando {damage} daño!");
        return target.Health;
    }

    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        Console.WriteLine($"{Name} le robó 5 puntos de vida a {target.Name}!");
    }
}


class Samurai : Human
{
    public Samurai(string name) : base(name, 3, 3, 3, 200) { }

    public override int Attack(Human target)
    {
        int damage = Strength * 3;
        target.Health -= damage;
        if (target.Health < 50)
        {
            target.Health = 0;
        }
        Console.WriteLine($"{Name} atacó a {target.Name} causando {damage} daño!");
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
        Console.WriteLine($"{Name} a meditado y sanado a plena salud!");
    }
}