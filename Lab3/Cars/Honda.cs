namespace Lab3Cars
{
    internal class Honda : IVehicle
    {
        public Honda()
        {
            WheelDrive = WheelDrive.front;
            ClassOfVehicle = ClassOfVehicle.sedan;
            Color = Color.yellow;
            Weight = 1800;
            Length = 4;
            MaxSpeed = 160;
        }

        public WheelDrive WheelDrive { get; set; }
        public ClassOfVehicle ClassOfVehicle { get; set; }
        public Color Color { get; set; }
        public float Weight { get; set; }
        public float Length { get; set; }
        public float MaxSpeed { get; set; }

    }
}
