using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    class Square:Shape
    {
        public Square(string color)
        {
            ShapeName = "Square";
            Color = color;
            Cost = 1;
        }

    }
}
