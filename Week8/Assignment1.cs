using System;
using System.Collections.Generic;

public abstract class Enemy
{
    protected int Health { get; set; }
    protected int Damage { get; set; }

    public Enemy(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public abstract void Attack();
}

public class Archer : Enemy
{
    public Archer(int health, int damage) : base(health, damage)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Archer attacks with a bow, dealing {Damage} damage.");
    }
}

public class Orc : Enemy
{
    public Orc(int health, int damage) : base(health, damage)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Orc attacks with a club, dealing {Damage} damage.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Enemy> enemies = new List<Enemy>()
        {
            new Archer(5, 3),
            new Orc(10, 5)
        };

        foreach (Enemy enemy in enemies)
        {
            enemy.Attack();
        }

        Console.ReadLine();
    }
}