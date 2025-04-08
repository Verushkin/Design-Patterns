namespace FactoryMethod
{
    internal class VolvoFactory : ICargoFactory
    {
        public ICargo CreateCar()
        {
            return new Volvo();
        }
    }
}
