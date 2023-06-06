using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b ,c;

            Console.WriteLine("Bem vindo ao Calc \n\n");
            Console.WriteLine("Calcule a area do triangulo \n\n");
            Console.WriteLine("Insira o valor da Base do Triangulo:"); 
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura do Triangulo:");
            b = double.Parse(Console.ReadLine());

        }
    }
}
