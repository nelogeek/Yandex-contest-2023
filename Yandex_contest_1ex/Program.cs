using System;
using System.Linq;

namespace Yandex_contest_1ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            if (N % 2 == 1)
            {
                Console.WriteLine("-1");
                return;
            }

            long left = 0;
            long right = N - 1;
            long sum = 0;

            while (left < right)
            {
                long pairSum = a[left] + a[right];
                if (pairSum != sum && sum != 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
                sum = pairSum;
                left++;
                right--;
            }

            Console.WriteLine(sum);
        }
    }
}