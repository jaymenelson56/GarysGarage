namespace Garage;

public class Zero : Vehicle, IElecticVehicle
{
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero drives past. ZZZZZZZZZ!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The vehicle wildly turns left");
    }
    public override void Stop()
    {
        Console.WriteLine($"The vehicle very abrubtly stops in front of you");
    }
}