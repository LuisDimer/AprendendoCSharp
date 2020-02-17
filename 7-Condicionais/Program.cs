using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 Condicionais");

            int idadeJoao = 16;
            int quantidadeDePessoas = 3;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                if(quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João pode entrar, tem " + idadeJoao + " anos mas está acompanhado por " + (quantidadeDePessoas - 1) + " pessoas.");
                }
                else
                {
                    Console.WriteLine("João não pode entrar, tem menos de 18 anos e não está acompanhado");
                }
            }

            Console.WriteLine("Execução finalizada, aperte qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
