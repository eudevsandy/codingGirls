// Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:
// um somente para números pares, e outro somente para números ímpares.
// Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.

int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"-- Separando os elementos de um vetor entre Par e Ímpar --");
    Console.WriteLine($"Informe o {i + 1}º número");
    numeros[i] = int.Parse(Console.ReadLine());
    Console.Clear();

    if (numeros[i] % 2 == 0)
    {
        pares[i] = numeros[i];
    }

    else impares[i] = numeros[i];

}

Console.Write("\nVetor com números pares: ");
foreach (int par in pares)
{
    if (par > 0)
    {
        Console.Write($"{par} ");
    }
}

Console.Write("\nVetor com números ímpares: ");
foreach (int impar in impares)
{
    if (impar > 0)
    {
        Console.Write($"{impar} ");
    }
}