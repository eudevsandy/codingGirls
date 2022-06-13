//Aula 02 Ex.03 Escreva um programa que leia o número de horas trabalhadas de um funcionário,
//o valor que recebe por hora e calcula o salário desse funcionário.
//A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Console.WriteLine("Insira a quantidade de horas trabalhadas:");
int horasTrab = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor que recebe por hora:");
int valorHora = int.Parse(Console.ReadLine());

int salario = horasTrab * valorHora;

Console.WriteLine($"Você trabalhou {horasTrab} horas e seu salário é R${salario:00.00}");