using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MTD_Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(FirstThreadEntryPoint);
            var thread2 = new Thread(SecondThreadEntryPoint);

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }
        private static void FirstThreadEntryPoint()
        {
            Singleton l1 = Singleton.GetInstance();
            Console.WriteLine(l1.WriteNumber(20));
        }
        private static void SecondThreadEntryPoint()
        {
            Singleton l2 = Singleton.GetInstance();
            Console.WriteLine(l2.WriteNumber(24));
        }
    }
}
