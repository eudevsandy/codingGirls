// Exercício 01. Crie um programa que solicite a entrada de 10 números pelo usuário,
// armazenando-os em um vetor,
// e então monte outro vetor com os valores do primeiro multiplicados por 5. 
//Exiba os valores dos dois vetores na tela, um em cada linha.

int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"-- Multiplindo por 5 os elementos de um vetor --");
    Console.Write($"Informe o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    Console.Clear();
}

Console.Write("Vetor inicial:\n");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{numeros[i]} ");
}

Console.WriteLine("\n");

Console.Write("Vetor com elementos multiplicados por 5: \n");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{numeros[i] * 5} ");
}
