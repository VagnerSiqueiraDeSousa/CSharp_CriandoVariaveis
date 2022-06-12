using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutroTipoNumerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi Vagner, estamos Executando o projeto 4");
            
            double salario = 1200.50;

            //int e um tipo de variavel que suporta  valores ate 32 bits
            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //long é um tipo de variavel que suporta ate 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            //short  é um tipo de variavel que suporta ate 16 bits
            short quantidadeProduto = 15000;
            Console.WriteLine(quantidadeProduto);

            float altura = 1.80f;
            Console.WriteLine(altura);
            


            Console.WriteLine("Pressione entre para sair ...");
            Console.ReadLine();
        }
    }
}
