using System;

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
            var item = new MenuItem();
            item.food;

        }
    }
}