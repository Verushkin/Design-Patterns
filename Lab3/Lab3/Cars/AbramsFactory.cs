namespace Lab3Cars
{
    internal class AbramsFactory : ITankFactory
    {
        public ITank CreateCar()
        {
            return new Abrams();
        }
    }
}
