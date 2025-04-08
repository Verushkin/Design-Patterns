namespace FactoryMethod
{
    internal class ScaniaFactory : ICargoFactory
    {
        public ICargo CreateCar()
        {
            return new Scania();
        }
    }
}
