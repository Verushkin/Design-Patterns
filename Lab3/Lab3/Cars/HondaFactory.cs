namespace Lab3Cars
{
    internal class HondaFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new Honda();
        }
    }
}
