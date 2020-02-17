using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 Condicionais2");

            int idadeJoao = 16;
            int quantidadeDePessoas = 3;
            bool acompanhado = quantidadeDePessoas >= 2;

            if (idadeJoao >= 18 || acompanhado == true)  // || ou, && e
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar, tem menos de 18 anos e não está acompanhado");
            }

            Console.WriteLine("Execução finalizada, aperte qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}