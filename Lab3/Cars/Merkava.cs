namespace Lab3Cars
{
    internal class Merkava : ITank
    {
        public Merkava()
        {
            ProjectileCaliber = 200;
            ShotsPerMinute = 10;
            CrewSize = 4;
            Weight = 10;
            Length = 5;
            MaxSpeed = 25;
        }
        public float ProjectileCaliber { get; set; }
        public int ShotsPerMinute { get; set; }
        public int CrewSize { get; set; }
        public float Weight { get; set; }
        public float Length { get; set; }
        public float MaxSpeed { get; set; }
    }
}
