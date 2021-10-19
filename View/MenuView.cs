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
            FileHandler.GetDataFromTexFile();
            while (keepGoing)
            {
                
                Console.WriteLine("Welcome");
                Console.WriteLine("1. Get data from text files\n" +
                    "2. Search for a word\n" +
                    "3. Print all searched words\n" +
                    "4. Print a certain number of words\n" +
                    "5. Exit");
                var choice = ControlHelper.TryParse();
                MenuController.StartMenu(choice);
                if (choice != 5) ControlHelper.PressEnter();
            }
        }
        /// <summary>
        /// Output if menu choice is >5.
        /// </summary>
        public static void DefaultView()
        {
            Console.WriteLine("Invalid choice. Input must be 1-5.");
        }
    }
}
