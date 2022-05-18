using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class TableOrder
    {
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }

        Dictionary<int, string> OrderComments { get; set; }
    }
}
