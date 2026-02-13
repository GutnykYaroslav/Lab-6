abstract class Vehicle
{
    public string brand;
    public int speed;

    public abstract void Move();
}

class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Велосипед їде");
    }
}

class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Літак літає");
    }

    public void Refill()
    {
        Console.WriteLine("Літак заправляється");
    }
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Машина їде");
    }

    public void Refill()
    {
        Console.WriteLine("Машина заправляється");
    }
}