using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class Word
    {
        private string name;
        private string meaning;
        private string explication;

        public Word(string name, string meaning, string explication)
        {
            this.name = name;
            this.meaning = meaning;
            this.explication = explication;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Meaning
        {
            set { meaning = value; }
            get { return meaning; }
        }
        public string Explication
        {
            set { explication = value; }
            get { return explication; }
        }
    }
}
