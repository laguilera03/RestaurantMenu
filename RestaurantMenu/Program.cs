using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask User If They Want to See the Menu
            // Ask User If They Want to Add a Menu Item

            // Display Menu Items
            // Give User Prompt to Input Those Menu Items
            //Console.WriteLine("Enter Menu Item");
            //string inputMenu = Console.ReadLine();

            //// Value User Input
            //Console.WriteLine("You Input: " + inputMenu);

            //// Value that the console Send to the MenuItem Class, and then returned it to the Program class
            //Console.WriteLine("You Passed " + inputMenu + " to the GetValue Method and it returned: " + MenuItem.getValue(inputMenu));

            //// Send variable to the MenuItem Class
            //Console.WriteLine("This line is from the Program class/ Main method and the following line will be from the MenuItem Class/ storeValue method: ");
            //MenuItem.storeValue(inputMenu);

            // Starting the MenuItem Class and setting it as a variable item
            // var item = new MenuItem();

            /*
             * 
            //Create several items and add them to a menu.
            //Print the entire, updated menu to the screen.
            //Print an individual menu item to the screen.
            //Delete an item from a menu, then reprint the menu
             *
            */

            var testDate = new DateTime(2020, 03, 21);//today's date

            var item = new MenuItem(2.99, "TestItem", "Appetizer", testDate);

            var testMenu = new Menu(item, testDate);

            //testMenu.AddMenuItem(test);
   

            //Console.WriteLine(test.ToString());
            Console.WriteLine(testMenu.PrintMenu());
        }
    }
}