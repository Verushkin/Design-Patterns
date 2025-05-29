namespace Lab3Cars
{
    internal class AudiFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new Audi();
        }
    }
}
