using System;
using System.Collections.Generic;

namespace ToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Square redSquare = new Square("Red");
            Square bluesSquare = new Square("Blue");
            Square yellowSquare = new Square("Yellow");
            List<Shape> squareList = new List<Shape>();
            squareList.Add(redSquare);
            squareList.Add(bluesSquare);
            squareList.Add(yellowSquare);


            Circle redCircle = new Circle("Red");
            Circle blueCircle = new Circle("Blue");
            Circle yelowCircle = new Circle("Yellow");
            List<Shape> circleList = new List<Shape>();
            circleList.Add(redCircle);
            circleList.Add(blueCircle);
            circleList.Add(yelowCircle);


            Triangle redTriangle = new Triangle("Red");
            Triangle blueTriangle = new Triangle("Blue");
            Triangle yellowTriangle = new Triangle("Yellow");
            List<Shape> triangleList = new List<Shape>();
            triangleList.Add(redTriangle);
            triangleList.Add(blueTriangle);
            triangleList.Add(yellowTriangle);

            List<List<Shape>> shapeList =new List<List<Shape>>();
            shapeList.Add(squareList);
            shapeList.Add(circleList);
            shapeList.Add(triangleList);


            Console.WriteLine("### Example input");
            Console.WriteLine("~~~");
            Console.WriteLine("Welcome to the Toy Block Factory!");


            
            Console.WriteLine("Please input your Name:");
            var customerName = Console.ReadLine();
            Console.WriteLine("Please input your Address:");
            var address = Console.ReadLine();
            Console.WriteLine("Please input your Due Date");
            var dueDate = Console.ReadLine();

            Order order = new Order(customerName,address,dueDate,shapeList);


            foreach (var item in shapeList)
            {
                for (int i = 0; i < shapeList.Count; i++)
                {
                    Console.WriteLine("Please input the number of {0} {1}s", item[i].Color, item[i].ShapeName);
                    item[i].Count = Convert.ToInt32(Console.ReadLine());

                }
            }

            InvoiceReport invoice = new InvoiceReport();
            invoice.GenerateReport(order);
            CuttingReport cuttingReport = new CuttingReport();
            cuttingReport.GenerateReport(order);
            PaintingReport paintingReport = new PaintingReport();
            paintingReport.GenerateReport(order);
            



        }
    }
}
