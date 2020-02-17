using System;

namespace _2._Draw_the_Halloween_Pumpkin
{
    class Program
    {
        static void DrawHat(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("_/_");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        static void DrawTopPart(int n)
        {
            Console.Write("/");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(".");
            }
            Console.Write("^,^");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(".");
            }
            int a = 92;
            Console.Write((char)a);
            Console.WriteLine();
        }

        static void DrawMiddPart(int n)
        {
            int middLines = n - 3;
            int points = 2 * n + 1;
            for (int i = 0; i < middLines; i++)
            {                
                for (int j = 0; j < points; j++)
                {
                    if (j == 0 || j == points - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawBottPart(int n)
        {
            Console.Write((char)92);
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(".");
            }
            Console.Write((char)92 + "_/");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(".");
            }
            Console.Write("/");
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            DrawHat(N);
            DrawTopPart(N);
            DrawMiddPart(N);
            DrawBottPart(N);

        }
    }
}
