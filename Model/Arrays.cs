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
        public static void FirstXWords(List<Arrays> text, int howManyWords)
        {

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine(text[i] + ", "); 
            }
            //try
            //{
            //    var query = from word in text                            
            //                select word;
            //    foreach (var word in query)
            //    {
            //        Console.WriteLine(word.TextArray);
            //    }
            //    //var sortedWords =
            //    //    from name in text
            //    //    orderby name descending
            //    //    select name//.Take(howManyWords);
            //    //foreach (string i in sortedWords)
            //    //{
            //    //    Console.Write(i);
            //    //}
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Someting went wrong");
            //}
        }
    }
}