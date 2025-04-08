namespace FactoryMethod
{
    internal interface IVehicle : ICar
    {
        WheelDrive WheelDrive { get; set; }
        ClassOfVehicle ClassOfVehicle { get; set; }
        Color Color { get; set; }

    }
    internal enum WheelDrive
    {
        front,
        back
    }
    internal enum ClassOfVehicle 
    {
        hatchback, 
        sedan,
        coupe
    }
    internal enum Color 
    {
        red,
        green,
        blue,
        yellow
    }
}
