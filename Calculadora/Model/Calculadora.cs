
namespace Model
{
    public class Calculadora
    {
    public int soma {get; set;}
     public int subtrair {get; set;}
      public int multiplicar {get; set;}
       public int divisao {get; set;}


       public void Soma (int soma)
       {
           for(int i = 0; i<=10; i++){
               this.soma = soma + i;
               Console.WriteLine($"Soma é:{soma} + {i} = {this.soma}");
           }
            
       }

          public void Subtrair(int subtrair)
       {
           for(int i = 0; i<=10; i++){
               this.subtrair = subtrair - i;
               Console.WriteLine($"Subtração é: {subtrair} - {i} = {this.subtrair}");
           }
            
       }

          public void Multiplicar(int multiplicar)
       {
           for(int i = 0; i<=10; i++){
               this.multiplicar = multiplicar * i;
               Console.WriteLine($"Multiplicação é: {multiplicar} x {i} = {this.multiplicar}");
           }
            
       }

            public void Divisão(int divisao)
       {        int resto;
           for(int i = 1; i<=10; i++){
               this.divisao = divisao/ i;
               resto = divisao % i;
               Console.WriteLine($"Divisão entre: {divisao} / {i} = {this.divisao} e seu Resto é {resto}");
           }
            
       }
        
    }
}