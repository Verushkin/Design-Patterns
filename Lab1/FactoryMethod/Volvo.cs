namespace FactoryMethod
{
    internal class Volvo : ICargo
    {
        public Volvo() 
        {
            Tonnage = 24;
            TankVolume = 200;
            AxlesAmount = 8;
            Weight = 5;
            Length = 20;
            MaxSpeed = 120;
        }
        public float Tonnage { get; set; }
        public float TankVolume { get; set; }
        public int AxlesAmount { get; set; }
        public float Weight { get; set; }
        public float Length { get; set; }
        public float MaxSpeed { get; set; }
    }
}
