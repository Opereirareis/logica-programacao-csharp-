using System;

namespace Maratona
{
    class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("--- Exercício 3: Dados do Usuário ---");
            
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite sua cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, você tem {idade} anos e mora em {cidade}.");
            Console.WriteLine("-------------------------------------");
        }
    }
}
