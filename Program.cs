using WordSearcher.Controller;
using WordSearcher.View;
using System;
using WordSearcher.Controllers;
using WordSearcher.Model;

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
