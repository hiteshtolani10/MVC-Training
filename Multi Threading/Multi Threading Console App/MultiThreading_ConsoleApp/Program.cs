using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Hitesh";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is completed \n");
            Console.ReadKey();
        }

        public static void CountDown()
        {
            for(int i = 10; i >= 0; i--) 
            {
                Console.WriteLine("Timer #1 : " + i + "seconds \n");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete! \n");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + "seconds \n");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete! \n");
        }
    }
}
