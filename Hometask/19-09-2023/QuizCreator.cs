using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._19_09_2023
{
    public class QuizCreator
    {
        public async void CreateQuiz()
        {
            Console.Write("Fanni kiriting: ");
            string subject = Console.ReadLine();
            if (!Directory.Exists(subject))
            {
                Directory.CreateDirectory(subject);
            }

            Directory.SetCurrentDirectory(subject);
            Guid guid = Guid.NewGuid();

            string name = subject + guid.ToString()+".txt";

            using (FileStream file = new FileStream(name, FileMode.OpenOrCreate))
            using (StreamWriter writer = new StreamWriter(file))
            {
                bool lamp = true;
                while (lamp)
                {
                    string text = Console.ReadLine();
                    if (text == "cancel1234")
                        return;
                    writer.WriteLine(text);
                }
            }
        }
    }
}
