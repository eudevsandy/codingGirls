using System;

/* Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.

Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome,
2 notas de prova e 1 nota de trabalho. 

Escreva os seguintes métodos para esta classe:
Calcular média: calcula e exibe a média final do aluno com base em suas notas;
Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.
  */

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)


        {
            alunosMatriculados aluno1 = new Alunos();
            aluno1.matricula = "2911";
            aluno1.nome = "Jéssica";
            aluno1.prova1 = 10.0;
            aluno1.prova2 = 9.0;
            aluno1.trabalho = 10.0;
            aluno1.calcularMedia(aluno1.prova1, aluno1.prova2, aluno1.trabalho);
            //   aluno1.calcularMedia()=(10.0,9.0,10.0);

            Console.WriteLine($"Olá {aluno1.nome}. Seguem notas lançadas até o momento:\nMatrícula: {aluno1.matricula} \nA1: {aluno1.prova1} \nA2: {aluno1.prova2}\nTrabalho: {aluno1.trabalho}\nMédia: {aluno1.calcularMedia}");
        }

    }
}