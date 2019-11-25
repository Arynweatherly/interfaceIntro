namespace interfaceIntro
{
    public class Prius : IVehicle, IGasVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void ChargeBattery()
        {
            throw new System.NotImplementedException();
        }

        public void Drive()
        {
            throw new System.NotImplementedException();
        }

        public void RefuelTank()
        {
            throw new System.NotImplementedException();
        }
    }
}