using System;
using System.Globalization;

namespace ProgramVetores04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double media = 0;

            for (int i = 0; i < N; i++)
            {
                media += vet[i] / N;
            }
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}