﻿using System;
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

            Console.WriteLine("Oi Vagner, estamos ");
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);   

            idade = (10 + 5) * 2 + 8;
            Console.WriteLine("Sua idade é  " + idade + "!");

            Console.WriteLine("Execução finalizada. Pressione o enter para Sair ...");
            Console.ReadLine();
        }
    }
}
