using Grokking_Algorithm.Chapter_2;

namespace Grokking_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
            SLinkedList<int> linked = new SLinkedList<int>();
            linked.AddBack(1);
            linked.AddBack(2);
            linked.AddBack(3);
            linked.Display();
            
            Console.WriteLine(linked.Count());
            linked.AddBack(5);
            Console.WriteLine( linked.Count());
            linked.AddPos(1, 20);
            linked.Display();
           // linked.DisplayReversed();
           linked.ReverseItrative();
            linked.Display();
            //
            linked.ReverseItrative();
            linked.Display();
            
            
        }
    }
}
