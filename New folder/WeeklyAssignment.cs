using System;

public class Car
{
    private const double DEFAULT_FUEL_LEVEL = 20;
    private const double MAX_FUEL_LEVEL = 60;
    private const double FUEL_IDLE_CONSUMPTION = 0.0003;
    private const double FUEL_CONSUMPTION_RANGE_1 = 0.0020;
    private const double FUEL_CONSUMPTION_RANGE_2 = 0.0014;
    private const double FUEL_CONSUMPTION_RANGE_3 = 0.0020;
    private const double FUEL_CONSUMPTION_RANGE_4 = 0.0025;
    private const double FUEL_CONSUMPTION_RANGE_5 = 0.0030;
    private const double MAX_SPEED = 250;
    private const double MIN_ACCELERATION = 5;
    private const double MAX_ACCELERATION = 20;
    private const double DEFAULT_ACCELERATION = 10;
    private const double MAX_BRAKING = 10;
    private const double SPEED_LOSS_FREEWHEELING = 1;

    private double fuelLevel;
    private double acceleration;
    private double braking;
    private double speed;
    private bool engineRunning;

    public Car()
    {
        fuelLevel = DEFAULT_FUEL_LEVEL;
        acceleration = DEFAULT_ACCELERATION;
        braking = MAX_BRAKING;
        speed = 0;
        engineRunning = false;
    }

    public Car(double acceleration)
    {
        fuelLevel = DEFAULT_FUEL_LEVEL;
        this.acceleration = Math.Max(Math.Min(acceleration, MAX_ACCELERATION), MIN_ACCELERATION);
        braking = MAX_BRAKING;
        speed = 0;
        engineRunning = false;
    }

    public void EngineStart()
    {
        engineRunning = true;
    }

    public void EngineStop()
    {
        engineRunning = false;
    }

    public void AccelerateTo(double targetSpeed)
    {
        if (engineRunning)
        {
            while (speed < targetSpeed && fuelLevel > 0)
            {
                double fuelConsumption = CalculateFuelConsumption();
                fuelLevel -= fuelConsumption;
                if (fuelLevel < 0)
                {
                    fuelLevel = 0;
                }
                speed += acceleration;
                if (speed > MAX_SPEED)
                {
                    speed = MAX_SPEED;
                }
            }
        }
    }

    public void BrakeTo(double targetSpeed)
    {
        if (engineRunning)
        {
            while (speed > targetSpeed)
            {
                speed -= braking;
                if (speed < 0)
                {
                    speed = 0;
                }
            }
        }
    }

    public void FreeWheel()
    {
        if (engineRunning)
        {
            speed -= SPEED_LOSS_FREEWHEELING;
            if (speed < 0)
            {
                speed = 0;
            }
        }
    }

    public double GetFuelLevel()
    {
        return Math.Round(fuelLevel, 2);
    }

    public double GetSpeed()
    {
        return Math.Round(speed, 2);
    }

    private double CalculateFuelConsumption()
    {
        if (speed <= 60)
        {
            return FUEL_CONSUMPTION_RANGE_1;
        }
        else if (speed <= 100)
        {
            return FUEL_CONSUMPTION_RANGE_2;
        }
        else if (speed <= 140)
        {
            return FUEL_CONSUMPTION_RANGE_3;
        }
        else if (speed <= 200)
        {
            return FUEL_CONSUMPTION_RANGE_4;
        }
        else{
            return FUEL_CONSUMPTION_RANGE_5;
        }
     }
     static void Main(string[] args)
    {
       
        Car myCar1 = new Car();
        Console.WriteLine($"Fuel level: {myCar1.GetFuelLevel()}");  
        Console.WriteLine($"Speed: {myCar1.GetSpeed()}");  
        
        
        myCar1.EngineStart();
        myCar1.AccelerateTo(100);
        Console.WriteLine($"Fuel level: {myCar1.GetFuelLevel()}");  
        Console.WriteLine($"Speed: {myCar1.GetSpeed()}"); 
        
        
        myCar1.BrakeTo(50);
        myCar1.FreeWheel();
        Console.WriteLine($"Fuel level: {myCar1.GetFuelLevel()}");  
        Console.WriteLine($"Speed: {myCar1.GetSpeed()}");  
        
       
        Car myCar2 = new Car(15);
        Console.WriteLine($"Fuel level: {myCar2.GetFuelLevel()}");  
        Console.WriteLine($"Speed: {myCar2.GetSpeed()}");  
        
       
        myCar2.EngineStart();
        myCar2.AccelerateTo(200);
        Console.WriteLine($"Fuel level: {myCar2.GetFuelLevel()}");  
        Console.WriteLine($"Speed: {myCar2.GetSpeed()}");  
    }
     
}
