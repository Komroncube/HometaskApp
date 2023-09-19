using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hometask._18_09_2023
{
    public class RegexHometask
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public void GetName()
        {
            Console.Write("Ismni kiriting: ");
            Name = Console.ReadLine();
        }
        public void GetEmail()
        {
            Console.Write("Emailni kiriting: ");
            string test = Console.ReadLine();
            bool check = Regex.IsMatch(test, @"[a-zA-Z]+@gmail\.\w{2,3}");
            if(check)
            {
                Email = test;
            }
        }
        public void GetNumber()
        {
            Console.Write("Telefon raqamni kiriting: ");
            string test = Console.ReadLine();
            bool check = Regex.IsMatch(test, @"\+998\d{9}");
            if (check)
            {
                PhoneNumber = test;
            }
        }
        public void GetPassword()
        {
            Console.Write("Parolni yarating: ");
            string test = Console.ReadLine();
            bool check = Regex.IsMatch(test, @"""^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()+=_\-{} [\]\:\;\?<>,\.])[A-Za-z\d!@#$%^&*()+=_\-{} [\]\:\;\?<>,\.]{8,16}$""");
            if(check)
            {
                Password = test;
            }
        }
        public void PrintAllData()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Name: {this.Email}");
            Console.WriteLine($"Name: {this.PhoneNumber}");
            Console.WriteLine($"Name: {this.Password}");

        }
        public void GetDate()
        {
            Console.Write("Tug'ilgan sanani kiriting: ");
            string test = Console.ReadLine();
            bool check = Regex.IsMatch(test, @"[1-31]-[1-12]-\d+");
            if (check)
            {
                PhoneNumber = test;
            }
        }
        public void Replace(string text)
        {
            Console.WriteLine(text);
            string result = Regex.Replace(text, @"\W", "");
            Console.WriteLine(result);
        }
    }
}
