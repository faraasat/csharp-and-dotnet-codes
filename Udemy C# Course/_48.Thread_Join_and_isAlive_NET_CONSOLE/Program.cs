using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _48.Thread_Join_and_isAlive_NET_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Thread Started");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            thread1.Join(); // It blocks the calling thread that is main thread in this condition because we are in main method and make the main thread wait until the thread with join is done
            Console.WriteLine("Thread1Function Done");

            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                { 
                    Console.WriteLine("Thread1 is still doing stuff");
                    Thread.Sleep(300);
                }
            }


            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function Done");
            } else
            {
                Console.WriteLine("Thread1Function Wasn't Done within 1 second");
            }


            thread2.Join();
            Console.WriteLine("Thread2Function Done");

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 is still doing stuff");
            }
            else
            {
                Console.WriteLine("Thread1 is Completed");
            }

            if (thread2.IsAlive)
            {
                Console.WriteLine("Thread2 is still doing stuff");
            }
            else
            {
                Console.WriteLine("Thread2 is Completed");
            }



            Console.WriteLine("Main Thread Ended");


        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function Started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function Comming Back To Caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function Started");
        }

    }
}
