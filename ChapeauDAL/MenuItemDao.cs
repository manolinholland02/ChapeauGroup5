using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;


namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            string query = @"
            SELECT [menuItemId]
            ,[menuItemName]
            ,[menuItemPrice]
            ,[isFoodOrDrink]
            ,[menuItemStock]
             ,[menuItemType]
            ,[menuItemCategory]
            FROM [dbo].[MenuItems]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemID = (int)dr["menuItemId"],
                    MenuItemName = dr["menuItemName"].ToString(),
                    MenuItemPrice = (decimal)dr["menuItemPrice"],
                    isFood = (bool)dr["isFoodOrDrink"],
                    MenuItemStock = (int)dr["menuItemStock"],
                    MenuItemType = (MenuType)dr["menuItemType"],
                    MenuItemCategory = (MenuItemCategory)dr["menuItemCategory"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}

