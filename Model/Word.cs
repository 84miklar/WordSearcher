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
        public int PresenceInTextOne { get; set; }
        public int PresenceInTextTwo { get; set; }
        public int PresenceInTextThree { get; set; }
        public Word(string word, int presenceInTextOne, int presenceInTextTwo, int presenceInTextThree)
        {
            WordValue = word.ToUpper();
            PresenceInTextOne = presenceInTextOne;
            PresenceInTextTwo = presenceInTextTwo;
            PresenceInTextThree = presenceInTextThree;
        }

       
        public override string ToString()
        {
            string display = $"\n\nword: {WordValue}\n" + $"Presence in text: \n" + $"One: {PresenceInTextOne} times\n" + $"Two: {PresenceInTextTwo} times " + $"\n" +
                $"Three: {PresenceInTextThree} times";
            return display;
        }
    }
}
