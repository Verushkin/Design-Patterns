namespace FactoryMethod
{
    internal class HondaFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new Honda();
        }
    }
}
