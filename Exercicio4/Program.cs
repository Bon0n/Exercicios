using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fib(int n) => n < 2 ? n : calculoFib(n);

            int calculoFib(int n)
            {
                n = fib(n - 1) + fib(n - 2);
                return n;
            }

            int i = 0;
            int f = 0;
            do
            {
                f = fib(i);
                i++;
            } while (i < 13);
            Console.WriteLine(f);
            
            
        }
    }
}
