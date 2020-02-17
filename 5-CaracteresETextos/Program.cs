using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 Caracteres e Textos");

            // character 16bits 
            char caractere = 'a';
            Console.WriteLine(caractere);

            char caractereNumerico = (char)65;
            Console.WriteLine(caractereNumerico);

            caractereNumerico = (char)(caractereNumerico + 1);
            Console.WriteLine("caractereNumerico + 1: " + caractereNumerico);

            string titulo = ("Isso é um texto " + 2020);
            Console.WriteLine(titulo);

            string vazia = "";
            Console.WriteLine(vazia);

            Console.WriteLine("Execução finalizada, aperte qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}
