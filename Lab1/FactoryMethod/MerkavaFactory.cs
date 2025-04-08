namespace FactoryMethod
{
    internal class MerkavaFactory : ITankFactory
    {
        public ITank CreateCar()
        {
            return new Merkava();
        }
    }
}
