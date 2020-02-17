using System;
using System.Linq;

namespace _1._Sum_to_13
{
    class Program
    {
        static void Main()
        {

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool IsSummedTo13 = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        int sum = arr.Sum();
                        if (sum == 13)
                        {
                            IsSummedTo13 = true;
                        }

                        if (j == 0)
                        {
                            arr[0] *= -1;
                        }

                        if (k == 0)
                        {
                            arr[1] *= -1;
                        }

                        if (i == 0)
                        {
                            arr[2] *= -1;
                        }
                    }
                }
            }
            if (IsSummedTo13)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
