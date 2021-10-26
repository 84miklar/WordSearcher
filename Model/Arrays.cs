using System;
using System.Collections.Generic;
using System.Linq;
using WordSearcher.View;

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
        //! Ordo (n^2)
        public static void FirstXWords(List<Arrays> listOfArray, int howManyWords)
        {
            if (listOfArray != null)
            {
                foreach (var array in listOfArray)
                {
                    Console.WriteLine("\n\n--------------");
                    Console.WriteLine(array.Name + " top " + howManyWords + ":");
                    Console.WriteLine("--------------");

                    foreach (var word in array.TextArray.OrderBy(_ => _).Take(howManyWords))
                    {
                        if (word != "")
                        {
                            Console.Write(word + ", ");
                        }
                    }
                }
            }
            else
            {
                ArraysView.SomethingWrong();
            }
        }
    }
}