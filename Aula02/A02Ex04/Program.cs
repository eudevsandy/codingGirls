//Aula 02 Ex. 04 Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
//Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
//Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
//Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Console.WriteLine("Informe sua idade");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
int dias = idade * 365;

Console.WriteLine($"Você tem {idade} anos de idade, o que corresponde a {meses} meses ou {dias} dias.");
