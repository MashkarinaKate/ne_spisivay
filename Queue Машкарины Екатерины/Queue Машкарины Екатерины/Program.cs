using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Машкарины_Екатерины
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            bool s = true;
            int x;
            Console.Write(@"
Введите:
1 - Enqueue
2 - Deuque
3 - Peek
4 - Clear
5 - Count
6 - End" + "\n");
            while (s)
            {
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case (1): Console.WriteLine("Input: ");
                              x = int.Parse(Console.ReadLine());
                              q.Enqueue(x); break;
                    case (2):
                        try
                        {
                            Console.WriteLine("Head: {0}", q.Dequeue());
                        }
                        catch { Console.Write("Queue is empty"); }
                        break;
                    case (3):
                        try
                        {
                            Console.WriteLine("Head of this queue: {0}", q.Peek());
                        }
                        catch { Console.Write("Queue is empty"); }
                        break;
                    case (4): q.Clear(); break;
                    case (5): Console.WriteLine("Count: {0}", q.Count); break;
                    case (6): s = false; break;
                }
            }
            Console.ReadKey();
        }
    }
}
