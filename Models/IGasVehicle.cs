namespace Garage;

public interface IGasVehicle
{
    Double CurrentTankPercentage {get; set; }
    void RefuelTank();
}