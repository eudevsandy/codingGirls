﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    //*A fim de representar empregados em uma empresa, 
    //crie uma classe chamada Empregado que inclui os seguintes atributos; nome, cargo e salário mensal.
    //Sua classe deve ter um construtor que inicializa os três atributos
    //e também fornecer métodos que executem as seguintes ações:
    //1. Se o salário mensal não for positivo, configure-o como 0.0.
    //2. Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: 
    //    Salário de 0 até 400.00 ganha 15% 
    //    Salário de 400.01 até 800.00 ganha 12% 
    //    Salário de 800.01 até 1200.00 ganha 10% 
    //    Salário de 1200.01 até 2000.00 ganha 7% 
    //    Acima de 2000.00 ganha 4%
    //3.Imprimir o salário de um funcionário.

    public class Empregado
    {
        public string Nome, Cargo;
        public double SalarioMensal, SalarioComReajuste;

        public Empregado(string nome, string cargo, double salarioMensal)
        {
            this.Nome = nome;
            this.Cargo = cargo;
            this.SalarioMensal = salarioMensal;
        }

        public void ConfigSalario()
        {
            double salarioM = this.SalarioMensal;
            double SalarioComReajuste;
            if (salarioM <= 0)
            {
                salarioM = 0.0;

            }
            else if (salarioM > 0 && salarioM < 400)
            {
                SalarioComReajuste = salarioM * 1.15;
                Console.WriteLine($"O novo salário é de {SalarioComReajuste}");
            }
            else if (salarioM > 400 && salarioM < 800)
            {
                SalarioComReajuste = salarioM * 1.12;
                Console.WriteLine($"O novo salário é de {SalarioComReajuste}");
            }
            else if (salarioM > 800 && salarioM < 1200)
            {
                SalarioComReajuste = salarioM * 1.10;
                Console.WriteLine($"O novo salário é de {SalarioComReajuste}");
            }
            else if (salarioM > 1200 && salarioM < 2000)
            {
                SalarioComReajuste = salarioM * 1.07;
                Console.WriteLine($"O novo salário é de {SalarioComReajuste}");
            }
            else
            {
                SalarioComReajuste = salarioM * 1.04;
                Console.WriteLine($"O novo salário é de {SalarioComReajuste}");
            }
        }

    }

}

