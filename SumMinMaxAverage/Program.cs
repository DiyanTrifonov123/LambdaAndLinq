using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведи число {i+1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Сума = {nums.Sum()} \nНай-малко число = {nums.Min()} \nНай-голямо число = {nums.Max()} \nСредноаритметично = {nums.Average()}");
        }
    }
}
