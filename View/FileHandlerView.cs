using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.View
{
    public class FileHandlerView
    {
        /// <summary>
        /// Outputs amount of texts added to the application, or error message.
        /// </summary>
        /// <param name="listsAdded">true if the amount of texts in list is same as expected.</param>
        /// <param name="count">Amount of texts in list</param>
        internal static void ListsAdded(bool listsAdded, int count)
        {
            if (listsAdded)
            {
                Console.WriteLine($"\t{count} texts added to the application.\n");
            }
            else
            {
                Console.WriteLine("\tSomething went wrong with reading one or many texts...\n");
            }
        }
    }
}
