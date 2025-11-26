using System;

namespace LogisticaCaminhao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulação de Portaria de Logística
            Console.WriteLine("--- Sistema de Controle de Entrada ---");
            Console.WriteLine("O caminhoneiro chegou à portaria.");

            // Pergunta ao atendente (Entrada de Dados)
            Console.Write("O motorista possui autorização? (Digite S para Sim, N para Não): ");
            string resposta = Console.ReadLine().ToUpper(); // .ToUpper() garante que 's' vire 'S'

            // Processamento (Lógica Condicional)
            if (resposta == "S")
            {
                // Caminho Feliz (Fluxo Positivo)
                Console.WriteLine("1. Entrada registrada no sistema.");
                Console.WriteLine("2. Autorização validada.");
                Console.WriteLine("-> Por favor, dirija-se à doca de descarregamento.");
            }
            else
            {
                // Caminho de Exceção (Fluxo Negativo)
                Console.WriteLine("ALERT: Autorização não encontrada!");
                Console.WriteLine("-> Informe ao motorista que é necessário solicitar autorização.");
                Console.WriteLine("-> Aguardando instruções do supervisor...");
            }

            Console.WriteLine("--------------------------------------");
        }
    }
}
