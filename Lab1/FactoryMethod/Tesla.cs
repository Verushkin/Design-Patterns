namespace FactoryMethod
{
    internal class Tesla : IVehicle
{
    public Tesla()
    {
        WheelDrive = WheelDrive.back;
        ClassOfVehicle = ClassOfVehicle.coupe;
        Color = Color.blue;
        Weight = 1500;
        Length = 3;
        MaxSpeed = 120;
    }

    public WheelDrive WheelDrive { get; set; }
    public ClassOfVehicle ClassOfVehicle { get; set; }
    public Color Color { get; set; }
    public float Weight { get; set; }
    public float Length { get; set; }
    public float MaxSpeed { get; set; }

}
}
