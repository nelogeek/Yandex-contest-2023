using System;
using System.Collections.Generic;

namespace Yandex_contest_3ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> experience = new Dictionary<string, int>();
            SortedSet<string> currentTeam = new SortedSet<string>();
            List<string> output = new List<string>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int time = int.Parse(input[1]);

                if (!experience.ContainsKey(name))
                    experience[name] = 0;

                while (currentTeam.Count > 0 && time > int.Parse(currentTeam.Min))
                {
                    string minName = currentTeam.Min;
                    currentTeam.Remove(minName);
                    experience[minName] += time - experience[minName];
                }

                currentTeam.Add(name);
                output.Add($"{currentTeam.Min} {experience[currentTeam.Min] - experience[name]}");

            }

            foreach (var line in output)
            {
                Console.WriteLine(line);
            }
        }
    }
}