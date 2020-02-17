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

            // double é uma variavel do tipo flutuante
            double salario = 1200.0;
            Console.WriteLine("Double " + salario);

            // float é uma variavel do tipo flutuante mas de menor precisão pois não guarda muitos digitos depois da virgula
            float altura = 1.61f;
            Console.WriteLine("float " + altura);

            //O short é uma varável do tipo inteiro de 16 bits
            short idade = 30;
            Console.WriteLine("short " + idade);

            // int é uma variavel do tipo inteiro, suporta até 32 bits
            int salarioInteriro = (int)salario; // salarioInteriro = salario; Não é aceito atribuir um valor de uma variavel double em um inteiro, portanto foi convertido para (int)
            Console.WriteLine("int " + salarioInteriro);

            // long é uma variavel do tipo inteiro mas suporta até 64 bits
            long idadeDoUniverso = 13700000000;
            Console.WriteLine("long " + idadeDoUniverso);
             
            Console.WriteLine("Execução do programa finalizada, aperte qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
