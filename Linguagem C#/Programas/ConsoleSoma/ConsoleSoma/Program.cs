using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSoma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o primeiro Numero:");

            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo Numero:");

            int valor2 = Convert.ToInt32(Console.ReadLine());

            int valor3 = valor1 + valor2;

            Console.WriteLine("A soma dos dois valores é:" + valor3);
            
            Console.ReadKey();


        }
    }
}
