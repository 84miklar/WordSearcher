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

        private void AddTuplesToList()
        {
            calculatedWords.Add(this.presenceInTextOne);
            calculatedWords.Add(this.presenceInTextTwo);
            calculatedWords.Add(this.presenceInTextThree);
        }

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

        public string DisplayPrescenceInText()
        {
            var sortedList = calculatedWords.OrderBy(x => x.Item2).ToList();
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

        public override string ToString()
        {

            return $"\n\nword: \"{WordValue.ToLower()}\" \n" + $"Presence in text: \n" + DisplayPrescenceInText();
        }
    }
}
