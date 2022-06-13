//Aula 03 Ex. 04 Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
//Se a nota for menor que 6.0, deve exibir a nota F.
//Se a nota for de 6.0 até 7.0, deve exibir a nota D.
//Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
//Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
//Se a nota for entre 9.0 e 10.0, deve exibir um belo de um A.
//Não esqueça de adicionar uma mensagem após a nota,
//pode ser um simples parabéns para aprovação ou algo mais complexo.

Console.WriteLine("Insira sua primeira nota");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Insira sua segunda nota");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Insira sua terceira nota");
float nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

    if (media < 6.0)
    {
        Console.WriteLine("Nota F.Atenção aos estudos. Você consegue, acredite!");
    }

    else if (media > 6.0 && media < 7.0)
    {
        Console.WriteLine("Nota D. Continue estudando. Você pode melhorar!");
    }

    else if (media > 7.0 && media < 8.0)
    {
        Console.WriteLine("Nota C. Aprovado!");
    }

    else if (media > 8.0 && media < 9.0)
    {
        Console.WriteLine("Nota B. Parabéns!Bom desempenho!");
    }

    else Console.WriteLine("Nota A. Parabéns pelo ótimo trabalho!");