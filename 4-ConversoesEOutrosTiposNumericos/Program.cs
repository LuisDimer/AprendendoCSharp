using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            int salarioInteriro;

            salario = 1200.0;
            salarioInteriro = (int)salario; // salarioInteriro = salario; Não é aceito atribuir um valor de uma variavel double em um inteiro, portanto foi convertido para (int)

            Console.WriteLine("Execução do programa finalizada, aperte qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
