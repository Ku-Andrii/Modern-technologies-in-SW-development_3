using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTD_Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton l1 = Singleton.GetInstance();
            l1.WriteNumber(20);
            Console.WriteLine(l1.Value);
            Console.ReadKey();
        }
    }
}