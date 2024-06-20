using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm.Double_Linked_List
{
    internal class DLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public DLinkedList()
        {
            head = tail = null;
        }
        public void AddBack(T data)
        {
            Node<T> NewNode = new Node<T>(data);
            NewNode.Prev = null;
            if (head == null)
            {
                head = NewNode;
                tail = NewNode;
                return;
            }
            tail.Next = NewNode;
            NewNode.Prev = tail;
            tail = tail.Next;
        }
        public void Display()
        {
            Node<T> curr=head;
            while(curr!= null)
            {
                Console.Write(curr.Val+" ");
                curr = curr.Next;
            }
            Console.WriteLine();
        }
        // add pos
        public void AddPosition(int pos,T data)
        {
            Node<T> NewNode = new Node<T>(data);
            if(pos==0)
            {
                head.Prev = NewNode;
                NewNode.Next=head;
                head= NewNode;
                return; 
            }
            int cnt = 0;
            Node<T>cur=head;
            Node<T> pr=head;
            while(cur!=null)
            {
                if(cnt==pos)
                {
                    NewNode.Next=cur;
                    NewNode.Prev=pr;
                    pr.Next = NewNode;
                    cur.Prev = NewNode;
                    return;
                }
                cnt++;
                pr=cur;
                cur= cur.Next;
            }
            if(pos==cnt)
            {
                AddBack(data);
            }
            else
                Console.WriteLine("out");
        }
        // Remove first
        // Remove Last
        // Remove Pos
        // Remove Value



    }
}
