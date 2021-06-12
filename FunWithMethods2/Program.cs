using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with methods*****");

            //pass two variables in by value
            int x = 9, y = 10;
            Console.WriteLine("before the call: x={0} and y={1}", x, y);
            Console.WriteLine($"Answer is:{Add(x, y)}");
            Console.WriteLine("After the call: x={0} and y={1}", x, y);

            //no need to assign initial value to local variables
            //used as output parameter,provided the first time
            //you use them is as out arguments
            //C# 7 allows for out parameters to  be declared in the
            //method call
            Add2(90, 90, out int ans);
            Console.WriteLine($"90 + 90={ans}");

            //the ref modifier
            string str1 = "Jason";
            string str2 = "Joan";
            Console.WriteLine("Before ref modifier call {0},{1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After the call: {0},{1}", str1, str2);

            //calling method with param keyword modifier assigning
            //coma delimited values
            double average = 0;
            average =CalculateAverage( 3.4, 5.3, 2.4, 1.5);
            Console.WriteLine("the average of data is: {0}", average);

            //calling method with param keyword modifier assigning
            //array 
            double[] data = { 4.5, 2.4, 1.3 };
            average = CalculateAverage(data);
            Console.WriteLine("the average of data is: {0}", average);

            //sending in zero value
            average = CalculateAverage();
            Console.WriteLine("the average of data is: {0}", average);

            Console.ReadLine();

        }

        private static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("you sent me {0} value",values.Length);

            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return (sum / values.Length);

        }

        private static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s2;
            s2 = s1;
            s1 = tempStr;

        }

        static void Add2(int x, int y, out int ans)
        {
            ans = x + y;
        }

        private static int Add(int x, int y)
        {
            int ans = x + y;
            //caller will not see this changes as you are 
            //modifying a copy of the original data
            x = 88888;
            y = 999999;
            return ans;
        }

    }
}
