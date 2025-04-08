namespace FactoryMethod
{
    internal class ManFactory : ICargoFactory
    {
        public ICargo CreateCar()
        {
            return new Man();
        }
    }
}
