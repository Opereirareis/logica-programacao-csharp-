using System;

namespace Maratona
{
    class Exercicio5e6
    {
        public static void Executar()
        {
            Console.WriteLine("--- Exercício 5: Conversor de Moeda ---");
            Console.Write("Digite o valor em Reais (BRL): ");
            double reais = double.Parse(Console.ReadLine());
            
            // Taxa fictícia
            double taxaDolar = 5.50;
            double dolares = reais / taxaDolar;

            Console.WriteLine($"Valor em Dólares (USD): ${Math.Round(dolares, 2)}");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("--- Exercício 6: Cálculo de Desconto ---");
            Console.Write("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de desconto: ");
            double descontoPorcentagem = double.Parse(Console.ReadLine());

            double valorDesconto = valorProduto * (descontoPorcentagem / 100);
            double valorFinal = valorProduto - valorDesconto;

            Console.WriteLine($"Valor do Desconto: {valorDesconto:C2}");
            Console.WriteLine($"Valor Final do Produto: {valorFinal:C2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
