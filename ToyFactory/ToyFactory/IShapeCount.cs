using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    interface IShapeCount
    {
        public   int GetTotalNumberOfRedItems(List<Shape> shapeList);
        public  int GetTotalNumberOfBlueItems(List<Shape> shapeList);
        public  int GetTotalNumberOfYellowItems(List<Shape> shapeList);
    }
}
