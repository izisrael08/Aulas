using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");
            Console.WriteLine("------------------------------------------------------");

            double salario = 1200.75;
            Console.WriteLine("Esse é o meu salário " + salario);

            double idade = 15.0 / 2;
            Console.WriteLine("Operação com Double com um numero flutuante e um numero inteiro " + idade);

            idade = 5 / 2;
            Console.WriteLine("5 / 2 = " + idade);

            idade = 5 / 2.0;
            Console.WriteLine("5 / 2.0 = " + idade);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("A execução acabou. Tecle enter para sair....");
            Console.ReadLine();

        }
    }
}
