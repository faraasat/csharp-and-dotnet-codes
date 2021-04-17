using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _47.Thread_Pools_and_Threads_in_Background
{
    class Program
    {
        static void Main(string[] args)
        {

            Enumerable.Range(0, 10).ToList().ForEach(f =>
            {
                new Thread(() =>
                {
                    Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} Started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} End");
                }).Start();
            });

            // Thread Pools are more secure beccause it creates specific amount of threads but take a lot of time
            Enumerable.Range(0, 10).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>   // It creates thread when available
                {
                    Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} Started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} End");
                });
            });

            // To create thread in background
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            })
            { IsBackground = true }.Start();


            Console.ReadKey();

        }
    }
}
