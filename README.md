# Mago, Ninja, Samurai

Repositorio publico para el bootcamp de Coding Dojo.

<h3>Objetivo:</h3>
    <li>Crear clases hijos utilizando la herencia para agilizar el proceso de creación de código.​​​​</li>
    <li>Demostrar cómo se pueden sobrescribir métodos preexistentes para crear métodos únicos para clases hijas. ​​​</li>

<h3>Instrucciones</h3>

<p>Estaremos revisando nuestra clase Humano y a crear tres nuevas clases que heredan de ella.​ Crea una clase para un Ninja, un Mago y un Samurai y completa las siguientes tareas para practicar los conceptos de POO de herencia.​ Para esta tarea, tendrás que modificar tu clase Humano.​

Ejemplo de clase Humana como referencia: ​​​</p>


```cs
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
    public int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} atacó a {target.Name} causando {dmg} daño!");
        return target.Health;
    }
}
```
