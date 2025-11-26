using System;

namespace Maratona
{
    class Exercicio4
    {
        public static void Executar()
        {
            Console.WriteLine("--- Exercício 4: Empréstimo Bancário ---");

            Console.Write("Digite o valor do empréstimo: ");
            double valorEmprestimo = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa de juros mensal (em %): ");
            double taxaJuros = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Digite o número de meses: ");
            int meses = int.Parse(Console.ReadLine());

            // Fórmula de Juros Compostos: M = P * (1 + i)^n
            double montante = valorEmprestimo * Math.Pow((1 + taxaJuros), meses);

            Console.WriteLine($"O valor final a pagar após {meses} meses será: {montante:C2}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
