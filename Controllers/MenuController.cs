using WordSearcher.Controllers;
using WordSearcher.Model;
using WordSearcher.View;

namespace WordSearcher.Controller
{
    class MenuController
    {
        /// <summary>
        /// Sends user to different parts of the application depending on input.
        /// </summary>
        /// <param name="input">users choice in start menu/></param>
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
                    Arrays.FirstXWords(Arrays.ArrayList, ArrayController.PrintChosenAmountOfWords());
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
