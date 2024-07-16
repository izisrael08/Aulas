using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7  - Condicionais");
            Console.WriteLine("_____________________________________");

            int idadeJoao = 15;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18, pode entar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João nao possui 18, mas esta acompanhado, pode entrar!");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }

            Console.WriteLine("_____________________________________");
            Console.ReadLine();
        }
    }
}
