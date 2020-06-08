using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> menuItems { get; set; }

        public DateTime LastUpdated { get; set; }


        public Menu(List<MenuItem> item)
        {
            menuItems = item;
            LastUpdated = DateTime.Today;
        }

        public Menu(List<MenuItem> item, DateTime updateTime)
        {
            menuItems = item;
            LastUpdated = updateTime;
        }

        public void AddMenu(MenuItem list)
        {
            LastUpdated = list.DateCreated;
            menuItems.Add(list);
        }

        /*
         * *** Menu Items should include list of the current date, display items, and ability to input new items and pass it to the menu items class list/dictionary
         */

        public string PrintMenu()
        {
            string output = null;
            for (int i = 0; i < menuItems.Count; i++)
            {
                output += "Price:  " + menuItems[i].Price + "\nDescription:  " + menuItems[i].Description + "\nCategory:  " + menuItems[i].Category + "\nIs item new:  " + menuItems[i].IsNew + "\n";
            }
            return output;
        }
    }
}