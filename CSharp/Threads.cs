﻿using System;
using System.Threading;

namespace CSharp
{
    public class Threads
    {
        public void StartThreads()
        {
            var initDate = DateTime.Now;

            Thread t1 = new Thread(() =>
            {
                int count = 0;
                while (count < 5)
                {
                    Thread.Sleep(1000);
                    count++;
                }
                Console.WriteLine("I ran for 5 seconds");
            });

            Thread t2 = new Thread(() =>
            {
                int count = 0;
                while (count < 8)
                {
                    Thread.Sleep(1000);
                    count++;
                }
                Console.WriteLine("I ran for 8 seconds");
            });

            //parameterized thread
            Thread t3 = new Thread(p =>
            {
                int count = 0;
                while (count < Convert.ToInt32(p))
                {
                    Thread.Sleep(1000);

                    count++;
                }

                Console.WriteLine("I ran for {0} seconds", count);
            });
            t1.Start();
            t2.Start();
            //passing parameter to parameterized thread
            t3.Start(20);

            //wait for t1 to fimish
            t1.Join();

            //wait for t2 to finish
            t2.Join();

            //wait for t3 to finish
            t3.Join();


            Console.WriteLine("All Threads Exited in {0} secods", (DateTime.Now - initDate).TotalSeconds);
        }
    }
}
