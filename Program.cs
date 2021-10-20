using System;
using WordSearcher.Controller;
using WordSearcher.Controllers;
using WordSearcher.Model;
using WordSearcher.View;

namespace WordSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler.GetDataFromTexFile();
            MenuView.StartMenu();

        }
    }
}
