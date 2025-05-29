using Lab3.Abstraction;
using System;

namespace Lab3
{
    // Интерфейс фигуры
    public interface IShape
    {
        double Accept(IShapeVisitor visitor);
    }

    // Интерфейс посетителя
    public interface IShapeVisitor
    {
        double Visit(Sphere sphere);
        double Visit(Parallelepiped parallelepiped);
        double Visit(Torus torus);
        double Visit(Cube cube);
    }

    // Конкретные фигуры
    public class Sphere : IShape
    {
        public double Radius { get; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class Parallelepiped : IShape
    {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }

        public Parallelepiped(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class Torus : IShape
    {
        public double MajorRadius { get; }
        public double MinorRadius { get; }

        public Torus(double majorRadius, double minorRadius)
        {
            MajorRadius = majorRadius;
            MinorRadius = minorRadius;
        }

        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class Cube : IShape
    {
        public double Side { get; }

        public Cube(double side)
        {
            Side = side;
        }

        public double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    // Реализация посетителя - вычисление объема
    public class VolumeCalculatorVisitor : IShapeVisitor
    {
        public double Visit(Sphere sphere)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(sphere.Radius, 3);
        }

        public double Visit(Parallelepiped parallelepiped)
        {
            return parallelepiped.Length * parallelepiped.Width * parallelepiped.Height;
        }

        public double Visit(Torus torus)
        {
            return 2 * Math.PI * Math.PI * torus.MajorRadius * Math.Pow(torus.MinorRadius, 2);
        }

        public double Visit(Cube cube)
        {
            return Math.Pow(cube.Side, 3);
        }
    }

    // Точка входа
    class Task1 : IExamplePattern
    {
        public void Do()
        {
            IShape[] shapes = new IShape[]
           {
                new Sphere(3),
                new Parallelepiped(2, 3, 4),
                new Torus(5, 1),
                new Cube(2)
           };

            var volumeVisitor = new VolumeCalculatorVisitor();

            foreach (var shape in shapes)
            {
                double volume = shape.Accept(volumeVisitor);
                Console.WriteLine($"{shape.GetType().Name} объём: {volume:F2}");
            }
        }
    }
}
