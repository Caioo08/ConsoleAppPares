using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 2;
            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += 2;
            }
            Console.ReadKey();
        }
    }
}
