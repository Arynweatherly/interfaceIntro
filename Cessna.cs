namespace interfaceIntro
{
    public class Cessna : IGasVehicle, IVehicle
    {

        int FuelCapacity { get; set; }
        int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Zoom");
        }

        void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }

    }
}