using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Top t = new Top();
            ThreadStart ts = new ThreadStart(t.SayHello);
            Thread thread = new Thread(ts);
            thread.Start();
            Console.Write("Thread + " + Thread.CurrentThread.GetHashCode() + "메인 종료\n");
        }
    }

    public class Top
    {
        private int limit = 0;

        public void SayHello()
        {
            while (limit < 10)
            {
                Thread th = Thread.CurrentThread;
                Console.WriteLine("Thread " + th.GetHashCode() + ":" + limit++);
            }
        }
    }
}
