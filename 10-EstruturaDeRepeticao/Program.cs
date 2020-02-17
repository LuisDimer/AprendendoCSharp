using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            int valorMes = 1;

            while (valorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("No mês " + valorMes + " você terá acumulado R$" + valorInvestido + " reais investindo na poupança");
                valorMes++;
            }
            Console.ReadLine();
        }
    }
}
