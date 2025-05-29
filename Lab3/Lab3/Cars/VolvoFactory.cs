namespace Lab3Cars
{
    internal class VolvoFactory : ICargoFactory
    {
        public ICargo CreateCar()
        {
            return new Volvo();
        }
    }
}
