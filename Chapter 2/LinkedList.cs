using System;

namespace Grokking_Algorithm.Chapter_2
{
    public class SLinkedList<T>
    {
        private Node<T> head;

        public SLinkedList()
        {
            head = null;
        }
        public void AddBack(T data)
        {
            // new Node
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        public void Display()
        {
            var temp = head;
            while (temp != null)
            {
                Console.Write(temp.Val + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void DisplayReversed()
        {
            PrintRecursion(head);
        }

        private void PrintRecursion(Node<T> temp)
        {
            if (temp == null)
                return;

            PrintRecursion(temp.Next);
            Console.Write(temp.Val + " ");
        }

        public int Count()
        {
            Node<T> temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public void AddPos(int pos, T data)
        {
            int count = Count();
            if (count < pos)
            {
                Console.WriteLine("Out of scope");
                return;
            }

            int currentPosition = 1;
            Node<T> prev = head;
            Node<T> curr = head;
            Node<T> newNode = new Node<T>(data);

            while (curr != null && currentPosition < pos)
            {
                currentPosition++;
                prev = curr;
                curr = curr.Next;
            }

            if (curr == prev)
            {
                head = newNode;
                head.Next = prev;
                return;
            }

            prev.Next = newNode;
            newNode.Next = curr;
        }

        public void InsertFront(T data)
        {
            var newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        public bool Find(T data)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.Val.Equals(data))
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        public int FindIndex(T data)
        {
            Node<T> temp = head;
            int count = 0;
            while (temp != null)
            {
                if (temp.Val.Equals(data))
                    return count;
                temp = temp.Next;
                count++;
            }
            return -1;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void RemovePos(int idx)
        {
            if (idx == 0 && head != null)
            {
                head = head.Next;
                return;
            }

            int count = 0;
            var temp = head;
            var prev = temp;

            while (temp != null)
            {
                if (count == idx)
                {
                    prev.Next = temp.Next;
                    return;
                }
                prev = temp;
                temp = temp.Next;
                count++;
            }

            Console.WriteLine("Index not found");
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Is empty");
                return;
            }
            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("Is empty");
                return;
            }

            if (Count() == 1)
            {
                head = null;
                return;
            }

            Node<T> temp = head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }

        public void ReverseItrative()
        {
            Node<T> prev = null;
            Node<T> current = head;

            while (current != null)
            {
                Node<T> next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }
    }
}
