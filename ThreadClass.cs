using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ThreadsExample
{
    internal class ThreadClass
    {

        public static void WriteChar(char ch, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(20);
                Console.Write(ch);
            }
        }

        public static void Method2()
        {
            Console.WriteLine("Second Thread {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('2', 80, ConsoleColor.Blue);

            var thread = new Thread(Method3);
            thread.Start();
            thread.Join();

            WriteChar('2', 80, ConsoleColor.Blue);
            Console.WriteLine("Second thread finished");
        }

        private static void Method3()
        {
            Console.WriteLine("Third Thread {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('3', 100, ConsoleColor.Yellow);
            Console.WriteLine("Third Thread finished");
        }
    }
}
