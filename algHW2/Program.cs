using System;

namespace algHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new DblLinkedList();
            test.AddNode(1);
            test.AddNode(2);
            test.AddNode(3);
            test.AddNode(4);
            test.AddNode(5);

            Console.WriteLine(test.FindNode(3).NextNode.Value); 
        }
    }
}
