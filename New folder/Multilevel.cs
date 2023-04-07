
class Vehicle
{
    public int Year { get; set; }

    public Vehicle(int year)
    {
        Year = year;
    }

    public void Drive()
    {
        Console.WriteLine($"Driving the vehicle from {Year}");
    }
}


class Car : Vehicle
{
    public string Make { get; set; }

    public Car(int year, string make) : base(year)
    {
        Make = make;
    }

    public void Accelerate()
    {
        Console.WriteLine($"{Make} car is accelerating.");
    }
}


class SportsCar : Car
{
    public SportsCar(int year, string make) : base(year, make)
    {
    }

    public void UseNitro()
    {
        Console.WriteLine($"{Make} sports car is using nitro!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        SportsCar mySportsCar = new SportsCar(2023, "Ferrari");
        mySportsCar.Drive(); 
        mySportsCar.Accelerate(); 
        mySportsCar.UseNitro(); 
    }
}
