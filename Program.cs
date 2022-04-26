using System;

namespace CSharp.LabExercise4
{
    interface IShape
    {
        public void ComputeArea();
        public void DisplayArea();
        public string ShapeName { get; set; }
    }

    class Circle : IShape
    {
        double Area;
        double radius;
        double PI = 3.1415;
        string _circle;
        public string ShapeName { get => _circle; set => _circle = value; }

        public void ComputeArea()
        {
            Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            this.Area = radius * radius * PI;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area of {ShapeName} is: {this.Area} ");
        }

    }

    class Square : IShape
    {
        double Area;
        double side;
        string _square;
        public string ShapeName { get => _square; set => _square = value; }

        public void ComputeArea()
        {
            Console.Write("Enter a side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            this.Area = side * side;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area of {ShapeName} is: {this.Area} ");
        }
    }

    class Rectangle : IShape
    {
        decimal Area;
        decimal Length;
        decimal Width;
        string _rectangle;
        public string ShapeName { get => _rectangle; set => _rectangle = value; }

        public void ComputeArea()
        {
            Console.Write("Enter Length: ");
            decimal Length =Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Width: ");
            decimal Width =Convert.ToDecimal(Console.ReadLine());
            this.Area = Length * Width;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Area of {ShapeName} is: {this.Area}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Circle");
            Console.WriteLine("[2] Square");
            Console.WriteLine("[3] Rectangle");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IShape circle = new Circle();
                        circle.ShapeName = "circle";
                        circle.ComputeArea();
                        circle.DisplayArea();
                        break;
                    case 2:
                        IShape square = new Square();
                        square.ShapeName = "square";
                        square.ComputeArea();
                        square.DisplayArea();
                        break;
                    case 3:
                        IShape rectangle = new Rectangle();
                        rectangle.ShapeName = "rectangle";
                        rectangle.ComputeArea();
                        rectangle.DisplayArea();
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice!");
                        break;

                }
            }


            
            


        }
    }
}
