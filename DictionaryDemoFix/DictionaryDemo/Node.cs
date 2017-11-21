using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class Node
    {
        public Word word { get; set; }
        public Node pNext { get; set; }

        public Node()
        {
            word = new Word(null, null,null);
            pNext = null;
        }

        public void CreateNode(Word wd)
        {
            word.Name = wd.Name;
            word.Meaning = wd.Meaning;
            word.Explication = wd.Explication;
            pNext = null;
        }
    }
}
