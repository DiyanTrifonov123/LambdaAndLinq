using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriteNaiGolemiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи числа на един ред разделени със Space: ");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine($"{string.Join(" ", nums.OrderByDescending(x => x).Take(3))}");
        }
    }
}
