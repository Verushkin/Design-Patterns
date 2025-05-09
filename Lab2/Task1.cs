using Lab2.Abstraction;
using System;
using System.Collections.Generic;

namespace Lab2
{
    public interface IEmployee
    {
        Position Position { get; }
        void Work();
    }

    public enum Position
    {
        Director,
        Manager,
        Worker
    }

    public class Director : IEmployee
    {
        public Position Position => Position.Director;
        public void Work() => Console.WriteLine("Управляет компанией.");
    }

    public class Manager : IEmployee
    {
        public Position Position => Position.Manager;
        public void Work() => Console.WriteLine("Руководит проектами.");
    }

    public class Worker : IEmployee
    {
        public Position Position => Position.Worker;
        public void Work() => Console.WriteLine("Выполняет задачи.");
    }
    public class Company
    {
        private readonly List<IEmployee> _employees = new();

        public void Hire(IEmployee employee)
        {
            _employees.Add(employee);
            Console.WriteLine($"Принят сотрудник: {employee.Position}");
        }

        public void RunWork()
        {
            Console.WriteLine("\nРабота сотрудников:");
            foreach (var e in _employees)
            {
                Console.Write($"{e.Position}: ");
                e.Work();
            }
        }
    }

    public class Task1: IExamplePattern // Используем паттерн Extensibility
    {
        public void Do()
        {
            var company = new Company();

            company.Hire(new Director());
            company.Hire(new Manager());
            company.Hire(new Worker());
            company.Hire(new Worker());

            company.RunWork();
        }
    }
}
