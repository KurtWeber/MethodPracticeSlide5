using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPracticeSlide5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 33, 5, 10, 25, 7, 50 }; // Assigning values the the array num[0] to num[5]
            Console.WriteLine("The sum of my array is {0}",sumNum(num));
        }
        static int sumNum(int[] num)
        {
            int answer = 0;
            for (int i = 0; i < num.Length; i++)
            {
                //Console.WriteLine(num[i]); number test
                answer += num[i]; // Same as answer = answer + num[i]
            }
            return answer;
        }
     }
}
