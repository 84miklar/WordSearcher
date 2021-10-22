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
        private (string text, int amount)[] calculatedWords2 = new (string text, int amount)[3];
        //private List<(string, int)> calculatedWords = new();
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
        /// Adds all tuples in Word class to a list.
        /// </summary>
        private void AddTuplesToList()
        {
            calculatedWords2[0] = this.presenceInTextOne;
            calculatedWords2[1] = this.presenceInTextTwo;
            calculatedWords2[2] = this.presenceInTextThree;
            //calculatedWords.Add(this.presenceInTextOne);
            //calculatedWords.Add(this.presenceInTextTwo);
            //calculatedWords.Add(this.presenceInTextThree);
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
        public string DisplayPrescenceInText()
        {
            var sortedList = SortArrayOfCalculatedWords();
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
            if (returnString == builder.ToString())
            {
                return "\tNo presence in any text...\n";
            }
            return builder.ToString();
        }
        /// <summary>
        /// Sorts the amount of times a word is precense in different texts.
        /// </summary>
        /// <returns>A sorted list of tuples.</returns>
        //private List<(string, int)> SortListOfCalculatedWords()
        //{
        //    return calculatedWords.OrderBy(x => x.Item2).ToList();
        //}

        /// <summary>
        /// Sorts the amount of times a word is precense in different texts.
        /// </summary>
        /// <returns>A sorted array of tuples.</returns>
        private (string, int)[] SortArrayOfCalculatedWords()
        {
            int max = calculatedWords2.Length - 1;
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (calculatedWords2[j].amount > calculatedWords2[j + 1].amount)
                    {
                        var temp = calculatedWords2[j];
                        calculatedWords2[j] = calculatedWords2[j + 1];
                        calculatedWords2[j + 1] = temp;
                    }
                }
            }
            return calculatedWords2;
        }

        public override string ToString()
        {
            return $"\n\nword: \"{WordValue.ToLower()}\" \nPresence in text: \n" + DisplayPrescenceInText();
        }
    }
}
