using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    MenuView.keepGoing = false;
                    break;
                default:
                    if (input > 5)
                        MenuView.DefaultView();
                    break;
            }
        }
    }
}
