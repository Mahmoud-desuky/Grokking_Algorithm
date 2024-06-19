using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grokking_Algorithm.Chapter_2
{
    public class LinkedList
    {
        private Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddBack(int data)
        {
            // new Node
            var newnode = new Node(data);
            if (head == null)
                head = newnode;
            else  
            {
                var temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newnode;
            }
        }
        public void Display()
        {
            var temp = head;
            int cnt = 0;
            while (temp != null)
            {
                   
                Console.Write(temp.Val+ " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public void DisplayReversed()
        {
            PrintRecursion(head);
        }
        public void PrintRecursion(Node temp)
        {
            if (temp == null)
                return;
            PrintRecursion(temp.Next);
            Console.Write(temp.Val + " ");
        }
        public int count()
             {
                var temp = head;
                int cnt = 0;
                while (temp != null)
                {
                    cnt++;
                    temp = temp.Next;
                }
                return cnt;
            }
        public void AddPos(int pos,int data)
        {
            int cnt = count();
            if(cnt<pos)
            {
                Console.WriteLine("out of scope");
                return;
            }
             cnt = 1;
            var pr = head;
            var nx = head;
             Node newnode=new Node(data);
            while (nx != null&&cnt<pos)
            {
                cnt++;
                pr = nx;
                nx = nx.Next;
            }
            if(nx==pr)
            {
                head = newnode;
                head.Next = pr;
                return;
            }
            pr.Next = newnode;
            newnode.Next = nx;
        }
        public void insertFront(int data)
        {
            var newnode=new Node(data);
            newnode.Next = head;
            head = newnode;
        }
        public bool Find(int Data) {
            var temp = head;
            while(temp.Next.Next != null)
            {
                if (temp.Val==Data)
                    return true;
                temp = temp.Next;
            }
            temp.Next = null;
            return false;
        }
        public int Findindex(int data)
        {
            var temp = head;
            int cnt = 0;
            while (temp!=null)
            {
                if(temp.Val==data)
                    return cnt;
                temp = temp.Next;
                cnt++;
            }
            return -1;
        }
        public bool isEmpty()
        {
            return head == null;
        }
        public void RemovePos(int idx)
        {
            if(idx==0&&head!=null)
            {
                head=head.Next;
                return;
            }
            int cnt = 0;
            var temp = head;
            var previous = temp;
            while (temp!=null)
            {
                if(cnt==idx)
                {
                    previous.Next = temp.Next;
                    return;
                }
                previous = temp;
                temp = temp.Next;
            }
            Console.WriteLine("index Not Found");
        }
        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Is Empty");
                return;
            }
            head = head.Next;
        }
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("Is Empty");
                return;
            }
            if (count() == 1)
                head = null;
            var temp = head;
            while(temp.Next.Next!=null) {
                temp=temp.Next;
            }
            temp.Next = null;

        }


    }
}
