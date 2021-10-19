using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Model
{
    public  class Arrays
    {
         public string[] TextArray { get; set; }

        public Arrays(string [] textArray)
        {
            TextArray = textArray;
        }
        /// <summary>
        ///  Användaren skall ha möjlighet att sortera orden i dokumenten i bokstavsordning och skriva ut de första x orden till konsolen.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int FirstXWords(string [] text)
        {

            return 1;
        }

        
       
    }
}
