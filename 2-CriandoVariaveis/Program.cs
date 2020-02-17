using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            idade = 22;
            Console.WriteLine(idade);

            idade = idade + 8 * 2;
            Console.WriteLine("Sua idade agora é: " + idade);

            Console.ReadLine();
        }
    }
}
