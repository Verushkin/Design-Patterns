namespace Lab3Cars
{
    internal class Man : ICargo
    {
        public Man()
        {
            Tonnage = 25;
            TankVolume = 210;
            AxlesAmount = 4;
            Weight = 10;
            Length = 24;
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

