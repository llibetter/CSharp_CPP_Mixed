using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CPP_Mixed
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeCon invokeCon = new InvokeCon();
            int a = 80;
            int b = 2;
            Console.WriteLine($"{a}+{b}={invokeCon.AddCli(a, b)}");
            Console.WriteLine($"{a}-{b}={invokeCon.SubtractCli(a, b)}");
            Console.WriteLine($"{a}*{b}={invokeCon.MultiplicationCli(a, b)}");
            Console.WriteLine($"{a}/{b}={invokeCon.DividedCli(a, b)}");
            Console.WriteLine($"40/0={invokeCon.DividedCli(40, 0)}");

            Console.ReadLine();
        }
    }
}
