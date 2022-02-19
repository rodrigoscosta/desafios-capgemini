using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            //Console.WriteLine("Digite o número de casos: ");
            int numeroDeCasos = Convert.ToInt32(Console.ReadLine());

            //Percorre da primeira até a última linha definida pelo usuário
            for (i = 1; i <= numeroDeCasos; i++)
            {
                //Define os espaços a esquerda em cada linha para formar a escada
                for (j = numeroDeCasos - i; j >= 1; j--)
                    Console.Write(" ");

                    //Define os asteriscos que deve conter em cada linha
                    for (j = 1; j <= i; j++)
                        Console.Write("*");

                Console.WriteLine("\n");
            }
        }
    }
}