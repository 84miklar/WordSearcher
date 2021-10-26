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
        private (string text, int amount)[] calculatedWords = new (string text, int amount)[3];
        //Constructor
        public Word(string word)
        {
            if (word != null)
            {
                WordValue = word.ToLower().Trim();
            }

            foreach (var arr in Arrays.ArrayList)
            {
                CalculatePresenceInText(arr);
            }
            AddTuplesToList();
        }
        /// <summary>
        /// Adds all tuples in Word class to an array.
        /// </summary>
        private void AddTuplesToList()
        {
            calculatedWords[0] = this.presenceInTextOne;
            calculatedWords[1] = this.presenceInTextTwo;
            calculatedWords[2] = this.presenceInTextThree;
        }
        /// <summary>
        /// Calculates the presence of a word in an array of strings.
        /// Sets the name and presence amount to a tuple.
        /// </summary>
        /// <param name="textArray">The array to check for words in</param>
        private void CalculatePresenceInText(Arrays textArray)
        {
            if (textArray.TextArray != null)
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
        }
        /// <summary>
        /// Puts together a string with info about words precense in a text, if filename is not null.
        /// </summary>
        /// <returns>A string with filename and amount of times a word is precense i a text.</returns>
        /// Ordo = O(n + 3)
        public string DisplayPrescenceInText()
        {
            var sortedList = SortArrayOfCalculatedWords();
            var builder = new StringBuilder();
            builder.Append("");
            foreach (var item in sortedList)
            {
                if (item.Item1 != null)
                {
                    builder.Append($"\t{item.Item1}: {item.Item2} times\n");
                }
            }
            if (builder.ToString()=="")
            {
                return "\tNo presence in any text...\n";
            }
            return builder.ToString();
        }
        /// <summary>
        /// Sorts the amount of times a word is precense in different texts.
        /// </summary>
        /// <returns>A sorted array of tuples.</returns>
        /// Ordo = O(n^2)
        private (string, int)[] SortArrayOfCalculatedWords()
        {
            //The slow Bubble Sort i Ok here. The length of the array will never be longer than 3 at this moment.
            var max = calculatedWords.Length - 1;
            for (int i = 0; i < max; i++)
            {
                var nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (calculatedWords[j].amount > calculatedWords[j + 1].amount)
                    {
                        var temp = calculatedWords[j];
                        calculatedWords[j] = calculatedWords[j + 1];
                        calculatedWords[j + 1] = temp;
                    }
                }
            }
            return calculatedWords;
        }

        public override string ToString()
        {
            return $"\n\nword: \"{WordValue.ToLower()}\" \nPresence in text: \n" + DisplayPrescenceInText();
        }
    }
}
