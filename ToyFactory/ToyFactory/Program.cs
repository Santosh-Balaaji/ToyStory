using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            var squareList = obj.GenerateSquareList();
            var circleList = obj.GenerateCircleList();
            var triangleList = obj.GenerateTriangleList();
            var shapeList = obj.GenerateShapeList(squareList,circleList,triangleList);

            var order = obj.GetUserDetails();
            order.ShapeList = shapeList;
            obj.GetShapeDetailsFromUser(shapeList);
            
            InvoiceReport invoice = new InvoiceReport();
            invoice.GenerateReport(order);
            CuttingReport cuttingReport = new CuttingReport();
            cuttingReport.GenerateReport(order);
            PaintingReport paintingReport = new PaintingReport();
            paintingReport.GenerateReport(order);
            



        }

        private List<List<Shape>> GenerateShapeList(List<Shape> squareList, List<Shape> circleList, List<Shape> triangleList)
        {
            List<List<Shape>> shapeList = new List<List<Shape>>();
            shapeList.Add(squareList);
            shapeList.Add(circleList);
            shapeList.Add(triangleList);

            return shapeList;
        }


        private List<Shape> GenerateTriangleList()
        {
            Triangle redTriangle = new Triangle("Red");
            Triangle blueTriangle = new Triangle("Blue");
            Triangle yellowTriangle = new Triangle("Yellow");
            List<Shape> triangleList = new List<Shape>();
            triangleList.Add(redTriangle);
            triangleList.Add(blueTriangle);
            triangleList.Add(yellowTriangle);

            return triangleList;
        }

        public List<Shape> GenerateSquareList()
        {
            Square redSquare = new Square("Red");
            Square bluesSquare = new Square("Blue");
            Square yellowSquare = new Square("Yellow");
            List<Shape> squareList = new List<Shape>();
            squareList.Add(redSquare);
            squareList.Add(bluesSquare);
            squareList.Add(yellowSquare);

            return squareList;
        }

        public List<Shape> GenerateCircleList()
        {
            Circle redCircle = new Circle("Red");
            Circle blueCircle = new Circle("Blue");
            Circle yelowCircle = new Circle("Yellow");
            List<Shape> circleList = new List<Shape>();
            circleList.Add(redCircle);
            circleList.Add(blueCircle);
            circleList.Add(yelowCircle);

            return circleList;
        }

        public Order GetUserDetails() 
        {
            Order order = new Order();
            Console.WriteLine("### Example input");
            Console.WriteLine("~~~");
            Console.WriteLine("Welcome to the Toy Block Factory!");
            
            Console.WriteLine("Please input your Name:");
            order.CustomerName = Console.ReadLine();
            
            Console.WriteLine("Please input your Address:");
            order.Address = Console.ReadLine();
            
            Console.WriteLine("Please input your Due Date");
            order.DueDate = Console.ReadLine();
            return order;
        }

        public void GetShapeDetailsFromUser(List<List<Shape>> shapeList)
        {
            int count;

            foreach (var item in shapeList)
            {
                for (int i = 0; i < shapeList.Count; i++)
                {
                    Console.WriteLine("Please input the number of {0} {1}s", item[i].Color, item[i].ShapeName);
                    Int32.TryParse(Console.ReadLine(), out count);
                    item[i].Count = count;
                }
            }
        }


    }
}
