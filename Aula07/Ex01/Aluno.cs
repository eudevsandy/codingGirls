using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Considere uma classe Aluno. Esta classe possui como atributos privados o nome,as notas e a frequência.
//Além do construtor, esta classe deve conter os métodos que cadastram os alunos,
//adiciona suas notas, consulta um aluno por código e consulta todos os alunos do cadastro.

namespace Ex01
{
    public class Aluno
    {
        private string nome { get; set; }
        private double nota1 { get; set; }
        private double nota2 { get; set; }

        private double frequencia;

        public Aluno(string nome, double nota1, double nota2, double frequencia)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.frequencia = frequencia;

        }

        public void CadastrarALunos(string nome)
        {
        }

        public BuscarPorId(int id)
        { 
        }

        public Listar()
        {
            return Aluno;
        }







    }
}
      
    