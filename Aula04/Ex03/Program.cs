// Ex. 03 Crie um programa que lê 5 palavras e as ordena em um vetor de strings 
// pelo seu tamanho.
// Se o tamanho das strings for igual,
// deve-se manter a ordem inserida pelo usuário.

string[] palavras = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"--Ordenação da palavras por tamanho--");
    Console.WriteLine($"Digite a {i + 1}ª palavra: ");
    palavras[i] = Console.ReadLine();
    Console.Clear();
}

// Método próprio do C# que classifica elementos em ordem crescente (orderby)

IEnumerable<string> ordemCrescente = from palavra in palavras 
                                     orderby palavra.Length 
                                     select palavra;

Console.WriteLine("Ordem crescente das palavras inseridas: ");
foreach (string c in ordemCrescente)
{
    Console.Write($"{c} ");
}