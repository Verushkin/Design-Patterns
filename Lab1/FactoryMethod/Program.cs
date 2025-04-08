namespace FactoryMethod 
{
    public static class Programm 
    {
        public static void Main() 
        {
            var MerkavaFactory = new MerkavaFactory();
            var merkava = MerkavaFactory.CreateCar();
            Console.WriteLine("character Merkava" + merkava.MaxSpeed.ToString());
        }
    }
}
