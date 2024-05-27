namespace Garage;

public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past. Kaching!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The vehicle wildly turns right");
    }
    public override void Stop()
    {
        Console.WriteLine($"The vehicle abrubtly stops in front of you");
    }
}