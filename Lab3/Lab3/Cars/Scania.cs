namespace Lab3Cars
{
    internal class Scania : ICargo
    {
        public Scania()
        {
            Tonnage = 21;
            TankVolume = 209;
            AxlesAmount = 6;
            Weight = 6;
            Length = 21;
            MaxSpeed = 122;
        }
        public float Tonnage { get; set; }
        public float TankVolume { get; set; }
        public int AxlesAmount { get; set; }
        public float Weight { get; set; }
        public float Length { get; set; }
        public float MaxSpeed { get; set; }
    }
}
