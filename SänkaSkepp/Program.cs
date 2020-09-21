using System;

namespace SänkaSkepp
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize = 6;
            int ySize = 6;

            string[,] game = new string[xSize,ySize];
            Random random = new Random();

            int x = random.Next(0, 6);
            int y = random.Next(0, 6);

            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    game[i, j] = " ~ ";
                }
            }

            while (true)
            {
                for (int i = 0; i < xSize; i++)
                {
                    for (int j = 0; j < ySize; j++)
                    {
                        Console.Write($"{game[i, j]}");
                    }
                    Console.Write("\n");
                }

                Console.WriteLine("Ange ett x-värde och ett y-värde för att sänka skeppet (notera att första poition är 0,0).");
                Console.Write("X-värde: ");
                int xTry = int.Parse(Console.ReadLine());
                Console.Write("Y-värde: ");
                int yTry = int.Parse(Console.ReadLine());

                if (xTry==x && yTry==y)
                {
                    game[x, y] = " | ";
                    Console.WriteLine("Grattis! Du träffade skeppet!");
                    for (int i = 0; i < xSize; i++)
                    {
                        for (int j = 0; j < ySize; j++)
                        {
                            game[i, j] = " ~ ";
                        }
                    }
                    break;
                }
                else
                {
                    game[xTry, yTry] = " * ";
                    Console.WriteLine("Miss! Försök igen!");
                }
            }
            Console.ReadLine();
        }
    }
}
