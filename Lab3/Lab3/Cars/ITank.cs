namespace Lab3Cars
{
    internal interface ITank: ICar
    {
        float ProjectileCaliber { get; set;}
        int ShotsPerMinute { get; set; }
        int CrewSize { get; set; }

    }
}
