using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Model
{
    public class Arrays
    {
         public string[] TextArray { get; set; }
        public string Name { get; set; }
        public static List<string[]> arrayList = new List<string[]>();

        public Arrays(string[] textArray, string name)
        {
            TextArray = textArray;
            Name = name;
        }        

        
       
    }
}
