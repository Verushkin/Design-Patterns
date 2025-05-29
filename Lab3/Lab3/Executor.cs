using Lab3;
using Lab3.Abstraction;


public static class Programm 
{
    public static void Main()
    {
        IExamplePattern pattern;
        pattern = new Task3();

        pattern.Do();
    }
}
