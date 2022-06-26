class Program
{
    public static void Main(string[] args)
    {
        //  DECLARACAO DE VARIAVEIS
        int qtdProduto = 0, qtdTotal = 0;
        double vlrProduto = 0, vlrTotal = 0;

        // ENTRADA DE DADOS
        for (int i = 0; i < 3; i++)
        {

            Console.Write($"Digite a quantidade do produto {(i + 1)}: ");
            qtdProduto = int.Parse(Console.ReadLine());

            Console.Write($"Digite o valor do produto {(i + 1)}: ");
            vlrProduto = double.Parse(Console.ReadLine());

            qtdTotal = qtdProduto;
            vlrTotal += vlrProduto;
        }

        // IMPRIMINDO O RESULTADO
        Console.WriteLine($"Quantidade total = {qtdTotal}");
        Console.WriteLine("Valor total = R{0:C}", vlrTotal);
    }
}