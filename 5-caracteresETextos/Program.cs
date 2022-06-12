using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_caracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi Vagner, vamos executar o projeto 5 ");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia";
            string cursos = @"- .Net
- java
- javaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursos);


            Console.WriteLine("Finalize o programa pressionando o entre para Sair . . .");
            Console.ReadLine();
        }
    }
}
