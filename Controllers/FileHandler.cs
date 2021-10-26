using System;
using WordSearcher.Model;
using WordSearcher.View;
using System.IO;

namespace WordSearcher.Controller
{
    class FileHandler
    {
        /// <summary>
        /// Reads textfiles and turns them into separate text arrays in an array.
        /// </summary>
        public static void GetDataFromTexFile()
        {
            var fileName = "c#1000.txt";
            var text = File.ReadAllText(fileName);
            text = RemoveAllButLettersAndWhiteSpace(text);
            var text1 = new Arrays(MakeTextIntoArray(text), fileName);
            AddTextArrayToList(text1);
            fileName = "Computer programming1500.txt";
            text = File.ReadAllText(fileName);
            text = RemoveAllButLettersAndWhiteSpace(text);
            var text2 = new Arrays(MakeTextIntoArray(text), fileName);
            AddTextArrayToList(text2);
            fileName = "javascript3000.txt";
            text = File.ReadAllText(fileName);
            text = RemoveAllButLettersAndWhiteSpace(text);
            var text3 = new Arrays(MakeTextIntoArray(text), fileName);
            AddTextArrayToList(text3);
            FileHandlerView.ListsAdded(Arrays.ArrayList.Count == 3, Arrays.ArrayList.Count);
        }
        /// <summary>
        /// Turns a text into an array with only words and letters.
        /// </summary>
        /// <param name="text">The text to convert to array</param>
        /// <returns>An array of strings</returns>
        private static string[] MakeTextIntoArray(string text)
        {
            var separators = new char[] { ' ', '\n', '\r', '\t' };
            if (text != null)
            {
                return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            }
            return null;
        }
        /// <summary>
        /// Adds an array of strings to the list of arrays.
        /// </summary>
        /// <param name="textArray">The array to add to list.</param>
        private static void AddTextArrayToList(Arrays textArray)
        {
            if(textArray.TextArray != null && textArray.Name !=null)
            {
            Arrays.ArrayList.Add(textArray);
            }
        }
        /// <summary>
        /// Removes all chars but letters and white space in a string.
        /// </summary>
        /// <param name="text">The string to transform</param>
        /// <returns>A string with only letters and white space.</returns>
        public static string RemoveAllButLettersAndWhiteSpace(string text)
        {
            var builder = new System.Text.StringBuilder();
            builder.Append("");
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]) || Char.IsWhiteSpace(text[i]))
                {
                    builder.Append(text[i]);
                }
            }
            return builder.ToString();
        }
    }
}