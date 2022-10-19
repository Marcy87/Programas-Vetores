using System;

namespace ProgramVetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(valores[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Console.Write(A[i] + " ");
                }
            }

            Console.WriteLine();

            int contPar = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    contPar++;
                }
            }

            Console.WriteLine(contPar);
        }
    }
}