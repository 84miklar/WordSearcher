using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Model
{
    public static class Arrays
    {
        static string[] TestArray { get; set; }


        public static void SetTestArray(string[] testArray)
        {
            TestArray = testArray;
            
        }

        public static string[] GetTestArray() => TestArray;
       
    }
}
