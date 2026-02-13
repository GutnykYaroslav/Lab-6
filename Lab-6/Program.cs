using System.Text;

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
        Console.WriteLine("Літак злітає");
    }

    public void Refill()
    {
        Console.WriteLine("Літак літає");
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
        Console.WriteLine("Машина зупиняється");
    }
}
class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<Vehicle> vehicles = new List<Vehicle> { new Car(), new Bicycle(), new Airplane() };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Move();

            if (vehicle is Car car)
            {
                car.Refill();
            }

            if (vehicle is Airplane airplane)
            {
                airplane.Refill();
            }
        }

        Console.WriteLine("Протестувати новий коміт");
    }
}