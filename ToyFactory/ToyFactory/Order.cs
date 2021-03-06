﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ToyFactory
{
    class Order
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string DueDate { get; set; }
        public List<List<Shape>> ShapeList { get; set; }
        public static string OrderID{get; set;} 
        public static int orderCount = 0;

        public Order()
        {

        }
       

        public static string GenerateOrderID()
        {
            if (orderCount < 10)
            {
                orderCount++;
                OrderID = "000" + orderCount;
            }
            else if (orderCount < 100)
            {
                orderCount++;
                OrderID = "00" + orderCount;
            }

            return OrderID;

        }
    }
}
