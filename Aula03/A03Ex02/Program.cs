//  Aula 03 Ex02. Faça um programa que leia três valores
//  e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”

Console.WriteLine("Insira um valor");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira um valor");
int valor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira um valor");
int valor3 = int.Parse(Console.ReadLine());

int maior = 0;

    if (valor1 > valor2 && valor1 > valor3)
    {
        maior = valor1;
    }

    else if (valor2 > valor1 && valor2 > valor3)
    {
        maior = valor2;
    }

    else
    {
        maior = valor3;

    }

Console.WriteLine($"{maior} é o maior");