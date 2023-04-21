using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface ICalculadora
    {
        double Adicao(double num1, double num2);
        double Subtracao(double num1, double num2);
        double Multiplicacao(double num1, double num2);
        double Divisao(double num1, double num2);
    }

}
