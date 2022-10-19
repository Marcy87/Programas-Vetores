using System;

namespace ProgramVetores05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nome[i] = valores[0];
                idade[i] = int.Parse(valores[1]);
            }

            int maiorIdade = idade[0];
            int posicaoMaiorIdade = 0;

            for (int i = 0; i < N; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    posicaoMaiorIdade = i;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nome[posicaoMaiorIdade]);
        }
    }
}