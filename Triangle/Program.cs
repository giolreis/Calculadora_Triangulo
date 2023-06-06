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
            double a, b, c;

            Console.WriteLine("Bem vindo ao Calc \n\n");
            Console.WriteLine("Calcule a area do triangulo \n\n");
            Console.WriteLine("Calculando área do triângulo"); //V3.2
            a = double.Parse(Console.ReadLine()); //V3.1 
            int valorB;
            int valorC; //V2.2
            double a, b c;

            Console.WriteLine("Bem vindo ao Calc \n\n");
            Console.WriteLine("Calcule a area do triangulo \n\n");
            Console.WriteLine("Área do triâgulo calculada:"); //V2.2
            Console.WriteLine("Insira o valor de a:") //V2.1
            Console.ReadLine(valorB) //V2.1
            Console.ReadLine(valorC) //V2.2
            double a, b ,c;

            Console.WriteLine("Bem vindo ao Calc \n\n");
            Console.WriteLine("Calcule a area do triangulo \n\n");
            Console.WriteLine("Insira o valor da Base do Triangulo:"); 
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura do Triangulo:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            c = ((a * b)/2);
            Console.WriteLine("O Valor da area do triângulo é {0}",c);

        }
    }
}
