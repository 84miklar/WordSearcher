using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Model
{
    public class Arrays
    {
        public string[] _testArray;


        public void SetTestArray(string[] testArray)
        {
            _testArray = testArray;
        }

        public string[] GetTestArray() => _testArray;
       
    }
}
