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
                    Model.Arrays.FirstXWords(Model.Arrays.ArrayList, 100);
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
