using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int MenuItemID { get; set; }

        public string MenuItemName { get; set; }

        public decimal MenuItemPrice { get; set; }

        public bool isFood { get; set; }

        public int MenuItemStock { get; set; }

        public MenuType MenuItemType { get; set; }

        public MenuItemCategory MenuItemCategory { get; set; } 
    }
}
