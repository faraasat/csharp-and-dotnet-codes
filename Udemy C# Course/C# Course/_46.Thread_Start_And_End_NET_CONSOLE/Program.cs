using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _46.Thread_Start_And_End_NET_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} ended");
            });
            Console.WriteLine($"Thread Number: {thread.ManagedThreadId}");
            thread.Start();

            var test = taskCompletionSource.Task.Result;
            Console.WriteLine(test);

            Console.ReadLine();

        }
    }
}
