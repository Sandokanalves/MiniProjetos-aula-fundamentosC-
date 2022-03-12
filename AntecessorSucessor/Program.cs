using System;

namespace AntecessorSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 
            int sucessor;
            int antecessor;

            Console.WriteLine("Digite o Número para Saber seu Antecessor e seu Sucessor: ");
            num = int.Parse(Console.ReadLine());

          
                Console.WriteLine("Digite um número Válido");
                sucessor = num + 1;
                antecessor = num - 1;

                 Console.WriteLine("Antecessor de {0} é {1} e o Sucessor de {0} é {2}",num,antecessor,sucessor);
            }
            
        }
       
    }
