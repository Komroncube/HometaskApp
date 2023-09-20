using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._19_09_2023
{
    public class TestForStudents
    {
        public void CreateTestForStudent()
        {
            Console.Write("Nechta bola va nechatadan test: ");
            string text = Console.ReadLine();
            string[] data = text.Split(" ");
            int studentCount = Int32.Parse(data[0]);
            int testCount = Int32.Parse(data[1]);

            Random random = new Random();

            List<string> ls = new List<string>();
            using (FileStream file = new FileStream(@"fizika\baza.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string txt= sr.ReadLine();
                        ls.Add(txt);

                    }
                }
            }
            for(int i=0; i<studentCount; i++)
            {
                if(!Directory.Exists("talabalar"))
                {
                    Directory.CreateDirectory("talabalar");
                }
                using(FileStream file = new FileStream(@$"talabalar\student-{i}.txt", FileMode.Create))
                using(StreamWriter sw = new StreamWriter(file))
                    {
                        for(int j =  0; j < testCount; j++)
                        {
                            var index = random.Next(0, ls.Count / 2) * 2;

                            sw.WriteLine(ls[index]);
                            sw.WriteLine(ls[index + 1]);
                        }
                    }
            }


        }
    }
}
