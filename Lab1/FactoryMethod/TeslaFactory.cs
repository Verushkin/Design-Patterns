namespace FactoryMethod
{
    internal class TeslaFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new Tesla();
        }
    }
}
