using System;
using System.Globalization;

namespace ProgramVetores05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            int soma = 0;
            int divisor = 0;

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    soma += vet[i];
                    divisor++;

                }
            }

            if (divisor == 0)
            {
                Console.WriteLine("Nao havis nenhum número par");
            } else
            {
                double media = (double)soma / divisor;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}