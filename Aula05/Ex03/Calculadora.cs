using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Crie uma classe Calculadora, que possui como métodos
//  a multiplicação, divisão, subtração
//  e soma de dois valores e exibe para o usuário.

namespace Ex03
{
   public class Calculadora
    {
        public double n1;

        public double n2;
        public double Multiplicar()
        {
            return n1 * n2;
        };

        public double Dividir()
        {
            return n1 / n1;
        }
        public double Subtrair()
        {
            return n1 - n2;
        }

        public double Somar()
        {
            return n1 + n2;
        }

    }
}
