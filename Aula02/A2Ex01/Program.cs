//Aula 02 Ex.01 Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

Console.WriteLine("Qual sua data de nascimento?");
int anoNascimento = int.Parse(Console.ReadLine());

int anoAtual = 2022;
int idade = anoAtual - anoNascimento;

Console.WriteLine($"Sua idade é {idade} anos");