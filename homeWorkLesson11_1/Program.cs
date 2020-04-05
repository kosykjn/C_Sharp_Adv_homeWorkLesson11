using System;
using System.Threading;

namespace homeWorkLesson11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} ID главного потока!");
            new Thread(Method).Start();
        }

        static void Method()
        {
            Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} ID вторичного потока!");

            //Some work...
            Thread.Sleep(500);

            Thread thread = new Thread(Method);
            thread.Start();
        }
    }
}
