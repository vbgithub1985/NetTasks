using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace ConsoleApp1
{

    //public sealed class Circle
    //{
    //    private double radius = 5.0;

    //    public double Calculate(Func<double, double> op)
    //    {
    //        return op(radius);
    //    }
    //}

    

    



    class Program
    {
        private static string result;
        static String location;
        static DateTime time;
        delegate void Printer();

        public static string sortDigitFromStrReverse(string str)
        {
            string result = "";
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            result = new string(arr);
            return result;
        }

        public static bool makeSecondStrringFromFirst(string str, string str2)
        {
            int count = 0;

            for (int i = 0; i < str2.Length; i++)
            {
                string pattern = str2.Substring(i, 1) + @"(\w*)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(str);
                if (matches.Count > 0)
                {
                    count++;
                }
            }
            return count == str2.Length;
        }

        static long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        }

        static int TotalCountEvenNumbers(int[] intArray)
        {
            return intArray.Count(i => i % 2 == 0);
        }

        static long TotalAllEvenNumbers2(int[] intArray)
        {
            return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        }

        static async Task<string> SaySomething()
        {
            //await Task.Delay(5);
            System.Threading.Thread.Sleep(5);
            result = "Hello world!";
            return result;
        }

        //static void Main(string[] args)
        //{
            //Console.WriteLine("Enter kilometrs");
            //int km = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(km * 1000);
       

            //SaySomething();
            //Console.WriteLine(result);
            //int[] arr = { 5, 6, 4, 33, 5, 6, 7, 9, 2, 8, 12, 13, 262};

            //Console.WriteLine(TotalAllEvenNumbers(arr));
            //Console.WriteLine(TotalAllEvenNumbers2(arr));
            //Console.WriteLine(TotalCountEvenNumbers(arr));

            //Console.WriteLine(location == null ? "location is null" : location);
            //Console.WriteLine(time == null ? "time is null" : time.ToString());

            //Circle c = new Circle();
            //Console.WriteLine(c.Calculate(r => 2 * Math.PI * r));

        //}

        
    }
}
