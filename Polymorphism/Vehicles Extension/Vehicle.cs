﻿
namespace Vehicles_Extension
{
    abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public string TypeVehicle { get; set; }
        public double TankCapacity { get; set; }

        public abstract void Refuel(double quantity);
        public abstract void DriveVehicle(double distance);
    }
}
