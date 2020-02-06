using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    class CuttingReport : Order,IGenerateReport
    {
        public void GenerateReport(Order order)
        {
            Console.WriteLine("Your cutting list has been generated:");
            Console.WriteLine("Name: {0} Address: {1} Due Date: {2} Order #: {3} ",order.CustomerName,order.Address,order.DueDate,Order.OrderID);
            Console.WriteLine("|          | Qty |");
            Console.WriteLine("|----------|-----|");
            foreach (var item in order.ShapeList)
            {
                Console.WriteLine("| {0}   | {1} |",item[0].ShapeName,Shape.GetTotalNumberOfShapes(item));   
            }
        }
    }
}
