namespace Garage;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. VROOOOOOM!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The vehicle carefully turns left");
    }
    public override void Stop()
    {
        Console.WriteLine($"The vehicle ever so gently rolls to a stop");
    }
}