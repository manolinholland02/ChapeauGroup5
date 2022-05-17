using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class TableOrder
    {
        public int TableID { get; set; }
        public double TotalPrice { get; set; }
        List<MenuItem> WholeTableOrder { get; set; }
        List<MenuItem> NewOrder { get; set; }

        Dictionary<int, string> OrderComments { get; set; }
    }
}
