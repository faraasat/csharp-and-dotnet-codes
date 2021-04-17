using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _45.Threds_Basic_NET_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World 3");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World 4");

            new Thread(() =>
            {
                Console.WriteLine("Thread 1");
                Thread.Sleep(1000);
            }).Start();
            new Thread(() =>
            {
                Console.WriteLine("Thread 2");
                Thread.Sleep(1000);
            }).Start();
            new Thread(() =>
            {
                Console.WriteLine("Thread 3");
                Thread.Sleep(1000);
            }).Start();
            new Thread(() =>
            {
                Console.WriteLine("Thread 4");
                Thread.Sleep(1000);
            }).Start();

            Console.ReadKey();

        }
    }
}
