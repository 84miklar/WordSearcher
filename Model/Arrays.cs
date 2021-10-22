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
        ///  Sorts ListArray and Prints input-Words from each Array
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

                foreach (var word in array.TextArray.OrderBy(_ => _).Take(howManyWords))
                {
                    if (word != "")
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}