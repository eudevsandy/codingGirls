//Aula 03 Ex.05 A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
//Salário de 0 até 400.00 ganha 15 %
//Salário de 400.01 até 800.00 ganha 12 %
//Salário de 800.01 até 1200.00 ganha 10%
//Salário de 1200.01 até 2000.00 ganha 7%
//Acima de 2000.00 ganha 4%
//Leia o salário do funcionário, calcule e mostre o novo salário, 
//bem como o valor de reajuste ganho e o índice reajustado, em percentual.
//Exemplo de Entrada 400.00
//Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %

Console.WriteLine("Informe salário atual ");
float salario = float.Parse(Console.ReadLine());
float percentual, aumento, novo_salario;

    if (salario <= 400.00)
    {
        percentual = 0.15f;
    }
    else if (salario <= 800.0)
    {
        percentual = 0.12f;
    }
    else if (salario <= 1200.0)
    {
        percentual = 0.10f;
    }
    else if (salario <= 2000.0)
    {
        percentual = 0.07f;
    }
    else
    {
        percentual = 0.04f;
    }

    aumento = percentual * salario;
    novo_salario = salario + aumento;


Console.WriteLine($"Sálario atual: R$ {salario:00.00}");
Console.WriteLine($"Percentual de aumento: {String.Format("{0:0.00}", percentual)}%");
Console.WriteLine($"Aumento Real: R$ {aumento:00.00}");
Console.WriteLine($"Novo Sálario: R$ {novo_salario:00.00}");