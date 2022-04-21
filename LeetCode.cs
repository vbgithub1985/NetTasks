using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode
    {
        public delegate void Del(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

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
        public static bool IsPalindrome(int x)
        {
            if (x <= Math.Pow(-2.0, 31) && (x >= Math.Pow(2.0, 31))) { return false; }
            bool result = false;
            int divisionRes = x / 2;
            int divResRevers = 0;
            var resultstring = new string(Convert.ToString(x).ToCharArray().Reverse().ToArray());
            String sDig = Convert.ToString(resultstring);
            try
            {
                divResRevers = Convert.ToInt32(sDig) / 2;
                if (divisionRes == divResRevers)
                {
                    result = true;
                }
            }
            catch (Exception e)
            {
                result = false;
            }
            
            return result;
        }
        static int romanToInt(string s)
        {
            if (s.Length < 0 || s.Length > 15) return 0;

            int result = 0;
            Dictionary<string, int> roman = new Dictionary<string, int>();
            roman.Add("I", 1);
            roman.Add("V", 5);
            roman.Add("X", 10);
            roman.Add("L", 50);
            roman.Add("C", 100);
            roman.Add("D", 500);
            roman.Add("M", 1000);

            string sres = "";
            int i = 0;
            while (i <= s.Length-1) {
                if (i + 1 > s.Length - 1)
                {
                    result += roman[s.Substring(i, 1)];
                }
                else
                {
                    if (roman[s.Substring(i, 1)] >= roman[s.Substring(i + 1, 1)])
                    {
                        result += roman[s.Substring(i, 1)];
                    }
                    else
                    {
                        result += roman[s.Substring(i + 1, 1)];
                        result -= roman[s.Substring(i, 1)];
                        i++;
                    }

                }
                
                i++;
            }
            return result;
        }
        public static bool IsValid(string s)
        {
            bool result = false;
            string workS = s;
            Dictionary<string, string> brackets = new Dictionary<string, string>();
            brackets.Add("(", ")");
            brackets.Add("{", "}");
            brackets.Add("[", "]");
            int i = 0;
            

            while (i < workS.Length - 1)
            {
                if (brackets.ContainsKey(workS.Substring(i, 1)))
                {
                    if (workS.IndexOf(brackets[workS.Substring(i, 1)], i) - workS.IndexOf(workS.Substring(i, 1), i) == 1)
                    {
                        workS = workS.Remove(workS.IndexOf(brackets[workS.Substring(i, 1)], i), 1);
                        workS = workS.Remove(workS.IndexOf(workS.Substring(i, 1), i), 1);
                        i = i <= 1 ? 0 : (i - 2);
                    }
                    else i++;
                }
                else i++;
            }

            
            return workS.Length==0;
        }

        

       
    }

    
}

