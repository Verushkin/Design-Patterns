using Lab4;

public static class Programm 
{
    public static void Main() 
    {
        IBirdProducer producer = new BirdProducer();
        BirdHandler birdHandler = new BirdHandler(producer);
        birdHandler.DoBirdAction();
    }
}