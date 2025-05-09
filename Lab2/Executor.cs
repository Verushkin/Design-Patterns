using Lab2;
using Lab2.Abstraction;


public static class Programm 
{
    public static void Main()
    {
        IExamplePattern pattern;
        pattern = new Task3();

        pattern.Do();
    }
}
