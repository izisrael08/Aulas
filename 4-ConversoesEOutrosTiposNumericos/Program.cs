using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");
            Console.WriteLine("----------------------------------------");

                double salario = 1200.50;
                int salarioEmInteriro = (int)salario;
                Console.WriteLine(salario);

                // long é uma variavel que suporta 64 bits
                long idade = 30000000;
                Console.WriteLine(idade);

                // o short é uma tipo de variavel que suporta 16 bits
                short quantidadeProdutos = 15000;
                Console.WriteLine(quantidadeProdutos);

                float altura = 1.80f;
                Console.WriteLine(altura);

            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }
    }
}
