/*백준 4673번 문제
 셀프 넘버는 1949년 인도 수학자 D.R. Kaprekar가 이름 붙였다. 양의 정수 n에 대해서 d(n)을 n과 n의 각 자리수를 더하는 함수라고 정의하자. 예를 들어, d(75) = 75+7+5 = 87이다.

양의 정수 n이 주어졌을 때, 이 수를 시작해서 n, d(n), d(d(n)), d(d(d(n))), ...과 같은 무한 수열을 만들 수 있다. 

n을 d(n)의 생성자라고 한다. 33은 39의 생성자이고, 39는 51의 생성자, 51은 57의 생성자이다. 생성자가 한 개보다 많은 경우도 있다. 예를 들어, 101은 생성자가 2개(91과 100) 있다. 

생성자가 없는 숫자를 셀프 넘버라고 한다. 100보다 작은 셀프 넘버는 총 13개가 있다. 1, 3, 5, 7, 9, 20, 31, 42, 53, 64, 75, 86, 97

10000보다 작거나 같은 셀프 넘버를 한 줄에 하나씩 출력하는 프로그램을 작성하시오.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4673
{
    internal class Program
    {
        public static int d(int n)
        {
            int sum = n;
            while (n != 0)
            {
            // 각 자리수를 더하기 위해 10으로 나눈 나머지로 1의 자리 수를 더함
                sum += n % 10;
            // 정수 나눗셈으로 최하위 자리수 제거
                n /= 10;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            // 1 ~ 10000 까지 리스트 생성
            List<int> nums = new List<int>(Enumerable.Range(1, 10001).ToArray());
            for (int i = 1; i < 10001; i++)
            {
                // d(n)을 했을 때 나오는 수를 제거
                nums.Remove(d(i));
            }

            foreach (int x in nums)
            {
                Console.WriteLine("{0}", x);
            }

        }
    }
}
