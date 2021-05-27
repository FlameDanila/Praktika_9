using System;

namespace Praktika_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[8, 8];
            int A = 1, SS = -1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    SS *= A * -1; mass[i, j] = SS;

                    if (mass[i, j] < 0)
                    {
                        mass[i, j] = 0; 
                    }
                    Console.Write(mass[i, j] + " "); 
                } 
                Console.WriteLine(); SS *= A * -1;
            }

            Console.ReadLine();
            int[,] mass1 = new int[10, 10];
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass1[i, j] = rand.Next(0, 10);
                    sum += mass1[i, j];
                    Console.Write(mass1[i, j] + " ");
                }
                Console.WriteLine("Сумма строки = " + sum);
                sum = 0;
            }
            Console.ReadLine();
        }
    }
}
