using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDAreaCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(6, 4).Area);
            Console.WriteLine(new Rectangle(3, 4).Area);

            Calculator sut = new Calculator();

            Console.WriteLine(sut.GetTotalArea(new Rectangle(4, 2), new Rectangle(3, 4)));
            Console.WriteLine(sut.GetTotalArea(new Rectangle(4, 2), new Rectangle(3, 4), new Circle(1), new Square(1), new Triangle(10, 5)));
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public double GetTotalArea(params Shape[] shapes)
        {
            double totalArea = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                totalArea += shapes[i].Area;
            }
            return Math.Round(totalArea, 2);
        }
        
    }


    class Shape
    {
        public double Area { get; set; }
    }

    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            this.Side = side;
            this.Area = side * side;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Area = width * height;
        }


    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(double radius)
        {
            this.Radius = radius;
            this.Area = Math.Round((radius * radius * Math.PI), 2);
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        
        public Triangle(double b, double height)
        {
            this.Base = b;
            this.Height = height;
            this.Area = b  / 2 * height;
        }
    }








}
