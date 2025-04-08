namespace AbstractFactory
{
    internal class IkeaFactory : IAbstractFactory
    {
        public IBed CreateBed()
        {
            return new IkeaDoublebed();
        }

        public IChair CreateChair()
        {
            return new IkeaFoldingСhair();
        }
    }
    internal class IkeaFoldingСhair : IChair
    {
        public void Fold()
        {
            Console.WriteLine("Folding Chair");
        }

        public void Unfold()
        {
            Console.WriteLine("Unfolding Chair");
        }
    }
    internal class IkeaDoublebed : IBed
    {
        public void Cover()
        {
            Console.WriteLine("Cover Bed");
        }

        public void Uncover()
        {
            Console.WriteLine("Uncover Bed");
        }
    }
}
