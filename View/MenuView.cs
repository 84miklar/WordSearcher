using System;
using WordSearcher.Controller;
using WordSearcher.Controllers;
using WordSearcher.Model;

namespace WordSearcher.View
{
    public class MenuView
    {
        public static bool keepGoing = true;
        public static void StartMenu()
        {
            
            while (keepGoing)
            {
                
                Console.WriteLine("Welcome");
                Console.WriteLine("1. Search for a word\n" +
                    "2. Print all searched words\n" +
                    "3. Print a certain number of words\n" +
                    "4. Exit");
                var choice = ControlHelper.TryParse();
                MenuController.StartMenu(choice);
                if (choice != 4) ControlHelper.PressEnter();
            }
        }
        /// <summary>
        /// Output if menu choice is >4.
        /// </summary>
        public static void DefaultView()
        {
            Console.WriteLine("Invalid choice. Input must be 1-4.");
        }
    }
}
