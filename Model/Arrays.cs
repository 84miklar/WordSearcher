using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearcher.Model
{
    public class Arrays
    {
         public string[] TextArray { get; set; }
        public string Name { get; set; }
        public static List<Arrays> ArrayList { get; set; }

        public Arrays(string[] textArray, string name)
        {
            TextArray = textArray;
            Name = name;
            ArrayList = new List<Arrays>();
        }        

        /// <summary>
        ///  Användaren skall ha möjlighet att sortera orden i dokumenten i bokstavsordning och skriva ut de första x orden till konsolen.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static void FirstXWords(string[] text, int antalOrd)
        {
            try
            {
                var sortedWords =
                    from name in text
                    orderby name descending
                    select name.Take(antalOrd);
                foreach (string i in sortedWords)
                {
                    Console.Write(i);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Someting went wrong");
            }
        }
    }
}