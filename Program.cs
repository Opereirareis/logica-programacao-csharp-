//Condicional IF
using System.Runtime.ConstrainedExecution;
using System.Security.Authentication;

string nome = "Ana";

if (nome == "Ana")
{
    Console.WriteLine("Olá, Ana!");
}

string texto = "";

if (string.IsNullOrEmpty(texto))
{
    Console.WriteLine("A string está vazia.");
}


//Condicional IF/ELSE
if idade = 16;

if (idade >= 18) //se

{
    Console.WriteLine("Você é maior de idade.");
}

else // se não 

{
     Console.WriteLine("Você é menor de idade.");
}
int numero = 7;

if (numero % 2 == 0)

{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O numer é impar.");
}

//Condicional usando else if

double nota = 6.5;
if (nota >= 9.0)
{
    Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");

}
else if (nota >= 7.0)
{
    Console.WriteLine("Você está aprovado.");
}

else if (nota >= 5.0)
{
    Console.WriteLine("Você está em recumperação.");
}

else if (nota >= 3.0)
{
    Console.WriteLine("Você está com risco de reprovação.");
}

else
{
    Console.WriteLin("Você foi reprovado.");
}


//Condicional switch
double pontuacao = 8.5;

// Arredondando a nota para o inteiro mais proximo - Floor arredonda para baixo - Round() para cima se for 8.6

int faixaNota = (int)Math.Floor(pontuacao);

switch (faixaNota)
{
    case 10:
        Console.WriteLine("Você obteve uma excelente nota! Aprovado com destinção.");
        break;
    case 9:
    case 8:
        Console.WriteLine("Você está aprovado.");
        break;
    case 7:
    case 6:
        Console.WriteLine("Você está em recumperação.");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("Você está com risco de reprovação.");
        break;
    default:
        Console.WriteLine("Você foi reprovado.");
        break ;


}