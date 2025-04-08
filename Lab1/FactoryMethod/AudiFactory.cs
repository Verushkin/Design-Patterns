namespace FactoryMethod
{
    internal class AudiFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new Audi();
        }
    }
}
