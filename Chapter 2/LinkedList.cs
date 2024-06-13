using System;
using System.Collections.Generic;
using System.Linq;
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
        public void addback(int data)
        {
            var newnode = new Node(data);
            if (head == null)
                head = newnode;
            else  // 
            {
                // the same of add in back
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
        public int count()
             {
                var temp = head;
                int cnt = 0;
                while (temp != null)
                {
                    cnt++;
                   // Console.Write(temp.Val + " ");
                    temp = temp.Next;
                }
                return cnt;
            }
        // add in pos
        public void addPos(int pos,int data)
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
            //  1 2 3 4 
            while (nx != null&&cnt<pos)
            {
                cnt++;
                // Console.Write(temp.Val + " ");
                pr = nx;
                nx = nx.Next;
            }
            // the same of add int front
            if(nx==pr)
            {
                head = newnode;
                head.Next = pr;
                return;
            }
            pr.Next = newnode;
            newnode.Next = nx;
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


    }
}
