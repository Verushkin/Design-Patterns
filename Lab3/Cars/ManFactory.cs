namespace Lab3Cars
{
    internal class ManFactory : ICargoFactory
    {
        public ICargo CreateCar()
        {
            return new Man();
        }
    }
}
