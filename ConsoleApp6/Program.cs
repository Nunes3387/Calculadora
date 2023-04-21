using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            double n1, n2;

            Console.WriteLine("Digite o primeiro valor:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            n2 = double.Parse(Console.ReadLine());

            double resultado = calculadora.Adicao(n1, n2);
            Console.WriteLine(+n1+ "+"+ n1 + "="+ resultado);

            resultado = calculadora.Subtracao(n1, n2);
            Console.WriteLine(+n1 + "-" + n1 + "=" + resultado);

            resultado = calculadora.Multiplicacao(n1, n2);
            Console.WriteLine(+n1 + "*" + n1 + "=" + resultado);

            resultado = calculadora.Divisao(n1, n2);
            Console.WriteLine(+n1 + "/" + n1 + "=" + resultado);

            Console.ReadKey();

        }
    }
}
