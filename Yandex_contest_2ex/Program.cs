using System;
using System.Linq;
using System.Net.Http.Headers;

namespace Yandex_contest_2ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 24 часа           12 часов
            // 60 минут          1234 минуты

            //  1 00:00          1 0000:0000
            //  2 01:10          2 0001:1000
            //  3 02:20          3 0010:0100
            //  4 03:30          4 0011:1100
            //  5 04:40          
            //  6 05:50          

            //  7 10:01          
            //  8 11:11          
            //  9 12:21          
            // 10 13:31          
            // 11 14:41          
            // 12 15:51          

            // 13 20:02          
            // 14 21:12          
            // 15 22:22          
            // 16 23:32          

            // наблюдение: начинать можно с меньшего числа...

            int count = 0;

            string[] input = Console.ReadLine().Split(' ');
            long h = long.Parse(input[0]);
            long m = long.Parse(input[1]);

            int maxLen = Math.Max(input[0].Length, input[1].Length);

            if (h <= m)
            {
                for (long hour = 0; hour < h; hour++)
                {
                    string tempH = hour.ToString().PadLeft(maxLen, '0');
                    string tempM = new string(tempH.Reverse().ToArray());
                    if(hour < h && long.Parse(tempM) < m)
                    {
                        count++;
                        //Console.WriteLine($"{tempH}:{tempM}");
                    }
                }
            }
            else
            {
                for(int min = 0; min < m; min++)
                {
                    string tempM = min.ToString().PadLeft(maxLen, '0');
                    string tempH = new string(tempM.Reverse().ToArray());
                    if(min < m &&  long.Parse(tempM) > m)
                    {
                        count++;
                        //Console.WriteLine($"{tempH}:{tempM}");
                    }
                }
            }

            Console.WriteLine(count);


        }
    }
}