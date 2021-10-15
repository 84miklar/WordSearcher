using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Controller;

namespace WordSearcher.View
{
    class MenuView
    {
        public static void StartMenu()
        {
            Console.WriteLine("Welcome");
            FileHandler.GetDataFromTexFile();
            //Alla menyval.
            //Man skickas direkt vidare till controller för input.
        }
    }
}
