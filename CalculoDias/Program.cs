using System;

namespace CalculoDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int numDias;

            Console.WriteLine("Informe sua Idade");

            idade = int.Parse(Console.ReadLine());

            numDias = idade*365;
            
            Console.WriteLine("Você viveu mais de {0}", numDias);


        }
    }
}
