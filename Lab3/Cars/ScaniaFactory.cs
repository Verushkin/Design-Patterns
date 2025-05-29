namespace Lab3Cars
{
    internal class ScaniaFactory : ICargoFactory
    {
        public ICargo CreateCar()
        {
            return new Scania();
        }
    }
}
