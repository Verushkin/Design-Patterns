namespace Lab3Cars
{
    internal class MerkavaFactory : ITankFactory
    {
        public ITank CreateCar()
        {
            return new Merkava();
        }
    }
}
