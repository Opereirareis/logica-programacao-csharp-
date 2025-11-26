using System;

namespace OperadoresLogicos
{
    class DesafioLogica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Desafio Lógica: Tabela Verdade ---");

            // Declaração das variáveis booleanas (Proposições)
            bool brasilNaEuropa = false;
            bool cincoMaisCincoDez = (5 + 5 == 10); // True
            bool solEhFrio = false;
            bool terraEhRedonda = true;

            Console.WriteLine($"A: O Brasil fica na Europa? {brasilNaEuropa}");
            Console.WriteLine($"B: 5 + 5 = 10? {cincoMaisCincoDez}");
            Console.WriteLine($"C: O Sol é frio? {solEhFrio}");
            Console.WriteLine($"D: A Terra é redonda? {terraEhRedonda}");
            Console.WriteLine("--------------------------------------");

            // Testando combinações lógicas
            Console.WriteLine("--- Resultados Lógicos ---");

            // AND (&&) - Verdadeiro apenas se AMBOS forem verdadeiros
            Console.WriteLine($"A AND B (F && V): {brasilNaEuropa && cincoMaisCincoDez}"); // False
            Console.WriteLine($"B AND D (V && V): {cincoMaisCincoDez && terraEhRedonda}"); // True

            // OR (||) - Verdadeiro se PELO MENOS UM for verdadeiro
            Console.WriteLine($"A OR C (F || F): {brasilNaEuropa || solEhFrio}"); // False
            Console.WriteLine($"A OR B (F || V): {brasilNaEuropa || cincoMaisCincoDez}"); // True

            // NOT (!) - Inverte o valor
            Console.WriteLine($"NOT A (!F): {!brasilNaEuropa}"); // True
            Console.WriteLine($"NOT B (!V): {!cincoMaisCincoDez}"); // False

            // Combinações mais complexas
            Console.WriteLine($"(A OR B) AND D: {(brasilNaEuropa || cincoMaisCincoDez) && terraEhRedonda}"); // True
            
            Console.WriteLine("--------------------------------------");
        }
    }
}
