using System;

namespace asdLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter few integer numbers. When all numbers are entered, type 'end'");
            LinkedList linkedList = new LinkedList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (int.TryParse(input, out int number)) linkedList.Add(number);
                else Console.WriteLine("Wrong input. Please, enter integer numbers");
                input = Console.ReadLine();
            }

            Console.WriteLine("Input list is:");
            linkedList.Print();
            int sum = linkedList.Tail.Data + linkedList.Tail.Previous.Data;
            
            // listInt.Remove(2); 
            // listInt.Add(sum);
            // listInt.Add(sum);
            
            if (linkedList.Tail.Previous != null)
            {
                linkedList.Tail.Data = sum;
                linkedList.Tail.Previous.Data = sum;
                Console.WriteLine("Changed list is:");
                linkedList.Print();
            }
        }
    }
}