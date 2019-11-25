using System;
namespace interfaceIntro
{
    public class Cessna : IGasVehicle, IVehicle
    {

        int FuelCapacity { get; set; }
        int IGasVehicle.FuelCapacity { get; set; }
        int FuelLevel { get; set; }
        int IGasVehicle.FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Zoom");
        }

        void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }

        void IGasVehicle.RefuelTank()
        {
            throw new NotImplementedException();
        }
    }
}