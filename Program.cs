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
            //MenuView.StartMenu();
            NodeController nodehandler = new NodeController(new Word("hej"));
            nodehandler.SaveData(new Word("hoj"));
            nodehandler.SaveData(new Word("bara"));
            nodehandler.SaveData(new Word("order"));
            nodehandler.SaveData(new Word("order"));
            nodehandler.SaveData(new Word("orber"));
            nodehandler.SaveData(new Word("apa"));
            nodehandler.DisplayNodes();
        }
    }
}
