using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_LacosForEncadeados
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            double valorJuros = 1.0036;

            for (int valorAno = 1; valorAno < 10; valorAno++)
            {
                for (int valorMes = 1; valorMes <= 12; valorMes++)
                {
                    valorInvestido *= valorJuros;
                }
                Console.WriteLine(Math.Round(valorInvestido));
                valorJuros += 0.0010;
            }
            Console.ReadLine();
        }
    }
}
