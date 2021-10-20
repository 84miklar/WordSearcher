using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Model
{
    class Word
    {
        public string WordValue { get; set; }
        public int presenceInTextOne = 0;
        public int presenceInTextTwo = 0;
        public int presenceInTextThree = 0;

        public Dictionary<string, int> dictionary = new Dictionary<string, int>();
        public Word(string word)
        {
            WordValue = word.ToUpper();
            foreach (var arr in Arrays.ArrayList)
            {
                CalculatePresenceInText(arr);
            }
            
        }

        public void CalculatePresenceInText(Arrays textArray)
        {
            for (int i = 0; i < textArray.TextArray.Length; i++)
            {
                if (textArray.TextArray[i] == WordValue)
                {
                    if (textArray.Name == "c#1000.txt")
                    {
                        presenceInTextOne++;
                        dictionary.Add(textArray.Name, presenceInTextOne);
                    }
                    if (textArray.Name == "Computer programming1500.txt")
                    {
                        presenceInTextTwo++;
                        dictionary.Add(textArray.Name, presenceInTextTwo);
                    }
                    if (textArray.Name == "javascript3000.txt")
                    {
                        presenceInTextThree++;
                        dictionary.Add(textArray.Name, presenceInTextThree);
                    }
                }
            }
        }
        public string DisplayPrescenceInText()
        {
           
            var sortedDict = dictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in dictionary)
            {
             return $"{dictionary.Keys}: {dictionary.Values} times";
            }
            return "";
        }

        public override string ToString()
        {
            return $"\n\nword: \"{WordValue.ToLower()}\" \n" + $"Presence in text: \n" + DisplayPrescenceInText();
        }
    }
}
