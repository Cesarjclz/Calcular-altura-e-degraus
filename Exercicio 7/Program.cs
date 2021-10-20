using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int degrau = 17;
            int altura;
            
            Console.WriteLine("Sabendo que cada degrau tem " + degrau + "cm! Em centimetros digite o valor da escada: ");


            altura = int.Parse(Console.ReadLine());
            altura = altura / degrau;
            Console.WriteLine("A quantida de degraus que voce precisa é "+altura);

        }
    }
}
