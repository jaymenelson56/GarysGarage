namespace Garage;

public class Cessna : Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna drives past. Zoooooom!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The vehicle carefully turns right");
    }
    public override void Stop()
    {
        Console.WriteLine($"The vehicle gently rolls to a stop");
    }
}