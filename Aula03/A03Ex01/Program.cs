//Aula 03 Ex.01 Leia um valor de ponto flutuante com duas casas decimais.
//Este valor representa um valor monetário.
//A seguir, calcule o menor número de notas
//e moedas possíveis no qual o valor pode ser decomposto.
//As notas consideradas são de 100, 50, 20, 10, 5, 2.

Console.WriteLine("Indique a quantia desejada para saque");
float valor = float.Parse(Console.ReadLine());
float cem, cinquenta, vinte, dez, cinco, dois;

    cem = (int)valor / 100;
    valor %= 100;
    cinquenta = (int)valor / 50;
    valor %= 50;
    vinte = (int)valor / 20;
    valor %= 20;
    dez = (int)valor / 10;
    valor %= 10;
    cinco = (int)valor / 5;
    valor %= 5;
    dois = (int)valor / 1;

Console.WriteLine($"\nNotas de R$ 100,00 = {cem}");
Console.WriteLine($"Notas de R$ 50,00 = {cinquenta}");
Console.WriteLine($"Notas de R$ 20,00 = {vinte}");
Console.WriteLine($"Notas de R$ 10,00 = {dez}");
Console.WriteLine($"Notas de R$ 5,00 = {cinco}");
Console.WriteLine($"Notas de R$ 2,00 = {dois}");

