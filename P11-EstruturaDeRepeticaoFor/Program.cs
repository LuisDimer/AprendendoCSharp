using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_EstruturaDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;

            for (int valorMes = 1; valorMes <= 12; valorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("No mês " + valorMes + " você terá acumulado R$" + Math.Round(valorInvestido) + " reais investindo na poupança");
            }
            Console.ReadLine();
        }
    }
}
