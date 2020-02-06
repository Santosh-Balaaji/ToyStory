using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ToyFactory
{
    class Circle:Shape
    {
        public Circle (string color) 
        {

            ShapeName = "Circle";
            Color = color;
            Cost = 3;
        }

      
    }
}
