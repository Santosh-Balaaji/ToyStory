using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ToyFactory
{
    class Shape
    {
        public string ShapeName { get; set; }
        public string Color { get; set; }
        public int? Count { get; set; }
        public decimal Cost { get; set; }

        public static decimal SurgePrice = 1;

        public static int GetTotalNumberOfItemsPerColor(string color,List<List<Shape>> shapeList)
        {
            int count = 0;
            foreach (var shape in shapeList)
            {
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shape[i].Color == color)
                    {
                        count += shape.Count;
                    }
                }
            }

            return count;
        }

        
        public static int? GetTotalNumberOfShapes(List<Shape> shapeList)
        {
            int? count = 0;
            foreach (var shape in shapeList)
            { 
                count += shape.Count;
            }
            return count;

        }

        public static decimal GetSurchargePriceForRed(List<List<Shape>> shapeList)
        {
            int count = 0;
            
            count += Shape.GetTotalNumberOfItemsPerColor("Red",shapeList);
            
            return count*SurgePrice;

        }


    }

}
