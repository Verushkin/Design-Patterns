using Lab3.Abstraction;
using Lab3Cars;
using System;
namespace Lab3
{
    public class Container
    {
        private List<ICar> cars = new List<ICar>();

        public void Add(ICar car)
        {
            cars.Add(car);
            Console.WriteLine($"Добавлен автомобиль: {car.GetType().Name}");
        }
    }
    public class Task3 : IExamplePattern
    {
        public void Do()
        {
            var container = new Container();
            var volvoFactory = new VolvoFactory();
            var volvo = volvoFactory.CreateCar();
            var audiFactory = new AudiFactory();
            var audi = audiFactory.CreateCar();
            container.Add(volvo);
            container.Add(audi);
            
            Console.WriteLine();
        }
    }
}
