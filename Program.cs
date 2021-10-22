using WordSearcher.Controller;
using WordSearcher.View;
using System;

namespace WordSearcher
{
    class Program
    {
        static void Main()
        {
            FileHandler.GetDataFromTexFile();
            MenuView.StartMenu();
        }
    }
}
