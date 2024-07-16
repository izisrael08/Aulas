using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            Console.WriteLine("-----------------------------------------");

            int idade = 25;
            Console.WriteLine(idade);

            idade = 36;
            Console.WriteLine(idade);
            
            idade = 36 + 5;
            Console.WriteLine(idade);            
            
            idade = 36 + 5 * 10;
            Console.WriteLine(idade);

            idade = (36 + 5) * 10;
            Console.WriteLine(idade);



            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Executando Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
