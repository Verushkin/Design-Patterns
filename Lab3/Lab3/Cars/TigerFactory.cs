namespace Lab3Cars
{
    internal class TigerFactory : ITankFactory
    {
        public ITank CreateCar()
        {
            return new Tiger();
        }
    }
}
