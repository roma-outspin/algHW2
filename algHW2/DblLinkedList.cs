using System;
using System.Collections.Generic;
using System.Text;

namespace algHW2
{
    public class DblLinkedList : ILinkedList
    {
        Node head;
        Node tail;

        public void AddNode(int value)
        {
            if(head==null)
            {
                head = new Node() { Value = value };
            } 
            else if (tail==null)
            {
                tail = new Node() { Value = value, PrevNode = head };
                head.NextNode = tail;
            }
            else
            {
                var temp = new Node() { Value = value, PrevNode = tail };
                tail.NextNode = temp;
                tail = temp;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node() {Value = value, PrevNode = node, NextNode = node.NextNode };
            node.NextNode = newNode;

        }

        public Node FindNode(int searchValue)
        {
            var currentNode = head;
            while(currentNode!=null)
            {
                if (currentNode.Value==searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            var result = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                result++;
                currentNode = currentNode.NextNode;
            }
            return result;
         }

        public void RemoveNode(int index)
        {
            if (index == 0)
            {
                head.NextNode.PrevNode = null;
                head = head.NextNode;
            } else if (index == GetCount()-1)
            {
                tail.PrevNode.NextNode = null;
                tail = tail.PrevNode;
            } else
            {
                var currentNode = head.NextNode;
                var currentIndex = 1;
                while (currentNode != null)
                {
                    if (currentIndex == index)
                    {
                        currentNode.PrevNode.NextNode = currentNode.NextNode;
                        currentNode.NextNode.PrevNode = currentNode.PrevNode;
                    }
                    currentNode = currentNode.NextNode;
                }
            }
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
