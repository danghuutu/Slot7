using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    public delegate void MyMulticastDelegate(string msg);
    class MyClass1
    {
        public static void Print(string message) => 
            Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) => 
            Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) =>
            Console.WriteLine($"{message}");
    }

    class Program_MulticastDelegate
    {
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            MyMulticastDelegate MyDele01 = MyClass1.Print;
            MyMulticastDelegate MyDele02 = MyClass1.Show;
            Console.WriteLine("***Combines MyDele01 + MyDele02***");
            MyMulticastDelegate MyDele = MyDele01 +     MyDele02;
            MyDele(msg);
            Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03***");
            MyMulticastDelegate MyDele03 = MyClass1.Display;
            MyDele += MyDele03;
            MyDele(msg);
            Console.WriteLine("---------------------");
            Console.WriteLine("***Remove MyDele02***");
            MyDele -= MyDele02;
            MyDele("Hello World!");
            Console.ReadLine();
        }
    }
}
