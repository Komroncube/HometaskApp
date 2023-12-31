﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    public class SolutionFor_12_09_2023
    {
        public void Problem1()
        {
            string name = "Kamronbek";
            for (int i=0; i<=10;  i++)
            {
                if(i==0)
                {
                    Console.WriteLine(name[0]);
                }
                else
                {
                    break;
                }
            }
        }
        public void Problem1_New()
        {
            Console.Write("Natural kiriting: ");
            bool check = int.TryParse(Console.ReadLine(), out int number);
            if (check)
            {
                for (int i=0; i<=number;i++) 
                {
                    string blank = new string(' ', number - i);
                    Console.WriteLine("*"+blank+"*");
                }
                for (int i = 0; i <= number; i++)
                {
                    string blank = new string(' ', i);
                    Console.WriteLine("*"+blank+"*");
                }

            }
        }
        public void Problem2()
        {
            Console.Write("Natural kiriting: ");
            int number;
            bool check = isNumber(out number);
            int newnumber = 0, tmp = number;
            if (check)
            if (check)
            {
                while (number > 0 && check)
                {
                    newnumber = newnumber * 10 + number % 10;
                    number /= 10;
                }

                if (tmp == newnumber)
                {
                    Console.WriteLine("{0} polindrom son", tmp);
                }
                else
                {
                    Console.WriteLine("{0} polindrom son emas", tmp);
                }
            }
            else
            {
                Console.WriteLine("Son kiritilmadi");
            }
        }
        public void Problem3()
        {
            Console.Write("Natural kiriting: ");
            int number, tmp = 0;
            bool check = isNumber(out number);
            if (check)
            {
                int sign = 1;
                if (number <0)
                {
                    sign = -1;
                    number *= sign;
                }
                while (number > 0)
                {
                    tmp = tmp * 10 + number % 10;
                    number /= 10;
                }
                tmp *= sign;
                Console.WriteLine(tmp);
            }
            else 
            { 
                Console.WriteLine("Son kiritilmadi");
            }
        }
        public void Problem4()
        {
            Console.Write("Natural kiriting: ");
            int number;
            bool check = isNumber(out number);
            if (check)
            {
                for (int i = 0; i < number-1; i++) 
                {
                    string blank = new string(' ', number - i);
                    string stars = new string ('*', i);
                    Console.WriteLine(blank+stars+"*"+stars);
                }
                for (int i = 1; i < number+1; i++)
                {
                    string blank = new string(' ', i);
                    string stars = new string('*', number-i);
                    Console.WriteLine(blank + stars + "*" + stars);
                }
            }
        }
        private bool isNumber(out int number)
        {
            return int.TryParse(Console.ReadLine(), out number);
        }
        public string MaximumNumber(string num, int[] change)
        {
            foreach(int i in change) { Console.Write(i); }
            Console.WriteLine();
            string res = "";
            for (int i = 0; i < num.Length; i++)
            {
                int pos = Int32.Parse(num[i].ToString());
                int val = Int32.Parse(num[i].ToString());
                if (val < change[pos])
                {
                    res += change[pos].ToString();
                    change[pos] = val;
                }
                else
                {
                    res += num[i];
                }
            }
            foreach(int i in  change)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            return res;
        }
    }
}
