using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    class InvoiceReport : Order,IGenerateReport
    {
        
        public void GenerateReport(Order order)
        {
            decimal totalCost = 0;
            Console.WriteLine("# Invoice Report");
            Console.WriteLine("Name: {0}", order.CustomerName);
            Console.WriteLine("Address: {0}",order.Address);
            Console.WriteLine("Due Date: {0}", order.DueDate);
            Console.WriteLine("Order #: {0}",Order.GenerateOrderID());
            Console.WriteLine("|        | {0}  | {1} | {2} |",order.ShapeList[0][0].Color,order.ShapeList[0][1].Color,order.ShapeList[0][2].Color);
            Console.WriteLine("|--------|------|------|--------|");
            foreach (var item in order.ShapeList)
            {
                Console.WriteLine("| {0} | {1}    | {2}    | {3}      |",item[0].ShapeName,item[0].Count,item[1].Count,item[2].Count);
            }
            
            foreach (var list in order.ShapeList)
            {
                totalCost += (Shape.GetTotalNumberOfShapes(list) * list[0].Cost);
                Console.WriteLine("{0}s             {1} @ ${2} ppi = ${3}",list[0].ShapeName,Shape.GetTotalNumberOfShapes(list),list[0].Cost, (Shape.GetTotalNumberOfShapes(list) * list[0].Cost));
            }

            var surchargePrice = Shape.GetSurchargePriceForRed(order.ShapeList);
            Console.WriteLine("Red color surcharge  {0} @ ${1} ppi = ${2}",Shape.GetTotalNumberOfItemsPerColor(order.ShapeList[0][0].Color, order.ShapeList),Shape.SurgePrice,Shape.GetSurchargePriceForRed(order.ShapeList));
            Console.WriteLine("Total : {0}",(totalCost+surchargePrice));

        }
    }
}
