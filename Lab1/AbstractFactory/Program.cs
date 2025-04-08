namespace AbstractFactory
{
    public static class Program
    {
        public static void Main()
        {
            var pinskdrev = new PinskdrevFactory();
            var chair1 = pinskdrev.CreateChair();
            var chair2 = pinskdrev.CreateChair();
            var bed1 = pinskdrev.CreateBed();
            var bed2 = pinskdrev.CreateBed();
            var ikea = new IkeaFactory();
            var chair3 = ikea.CreateChair();
            var chair4 = ikea.CreateChair();
            var bed3 = ikea.CreateBed();
            var bed4 = ikea.CreateBed();
            chair1.Fold();
            chair2.Fold();
            chair3.Fold();
            chair4.Fold();


        }
    }
}