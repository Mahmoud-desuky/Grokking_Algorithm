using Grokking_Algorithm.Chapter_2;

namespace Grokking_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var linked = new LinkedList();
            linked.addback(1);
            linked.addback(2);
            linked.addback(3);
            linked.Display();
            
            Console.WriteLine(linked.count());
            linked.addback(5);
            Console.WriteLine( linked.count());
            linked.addPos(1, 20);
            linked.Display();
        }
    }
}
