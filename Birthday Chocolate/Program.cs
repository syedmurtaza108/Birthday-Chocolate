///Solved in 30mine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Chocolate
{
    class Program
    {
        static int solve(List<int> s, int d, int m)
        {
            int ans = 0;
            if(s.Count == 1)
            {
                if (s[0] == d && m == 1)
                    ans = 1;
            }
            for (int i = 0; i < s.Count -1 ; i ++)
            {
                ans += CheckSum(s, i, m, d);
            }
            return ans;
        }

        static int CheckSum(List<int> s, int indexStart, int length, int d)
        {
            int ans = 0;
            int sum = 0;
            for(int i = indexStart; i< indexStart + length && i<s.Count; i++)
            {
                 sum += s[i];
            }
            if (sum == d)
                ans++;
            return ans;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(s, d, m);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
