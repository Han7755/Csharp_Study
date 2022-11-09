using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ws = new int[n];
            string w = Console.ReadLine();
            int left = 0, right = 0, c = 0, sum = 0;
            int[] weight = { 100, 50, 20, 10, 5, 2, 1 };
            ws = Array.ConvertAll<string, int>(w.Split(' '), int.Parse);
            left = ws[0];
            right = ws[1];

            for (int i = 2; i < n; i++)
            {
                if (left == right)
                    left += ws[i];
                else if (left < right)
                    left += ws[i];
                else
                    right += ws[i];
            }

            c = left - right;

            if (c < 0)
                c = -c;

            for (int i = 0; i < 7; i++)
            {
                sum += c / weight[i];
                c %= weight[i];
            }

            Console.WriteLine(sum);
        }
    }
}
