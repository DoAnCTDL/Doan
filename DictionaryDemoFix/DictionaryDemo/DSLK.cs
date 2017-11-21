using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class DSLK
    {
        public Node Head;
        public Node Tail;

        public DSLK()
        {
            Head = Tail = null;
        }

        public void AddHead(Node p)
        {
            if (Head == null)
                Head = Tail = p;
            else
            {
                p.pNext = Head;
                Head = p;
            }
        }

        public void AddTail(Node p)
        {
            if (Head == null)
                Head = Tail = p;
            else
            {
                Tail.pNext = p;
                Tail = p;
            }
        }

        //public void Duyet()
        //{
        //    Node p = Head;
        //    try
        //    {
        //        if (p == null)
        //            throw new Exception("Empty List");
        //        while (p != null)
        //        {
        //            Console.WriteLine("{0} {1}", p.word.Name, p.word.Meaning);
        //            p = p.pNext;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        public Node Search(string s)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.word.Name == s)
                    return p;
                p = p.pNext;
            }
            return null;
        }

        public Node SearchTruoc(string s)
        {
            Node p = Head.pNext;
            Node q = Head;
            if (Head != Tail)
            {
                while (p != null)
                {
                    if (p.word.Name == s)
                        return q;
                    p = p.pNext;
                    q = q.pNext;
                }
            }
            return null;
        }

        public void AddAfter(Node p, Node q)
        {
            try
            {
                if (Head == null)
                    throw new Exception("Can not Add");
                q.pNext = p.pNext;
                p.pNext = q;
                if (p == Tail)
                    Tail = q;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveHead()
        {
            try
            {
                if (Head == null)
                    throw new Exception("Empty List");
                Node p = Head;
                Head = p.pNext;
                p = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveAfter(Node p)
        {
            try
            {
                if (Head == null)
                    throw new Exception("Can not Remove");
                Node q = p.pNext;
                p.pNext = q.pNext;
                if (p.pNext == null)
                    Tail = p;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
