using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._14_09_2023
{
    public static class FileService
    {
        public static void AddCard(Card card)
        {
            string path = FileConfig.Path +@"\"+ FileConfig.Dirname;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += @"\"+ FileConfig.CardData;
            if(!File.Exists(path))
                File.Create(path);
            string[] lines = File.ReadAllLines(path);
            var debitcards = new List<Card>();
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                var debitcard = new Card()
                {
                    Id = values[0],
                    expiryDate = DateOnly.ParseExact(values[1], "DD-MM-YYYY"),
                    balance = decimal.Parse(values[2]),
                    OwnerId = values[3],
                };
            }
            var checkcard = debitcards.FirstOrDefault(x => x.Id == card.Id);
            if(checkcard==null)
            {
                debitcards.Add(card);
                using (var writer = new StreamWriter(path))
                {
                    foreach (var data in debitcards)
                    {
                        string line = $"{card.Id},{card.expiryDate},{card.balance},{card.OwnerId}";
                        writer.WriteLine(line);
                    }
                }
            }

        }
        public static Card? GetCard(string cardId)
        {
            string path = FileConfig.Path + @"\"+  FileConfig.Dirname;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += @"\" + FileConfig.CardData;
            if (!File.Exists(path))
                File.Create(path);
            string[] lines = File.ReadAllLines(path);
            var debitcards = new List<Card>();
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                var debitcard = new Card()
                {
                    Id = values[0],
                    expiryDate = DateOnly.ParseExact(values[1], "DD-MM-YYYY"),
                    balance = decimal.Parse(values[2]),
                    OwnerId = values[3],
                };
            }
            var checkcard = debitcards.FirstOrDefault(x => x.Id ==cardId);
            return checkcard;
        }
        public static void UpdateCard (Card card)
        {
            string path = FileConfig.Path + @"\" + FileConfig.Dirname;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            path += @"\" + FileConfig.CardData;
            if (!File.Exists(path))
                File.Create(path);

            string[] lines = File.ReadAllLines(path);
            var debitcards = new List<Card>();
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                var debitcard = new Card()
                {
                    Id = values[0],
                    expiryDate = DateOnly.ParseExact(values[1], "DD-MM-YYYY"),
                    balance = decimal.Parse(values[2]),
                    OwnerId = values[3],
                };
            }
            var checkcard = debitcards.FirstOrDefault(x => x.Id == card.Id);
            if (checkcard != null)
            {
                using (var writer = new StreamWriter(path))
                {
                    foreach (var data in debitcards)
                    {
                        string line = $"{card.Id},{card.expiryDate},{card.balance},{card.OwnerId}";
                        writer.WriteLine(line);
                    }
                }
            }
        }
        public static void AddUser(User user)
        {
            string path = FileConfig.Path + @"\" + FileConfig.Dirname;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            path += @"\" + FileConfig.UserData;
            if (!File.Exists(path))
                File.Create(path);
            string[] lines = File.ReadAllLines(path);
            var users = new List<User>();
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                var person = new Card()
                {
                    Id = values[0],
                    expiryDate = DateOnly.ParseExact(values[1], "DD-MM-YYYY"),
                    balance = decimal.Parse(values[2]),
                    OwnerId = values[3],
                };
            }
            var checkcard = users.FirstOrDefault(x => x.Id == user.Id);
            if (checkcard == null)
            {
                users.Add(user);
                using (var writer = new StreamWriter(path))
                {
                    foreach (var data in users)
                    {
                        string line = $"{user.Id},{user.FirstName},{user.LastName},{user.PhoneNumber}";
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
