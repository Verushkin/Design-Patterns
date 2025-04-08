namespace FactoryMethod
{
    internal interface ITank: ICar
    {
        float ProjectileCaliber { get; set;}
        int ShotsPerMinute { get; set; }
        int CrewSize { get; set; }

    }
}
