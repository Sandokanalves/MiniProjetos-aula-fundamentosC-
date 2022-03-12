using System;

namespace CalcAreaCirculo
{
    class Program
    {
        class Constantes
        {
              public const double pi = 3.14;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Valor do Raio do Circulo");
            double raio = double.Parse(Console.ReadLine());
            double areaCirculo = Constantes.pi * Math.Pow(raio,2);


         Console.WriteLine("O calculo da Área do Circulo com um Raio de {0} é :", areaCirculo);
        }
    }
}
