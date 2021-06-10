using System;
using System.Collections.Generic;
using System.Text;

namespace algHW2
{
    public class TestCase
    {
        public DblLinkedList TestedList { get; set; }
        public int Value { get; set; }
        public int ExpectedLength { get; set; }
        public Node ExpectedNode { get; set; }

        public TestCase(int nodesNumber)
        {
            TestedList = new DblLinkedList();
            for(int i = 0; i < nodesNumber;i++)
            {
                TestedList.AddNode(i + 1);
            }
        }
    }
}
