using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearcher.Model
{
    public class Arrays
    {
        public string[] TextArray { get; set; }
        public string Name { get; set; }
        public static List<Arrays> ArrayList { get; set; } = new List<Arrays>();

        public Arrays(string[] textArray, string name)
        {
            TextArray = textArray;
            Name = name;
        }        

        /// <summary>
        ///  Användaren skall ha möjlighet att sortera orden i dokumenten i bokstavsordning och skriva ut de första x orden till konsolen.
        /// </summary>
        /// <param name="listOfArray"></param>
        /// <returns></returns>
        public static void FirstXWords(List<Arrays> listOfArray, int howManyWords)
        {

            
            foreach (var array in listOfArray)
            {                
                Console.WriteLine("--------------");
                Console.WriteLine(array.Name + " top " + howManyWords + ":");
                Console.WriteLine("--------------");
                
                foreach (var word in array.TextArray.OrderBy(od => od).Take(howManyWords))
                {
                    Console.WriteLine(word); 
                }
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