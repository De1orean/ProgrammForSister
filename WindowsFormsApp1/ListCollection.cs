using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class ListCollection
    {
        public struct listOfWord
        {
            public List<string> engWords;
            public List<string> russWords;
            public string nameOfList;
        }

        public List <listOfWord> Collection = new List<listOfWord>();
    }
}
