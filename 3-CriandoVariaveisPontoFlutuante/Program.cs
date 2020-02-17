using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando Variáveis de Ponto Flutuante");

            double salario;
            salario = 15.7;
            Console.WriteLine(salario);

            double idade;

            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2; //15 / 2 mesmo idade sendo um double é necessário colocar 15.0 para que ele faça o calculo de double / por Int senão ele faz entre dois numeros inteiros e nesse caso  perde o decimal
            Console.WriteLine(idade);

            Console.WriteLine("A execução acabou. Aperte qualquer tecla em seguida Enter para finalizar a aplicação...");
            Console.ReadLine();
        }
    }
}
