namespace Garage;

    public interface IElecticVehicle
    {
        double CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
