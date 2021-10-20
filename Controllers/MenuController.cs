using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Controllers;
using WordSearcher.View;


namespace WordSearcher.Controller
{
    class MenuController
    {
        public static void StartMenu(int input)
        {
            switch (input)
            {
                case 1:
                    WordController.SearchWord();
                    break;
                case 2:
                    WordController.PrintWordsInTree();
                    break;
                case 3:
                    
                    break;
                case 4:
                    MenuView.keepGoing = false;
                    break;
                    
                default:
                    if (input > 4)
                        MenuView.DefaultView();
                    break;
            }
        }
    }
}
