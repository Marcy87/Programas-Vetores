using System;
using System.Globalization;

namespace ProgramVetores08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                altura[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(valores[1]);
            }


            //Menor altura
            double menorAltura = altura[0];
            for (int i = 1; i < N; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));


            //Maior altura
            double maiorAltura = altura[0];
            for (int i = 1; i < N; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));


            //Altura media das mulheres
            double soma = 0.0;
            int divisor = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma += altura[i];
                    divisor++;
                }
            }

            if (divisor == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher");
            } else
            {
                double media = soma / divisor;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            

            //Numero de homens
            int numHomens = 0;
            for (int i = 0; i <N; i++)
            {
                if (sexo[i] == 'M')
                {
                    numHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + numHomens);
        }
    }
}