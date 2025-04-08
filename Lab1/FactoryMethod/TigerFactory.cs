namespace FactoryMethod
{
    internal class TigerFactory : ITankFactory
    {
        public ITank CreateCar()
        {
            return new Tiger();
        }
    }
}
