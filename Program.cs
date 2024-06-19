using Grokking_Algorithm.Chapter_2;

namespace Grokking_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var linked = new LinkedList();
            linked.AddBack(1);
            linked.AddBack(2);
            linked.AddBack(3);
            linked.Display();
            
            Console.WriteLine(linked.count());
            linked.AddBack(5);
            Console.WriteLine( linked.count());
            linked.addPos(1, 20);
            linked.Display();
            linked.DisplayReversed();
        }
    }
}
