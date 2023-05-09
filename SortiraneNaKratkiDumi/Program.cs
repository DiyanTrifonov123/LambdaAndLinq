using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortiraneNaKratkiDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи изречение: ");
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words.Where(w => w.Length < 5).OrderBy(w => w).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
