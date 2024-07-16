using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - caracters e textos");
            Console.WriteLine("___________________________________________");

            // character Conversão chmada de Casting
            char primeiraLetra = (char)54;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia";
            Console.WriteLine(titulo);

            string cursosProgramacao = @" 
- .Net 
- Java 
- Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("___________________________________________ ");
            Console.ReadLine();
        }
    }
}
