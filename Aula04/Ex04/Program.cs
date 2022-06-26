// Ex 04: Jogo Jokempô

using System.Threading;

string[] lista = { "Pedra", "Papel", "Tesoura" };
int vitoriausuario = 0;
int vitoriapc = 0;
int empate = 0;
int opcao = 1;


while (opcao == 1)
{
    Console.WriteLine("Informe quantas partidas deseja jogar: ");
    int rodadas = int.Parse(Console.ReadLine());
    Console.Clear();

    for (int i = 0; i < rodadas; i++)
    {
        Console.WriteLine("Escolha:\n0-Pedra\n1-Papel\n2-Tesoura");
        int escolha = int.Parse(Console.ReadLine());

        Random r = new Random();
        int computer = r.Next(0, 2);

        if (escolha < 0 || escolha > 2)
        {
            Console.WriteLine("Jogada inválida!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else if (escolha == computer)
        {
            Console.WriteLine($"Empate!\nVocê escolheu {lista[escolha]} e o computador escolheu {lista[computer]}");
            empate++;
            Thread.Sleep(3000);
            Console.Clear();
        }
        else if (escolha == 0 && computer == 1 || escolha == 1 && computer == 2 || escolha == 2 && computer == 0)
        {
            Console.WriteLine($"FAIL!\nVocê escolheu {lista[escolha]} e o computador escolheu {lista[computer]}");
            vitoriapc++;
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Parabéns! Você ganhou!\nVocê escolheu {lista[escolha]} e o computador escolheu {lista[computer]}");
            vitoriausuario++;
            Thread.Sleep(3000);
            Console.Clear();

        }
    }
    Console.WriteLine("Deseja continuar jogando?\n1-Sim\n2-Não");
    opcao = int.Parse(Console.ReadLine());
}
  