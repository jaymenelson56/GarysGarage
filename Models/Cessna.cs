namespace Garage;

public class Cessna : Vehicle, IGasVehicle
{
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
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