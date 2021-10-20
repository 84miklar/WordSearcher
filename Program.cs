using WordSearcher.Controller;
using WordSearcher.View;

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
