using System;

namespace EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Verificador de Idade (Loop) ---");

            bool continuar = true;

            while (continuar)
            {
                Console.Write("Digite a sua idade: ");
                string entrada = Console.ReadLine();
                int idade;

                if (int.TryParse(entrada, out idade))
                {
                    if (idade >= 18)
                    {
                        Console.WriteLine("Você é maior de idade.");
                    }
                    else
                    {
                        Console.WriteLine("Você é menor de idade.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }

                Console.Write("Deseja verificar outra idade? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    continuar = false;
                    Console.WriteLine("Encerrando o programa...");
                }
                Console.WriteLine(); // Linha em branco para separar
            }
        }
    }
}
