using System;

namespace CalculadoraTaxaDeJuros
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest();
        }

        static void SimpleInterest(){
        
           Console.Clear();
           Console.WriteLine("Informe o valor dos juros da sua operação ao mês: ");
           float interest = (float.Parse(Console.ReadLine())) / 100;
           

           Console.WriteLine("Informe o valor do empréstimo da sua operação: ");
           float capital = float.Parse(Console.ReadLine());

           Console.WriteLine("Informe o período da sua operação (em meses): ");
           float time = float.Parse(Console.ReadLine());

           float result = capital * interest * time;
           float amount = capital + result;

           Console.WriteLine($"No final do período {time} mês, você pagará {result} de juros com um montante da dívida de {amount}");

        }
    }
}
