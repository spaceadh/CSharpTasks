using System;

// Interface for walking behavior
public interface IWalking
{
    void Walk();
}

// Interface for swimming behavior
public interface ISwimming
{
    void Swim();
}

// Base class for all animals
public abstract class Animal
{
    // Common properties and methods for all animals can be defined here
}

// Subclass representing mammals
public abstract class Mammal : Animal
{
    // Common properties and methods for mammals can be defined here
}

// Subclass representing dogs
public class Dog : Mammal, IWalking
{
    public void Walk()
    {
        Console.WriteLine("Dog is walking.");
    }
}

// Subclass representing dolphins
public class Dolphin : Mammal, ISwimming
{
    public void Swim()
    {
        Console.WriteLine("Dolphin is swimming.");
    }
}

// Subclass representing fish
public class Fish : Animal, ISwimming
{
    public void Swim()
    {
        Console.WriteLine("Fish is swimming.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Walk();

        Dolphin dolphin = new Dolphin();
        dolphin.Swim();

        Fish fish = new Fish();
        fish.Swim();
    }
}