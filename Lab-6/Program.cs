using System;
using System.Text;

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} каже: Гав-гав!");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} каже: Мяу-мяу!");
    }
}

public class Parrot : Animal
{
    public Parrot(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} каже: Привіт! Піастри!");
    }
}

class Program
{
    static void Main( string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Animal myDog = new Dog("Рекс");
        Animal myCat = new Cat("Мурчик");
        Animal myParrot = new Parrot("Кеша");

        myDog.MakeSound();
        myCat.MakeSound();
        myParrot.MakeSound();
    }
}