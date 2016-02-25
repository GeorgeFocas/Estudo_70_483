using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void ThreadMethod()
        {
            Console.WriteLine("Estou na outra thread");
            Thread.Sleep(5000);
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            //t.IsBackground = false;
            t.Start();
        }
    }
}
