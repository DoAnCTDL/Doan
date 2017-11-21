using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class BangBam
    {
        public DSLK[] Table;

        public BangBam()
        {
            Table = new DSLK[26];
            for (int i = 0; i < 26; i++)
            {
                Table[i] = new DSLK();
            }
        }

        public int Bam(char c)
        {
            if (c >= 'A' && c <= 'Z')
                c = (char)((int)c + 32);
            return (int)c % 97;
        }

        public char GetFirstChar(string s)
        {
            return s[0];
        }

        //public void Duyet()
        //{
        //    for (int i = 0; i < 26; i++)
        //    {
        //        if (Table[i].Head != null)
        //            Table[i].Duyet();
        //    }
        //}

        public void Add(Word wd)
        {
            char c = GetFirstChar(wd.Name);
            int bam = Bam(c);
            bool check = Search_Check(wd.Name);
            try
            {
                if (check == true)
                    throw new Exception("This word has been added");
                Node p = new Node();
                p.CreateNode(wd);
                Table[bam].AddTail(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool Search_Check(string s)
        {
            char c = GetFirstChar(s);
            int bam = Bam(c);
            Node p = new Node();
            p = Table[bam].Head;
            while (p != null)
            {
                if (p.word.Name == s)
                    return true;
                p = p.pNext;
            }
            return false;
        }

        public Node Search_Lookup(string s)
        {
            char c = GetFirstChar(s);
            int bam = Bam(c);
            bool check = Search_Check(s);
            try
            {
                if (check == false)
                {
                    throw new Exception("HashTable doesn't have this word");
                }
                // sua
                Node p = new Node();
                p = Table[bam].Search(s);
                return p;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void RemoveWord(string s)
        {
            char c = GetFirstChar(s);
            int bam = Bam(c);
            if (s == Table[bam].Head.word.Name)
                Table[bam].RemoveHead();
            else
            {
                Node p = new Node();
                p = Table[bam].SearchTruoc(s);
                try
                {
                    if (Table[bam].Head == null || p == null || Table[bam].Head == Table[bam].Tail || p.pNext == null)
                        throw new Exception();
                    Table[bam].RemoveAfter(p);
                    //Node q = p.GetNext();
                    //p.Next(q.GetNext());
                    //if (p.GetNext() == null)
                    //    Table[bam].Tail = p;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void EditWord(string name, string meaning, string explication)
        {
            char c = GetFirstChar(name);
            int bam = Bam(c);
            bool check = Search_Check(name);
            try
            {
                if (check == false)
                {
                    throw new Exception("This word is not had in HashTable!!!");
                }
                Node p = new Node();
                p = Table[bam].Head;
                while (p != null)
                {
                    if (p.word.Name == name)
                    {
                        p.word.Meaning = meaning;
                        p.word.Explication = explication;
                    }
                    p = p.pNext;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
