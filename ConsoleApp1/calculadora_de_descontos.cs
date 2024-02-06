using System;
using Microsoft.VisualBasic;

namespace test;
class Program

{
    static void Main(string[] args)
    {
        
        Console.WriteLine("______________________________________________________________________________________________");     
        Console.WriteLine("SEJA BEM-VINDO(A) A CALCULADORA DE DESCONTOS");  
        Console.WriteLine("(Utilize vírgula em caso de números decimais)\n" );    
        Console.Write("Informe o valor que receberá o desconto: ");     
        decimal valor = Convert.ToDecimal(Console.ReadLine().Replace('.', ','));
        Console.Write("Digite o número correspondente ao desconto(Somente números, não precisa do sinal de porcentagem): ");
        decimal desconto = Convert.ToDecimal(Console.ReadLine().Replace('.', ','));
        decimal valdesconto = (valor*desconto)/100;
        decimal valfinal = valor-valdesconto;
        Console.WriteLine("\nO resultado é " + Math.Round(valfinal, 2)+".");
        Console.WriteLine("______________________________________________________________________________________________"); 
        Console.ReadLine();
    }
}
