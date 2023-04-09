using System;

public class Quark
{
    public string Color { get; set; }
    public string Flavor { get; set; }
    public const double BaryonNumber = 1.0 / 3.0;

    public Quark(string color, string flavor)
    {
        this.Color = color;
        this.Flavor = flavor;
    }

    public void Interact(Quark other)
    {
        string tempColor = Color;
        Color = other.Color;
        other.Color = tempColor;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Quark q1 = new Quark("red", "up");
        Console.WriteLine(q1.Color);
        Console.WriteLine(q1.Flavor);

        Quark q2 = new Quark("blue", "strange");
        Console.WriteLine(q2.Color);
        Console.WriteLine(q2.Flavor);
        Console.WriteLine(Quark.BaryonNumber);

        q1.Interact(q2);

        Console.WriteLine(q1.Color);
        Console.WriteLine(q2.Color);
    }
}
