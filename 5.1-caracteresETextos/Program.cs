using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_caracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor =(Char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "Alura cursos online de tecnologia ";
            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            string saudacao = "Ola meu nome é ";
            string nome = "Vagner, ";
            string continuacao = "minha idade é ";
            int idade = 38;

            Console.WriteLine(saudacao + nome + continuacao + idade); 

            Console.ReadLine();


            
        }
    }
}
