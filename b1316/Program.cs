/* 백준 1316번 문제
그룹 단어란 단어에 존재하는 모든 문자에 대해서, 각 문자가 연속해서 나타나는 경우만을 말한다. 예를 들면, ccazzzzbb는 c, a, z, b가 모두 연속해서 나타나고, kin도 k, i, n이 연속해서 나타나기 때문에 그룹 단어이지만, aabbbccb는 b가 떨어져서 나타나기 때문에 그룹 단어가 아니다.
단어 N개를 입력으로 받아 그룹 단어의 개수를 출력하는 프로그램을 작성하시오.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1316
{
    internal class Program
    {
        static public bool IsGroupWord(string word)
        {
            List<char> eachChar = new List<char>();
            for (int i = 0; i < word.Length - 1; i++)
            {
                eachChar.Add(word[i]);

                if ((word[i + 1] != eachChar[i]) && (word.IndexOf(eachChar[i], i + 1) != -1))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsGroupWord(Console.ReadLine()))
                {
                    cnt++;
                }
            }
            Console.WriteLine($"{cnt}");
        }
    }
}
