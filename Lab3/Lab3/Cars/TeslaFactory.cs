namespace Lab3Cars
{
    internal class TeslaFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new Tesla();
        }
    }
}
