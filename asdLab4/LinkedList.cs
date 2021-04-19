using System;

namespace asdLab4
{
    public class Element
    {
        public int Data;
        public readonly Element Previous;

        public Element(int data, Element previous)
        {
            Data = data;
            Previous = previous;
        }
    }

    public struct LinkedList
    {
        public Element Tail;

        public void Add(int data)
        {
            if (Tail == null)
            {
                Tail = new Element(data, null);
            }
            else
            {
                Element newElement = new Element(data, Tail);
                Tail = newElement;
            }
        }

        public void Print()
        {
            Element current = Tail;
            string result = "";
            do
            {
                string newstr = $"{current.Data}\t";
                newstr += result;
                result = newstr;
                current = current.Previous;
            } while (current != null);

            Console.WriteLine(result);
        }

        public void Remove(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Tail = Tail.Previous;
            }
        }
    }
}