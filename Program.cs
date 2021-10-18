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
           // MenuView.StartMenu();
            var aWord = new Word("hej", 20, 30, 40);
            NodeHandler nodehandler = new NodeHandler(aWord);
            var bWord = new Word("hoj", 20, 30, 40);
            nodehandler.SaveData(bWord);
            var cWord = new Word("bara", 20, 30, 40);
            nodehandler.SaveData(cWord);
            var dWord = new Word("order", 20, 30, 40);
            nodehandler.SaveData(dWord);
            var eWord = new Word("orber", 20, 30, 40);
            nodehandler.SaveData(eWord);
            var fWord = new Word("apa", 20, 30, 40);
            nodehandler.SaveData(fWord);
            nodehandler.DisplayNodes();
        }
    }
}
