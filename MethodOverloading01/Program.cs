using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 29.0m;
            var b = 55.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(1, 0, true);

            Console.WriteLine($"int add: {answer}\ndecimal add: {decimalAnswer}");
            Console.WriteLine($"Boolean add: {thirdAnswer}");

            var paramsAdd = Add(1.1m, 5.0m, 6.8m, 7.6m);
            Console.WriteLine($"Using params keyword {paramsAdd}");
        }


        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return $"You are checked for false.\nAmount entered: {sum.ToString()}";
            }
        }

        public static int Add(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            return sum;
        }
        public static double Add(params double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            return sum;
        }
        public static decimal Add(params decimal[] nums)
        {
            decimal sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            return sum;
        }

    }
}