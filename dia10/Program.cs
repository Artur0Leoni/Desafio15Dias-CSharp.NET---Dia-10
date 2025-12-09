using System;

class Program
{
    static void Main(string[] args)
    {
        bool jogarNovamente = true;

        while (jogarNovamente)
        {
            Console.Clear();
            Console.WriteLine("JOGO: ADIVINHE O NÚMERO");

            Random rand = new Random();
            int numeroSecreto = rand.Next(1, 101);
            int tentativas = 0;
            int palpite = 0;

            while (palpite != numeroSecreto)
            {
                Console.Write("\nDigite um número entre 1 e 100: ");

                if (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("Valor inválido! Digite somente números entre 1 e 100.");
                    continue;
                }

                tentativas++;

                if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor!");
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior!");
                }
            }

            Console.WriteLine($"\nParabéns! Você acertou o número {numeroSecreto}!");
            Console.WriteLine($"Tentativas: {tentativas}");

            Console.Write("\nDeseja jogar novamente? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            jogarNovamente = resposta == "s" || resposta == "sim";
        }

        Console.WriteLine("\nObrigado por jogar! Até a próxima!");
    }
}