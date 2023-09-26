using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    public delegate void MyPassingDelegate(string msg);
    class MyClass
    {
        public static void Print(string message) =>
            Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) =>
            Console.WriteLine($"{message.ToLower()}");
    }
    class Program_PassingDelegate
    {
        static void InvokeDelegate(MyPassingDelegate dele, string msg) => dele(msg);
        static void Main(string[] args)
        {
            string msg = "Passing Delegate As a Parameter";
            InvokeDelegate(MyClass.Print, msg);
            InvokeDelegate(MyClass.Show, msg);
            Console.ReadLine();
        }
    }
}
