namespace FactoryMethod
{
    internal interface ICargo: ICar
    {
        float Tonnage { get; set; }
        float TankVolume { get; set; }
        int AxlesAmount { get; set; }

    }
}
