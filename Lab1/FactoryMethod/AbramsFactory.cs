namespace FactoryMethod
{
    internal class AbramsFactory : ITankFactory
    {
        public ITank CreateCar()
        {
            return new Abrams();
        }
    }
}
