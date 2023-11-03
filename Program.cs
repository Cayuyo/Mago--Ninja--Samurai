// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Wizard wizard = new("Satoru Gojo");
Ninja ninja = new("Saitama");
Samurai samurai = new("Miyamoto Musashi");

wizard.Attack(ninja);
ninja.Steal(wizard);
samurai.Attack(ninja);
wizard.Heal(samurai);
samurai.Meditate();

Console.WriteLine("Estado de salud:");
Console.WriteLine($"{wizard.Name}: {wizard.Health}");
Console.WriteLine($"{ninja.Name}: {ninja.Health}");
Console.WriteLine($"{samurai.Name}: {samurai.Health}");