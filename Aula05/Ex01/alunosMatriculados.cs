using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class alunosMatriculados
    {
        public int matricula;
        public string nome;
        public double prova1;
        public double prova2;
        public double trabalho;

        public double calcularMedia(double prova1, double prova2, double trabalho)
        {
            return (prova1 + prova2 + trabalho) / 3;
        }
    }
}