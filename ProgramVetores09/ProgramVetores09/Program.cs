using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ProgramVetores09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nome[i] = valores[0];
                precoCompra[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }


            int lucroAbaixo10 = 0;
            int lucroEntre10E20 = 0;
            int lucroAcima20 = 0;
            for (int i = 0; i < N; i++)
            {
                double lucro = precoVenda[i] - precoCompra[i];

                double porcentagemLucro = lucro / precoCompra[i] * 100.0;

                if (porcentagemLucro < 10.0)
                {
                    lucroAbaixo10++;
                } else if (porcentagemLucro <= 20.0 )
                {
                    lucroEntre10E20++;
                } else
                {
                    lucroAcima20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + lucroAbaixo10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + lucroAcima20);


            double totalCompra = 0.0;
            double totalVenda = 0.0;
            for (int i = 0; i < N; i++)
            {
                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
            }
            double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}