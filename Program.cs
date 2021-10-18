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
            var aWord = new Word("hej", 20,30,40);
            NodeHandler nodehandler = new NodeHandler(aWord);
            var bWord = new Word("hoj", 20, 30, 40);
            nodehandler.SaveData(bWord);


            //MenuView.StartMenu();
        }

     
    }
}
