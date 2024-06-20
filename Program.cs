using Grokking_Algorithm.Chapter_2;
using Grokking_Algorithm.Double_Linked_List;

namespace Grokking_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          DLinkedList<int> list = new DLinkedList<int>();
            list.AddBack(5);
            list.AddBack(6);
            list.AddBack(7);
            list.Display();
            list.AddPosition(0, 10);
            list.AddPosition(2, 20);


            list.Display(); 
            
        }
    }
}
