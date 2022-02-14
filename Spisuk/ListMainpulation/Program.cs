using System;
using System.Collections.Generic;
using System.Linq;

namespace ListMainpulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                var command = input[0];
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                if (command == "add")
                {
                    int index = int.Parse(input[1]);
                    int element = int.Parse(input[2]);
                    nums.Insert(index, element);
                }
                else if (command == "contains")
                {
                    int element = int.Parse(input[1]);
                    Console.WriteLine(nums.IndexOf(element));
                }
                else if (command == "remove")
                {
                    int index = int.Parse(input[1]);
                    nums.RemoveAt(index);
                }
            }
        }
    }
}
