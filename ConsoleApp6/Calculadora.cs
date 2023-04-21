using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Calculadora : ICalculadora
    {
        public double Adicao(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divisao(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            return num1 / num2;
        }
    }
}
