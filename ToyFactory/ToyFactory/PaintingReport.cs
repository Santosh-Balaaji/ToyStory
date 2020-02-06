using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    class PaintingReport : Order,IGenerateReport
    {
        public void GenerateReport(Order order)
        {
            Console.WriteLine("Your painting report has been generated:");
            Console.WriteLine("Name: {0} Address: {1} Due Date: {2} Order #: {3}", order.CustomerName, order.Address, order.DueDate,Order.OrderID);
            Console.WriteLine("|            | {0}  | {1} | {2} |", order.ShapeList[0][0].Color, order.ShapeList[0][1].Color, order.ShapeList[0][2].Color);
            Console.WriteLine("|------------|------|------|--------|");
            foreach (var item in order.ShapeList)
            {
                Console.WriteLine("| {0}     | {1}    | {2}    | {3}      |", item[0].ShapeName, item[0].Count, item[1].Count, item[2].Count);
            }

           
        }
    }
}
