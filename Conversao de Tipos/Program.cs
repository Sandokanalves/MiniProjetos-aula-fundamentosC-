// See https://aka.ms/new-console-template for more information
int inteiro = 100;
float real = 25.0f;

// real = inteiro; 
// inteiro = (int) real;
//inteiro = int.Parse(real.ToString());
inteiro = Convert.ToInt32(real);

Console.WriteLine(inteiro);

