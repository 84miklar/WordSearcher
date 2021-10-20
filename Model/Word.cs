using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Controllers;

namespace WordSearcher.Model
{
    class Word
    {
        public string WordValue { get; set; }
        public (string text, int amount) presenceInTextOne;
        public (string text, int amount) presenceInTextTwo;
        public (string text, int amount) presenceInTextThree;

        public List<(string, int)> calculatedWords = new List<(string, int)>();
        
        public Word(string word)
        {
            WordValue = word.ToLower();

            foreach (var arr in Arrays.ArrayList)
            {
                CalculatePresenceInText(arr);
            }
            AddTuplesToList();
        }
        /// <summary>
        /// Adds all tuples in Word class to a list. 
        /// </summary>
        private void AddTuplesToList()
        {
            calculatedWords.Add(this.presenceInTextOne);
            calculatedWords.Add(this.presenceInTextTwo);
            calculatedWords.Add(this.presenceInTextThree);
        }
        /// <summary>
        /// Calculates the presence of a word in an array of strings.
        /// Sets the name and presence amount to a tuple.
        /// </summary>
        /// <param name="textArray">The array to check for words in</param>
        private void CalculatePresenceInText(Arrays textArray)
        {
            for (int i = 0; i < textArray.TextArray.Length; i++)
            {
                if (textArray.TextArray[i].ToLower() == WordValue)
                {
                    if (textArray.Name == "c#1000.txt")
                    {
                        presenceInTextOne.text = textArray.Name;
                        presenceInTextOne.amount++;
                    }
                    if (textArray.Name == "Computer programming1500.txt")
                    {
                        presenceInTextTwo.text = textArray.Name;
                        presenceInTextTwo.amount++;
                    }
                    if (textArray.Name == "javascript3000.txt")
                    {
                        presenceInTextThree.text = textArray.Name;
                        presenceInTextThree.amount++;
                    }
                }
            }
        }
        /// <summary>
        /// Puts together a string with info about words precense in a text, if filename is not null.
        /// </summary>
        /// <returns>A string with filename and amount of times a word is precense i a text.</returns>
        public string DisplayPrescenceInText()
        {
            var sortedList = SortListOfCalculatedWords();
            var returnString = "";
            var builder = new StringBuilder();
            builder.Append(returnString);
            foreach (var item in sortedList)
            {
                if (item.Item1 != null)
                {
                    builder.Append($"\t{item.Item1}: {item.Item2} times\n");
                }
            }

            return returnString = builder.ToString();
        }
        /// <summary>
        /// Sorts the list by how many times a word is precense in a text.
        /// </summary>
        /// <returns>A sorted list of tuples.</returns>
        private List<(string, int)> SortListOfCalculatedWords()
        {
            return calculatedWords.OrderBy(x => x.Item2).ToList();
        }

        public override string ToString()
        {

            return $"\n\nword: \"{WordValue.ToLower()}\" \n" + $"Presence in text: \n" + DisplayPrescenceInText();
        }
    }
}
