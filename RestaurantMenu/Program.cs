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

            //print current date
            Console.WriteLine(DateTime.Today);

            //retrieve Menu
            var AddMenu = new List<MenuItem>();
            //call function to retrieve all items currently in menu

            var testMenu = new Menu(AddMenu);
            Console.WriteLine("Menu:\n" + testMenu.PrintMenu());//(should be empty list for now)

            //present options

            //user selects add menu items
            //user inputs menu items
            var testDate = new DateTime(2020, 03, 21);//gets user input
            var test = new MenuItem(1.99, "Salad", "Appetizer", testDate);
            Console.WriteLine("Sanity Check:\n" + test);//check content (sanity check)
            //check if menu item input is included already in menu
            //add the menu item to the list
            testMenu.AddMenu(test);

            //user wants to add more items
            test = new MenuItem(12.99, "Burger", "Main", testDate);
            testMenu.AddMenu(test);
            test = new MenuItem(2.99, "Ice Cream", "Dessert", testDate);
            testMenu.AddMenu(test);
            Console.WriteLine("Sanity Check for Items Added:\n" + testMenu.PrintMenu());

            //user selects delete
        }
    }
}