//Aula 03 Ex. 03.Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
//Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
//Imprima se o aluno foi aprovado ou reprovado considerando a média 7.

Console.WriteLine("Informe a nota de sua A1");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a nota de sua A2");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a nota de sua A3");
float nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

    if (media >= 7)
    {
        Console.WriteLine("Parabéns! Aprovado!");
    }
    else Console.WriteLine("Reprovado");

