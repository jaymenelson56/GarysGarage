namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
     public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
         public virtual void Turn()
    {
        Console.WriteLine("Skirrrrt!");
    }
         public virtual void Stop()
    {
        Console.WriteLine("Stuump!");
    }
}