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
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public DateTime DateCreated { get; set; }

        //to initialize the date for the menu
        //checks if date has been created, if not, initialize today's date
        //if else, checks if equals 0,0,0, if it does, initialize it with today's date

        //5.6.1.3
        //make the menu item date last modified

        //5.6.1.2
        //check if item is new has, then check for math 90 days,

        public MenuItem(double price, string description, string category, DateTime dateCreated)
        {
            Price = price;
            Description = description;
            Category = category;
            DateCreated = dateCreated;
            
            if (DateTime.Today - DateCreated >= TimeSpan.FromDays(90))
            {
                IsNew = false;
            }
            else
            {
                IsNew = true;
            }
        }

        public override string ToString()
        {
            return "Price:  " + Price + "\nDescription:  " + Description + "\nCategory:  " + Category + "\nIs item new:  " + IsNew;
        }

        /*
         * MenuItems should be the class holding all the items price, description, and category, including the date (to match with date last modified), privately, and the date it was last modified
         */
    }
}