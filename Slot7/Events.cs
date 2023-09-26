using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    public delegate void PrintDetails(string msg);
    class Program_Events
    {
        event PrintDetails Print;
        void Show(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            Program_Events p = new Program_Events();
            p.Print += new PrintDetails(p.Show);
            p.Print("Hello World!");
            Console.ReadLine();
        }
    }
}
