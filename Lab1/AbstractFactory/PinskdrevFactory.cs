namespace AbstractFactory
{
    internal class PinskdrevFactory : IAbstractFactory
    {
        public IBed CreateBed()
        {
            return new PinskdrevDoublebed();
        }

        public IChair CreateChair()
        {
            return new PinskdrevFoldingСhair();
        }
    }
    internal class PinskdrevFoldingСhair : IChair
    {
        public void Fold()
        {
            Console.WriteLine("Folding Chair without sound");
        }

        public void Unfold()
        {
            Console.WriteLine("Unfolding Chair");
        }
    }
    internal class PinskdrevDoublebed : IBed
    {
        public void Cover()
        {
            Console.WriteLine("Cover Bed without sound");
        }

        public void Uncover()
        {
            Console.WriteLine("Uncover Bed without sound");
        }
    }
}
