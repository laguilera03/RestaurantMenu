using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        
        //// Getting variable and returning
        //static public string getValue(string word)//string method have to return a string
        //{
        //    return word + " (getting and returning)";
        //}

        //// Getting variable only and storing it inside the method
        //static public void storeValue(string word)//void methods do not have to return a value
        //{
        //    word += " (storing)";
        //    Console.WriteLine("From inside the MenuItem class, we are storing: " + word);
        //}

        //// initialize the input from the user using get . set
        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(float price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        /*
         * MenuItems should be the class holding all the items price, description, and category, including the date (to match with date last modified), privately, and the date it was last modified
         */
    }
}