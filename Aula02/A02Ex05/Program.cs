//Aula 02 Ex.05 Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
//Dolar, euro, libra esterlina, dólar canadense, peso argentino, peso chileno;
//Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real.
//Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Insira valor em real:");
float real = float.Parse(Console.ReadLine());

float dolar = real / 4.87f;
float euro = real / 5.21f;
float libra = real / 6.13f;
float dolarCanadense = real / 3.89f;
float pesoChileno = real / 0.040f;

Console.WriteLine($"O valor R${real} representa:" +
    $"\nDólar: US$ {dolar:00.00} " +
    $"\nEuro: € {euro:00.00}" +
    $"\nLibra: £ {libra:00.00}" +
    $"\nDólar Canadense: CAD {dolarCanadense:00.00} " +
    $"\nPeso Chileno: CLP {pesoChileno:00.00}");