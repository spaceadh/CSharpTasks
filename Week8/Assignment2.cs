using System;
using System.Collections.Generic;
using System.Linq;

public interface IAttack
{
    void Attack();
}

public interface IMove
{
    void Move();
}

public abstract class Enemy : IAttack, IMove
{
    protected int power;
    protected int speed;

    protected Enemy(int power)
    {
        this.power = power;
    }

    public void SetMovementSpeed(int speed)
    {
        this.speed = speed;
    }

    public abstract void Attack();
    public abstract void Move();
}

public class Archer : Enemy
{
    public Archer(int power, int speed) : base(power)
    {
        SetMovementSpeed(speed);
    }

    public override void Attack()
    {
        Console.WriteLine($"Archer attacks with a bow, dealing {power} damage.");
    }

    public override void Move()
    {
        Console.WriteLine($"Archer moves at speed {speed}.");
    }
}

public class Orc : Enemy
{
    public Orc(int power, int speed) : base(power)
    {
        SetMovementSpeed(speed);
    }

    public override void Attack()
    {
        Console.WriteLine($"Orc attacks with a club, dealing {power} damage.");
    }

    public override void Move()
    {
        Console.WriteLine($"Orc moves at speed {speed}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Enemy> enemies = new List<Enemy>()
        {
            new Archer(5, 20),
            new Orc(10, 5)
        };

        List<IAttack> attackers = enemies.OfType<IAttack>().ToList();
        List<IMove> movers = enemies.OfType<IMove>().ToList();

        attackers.ForEach((attack) => attack.Attack());
        movers.ForEach((mover) => mover.Move());

        Console.ReadLine();
    }
}