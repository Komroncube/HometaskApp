using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._14_09_2023
{
    public class User
    {
        public User(string id)
        {
            Id = id;
            cards.Add(new Card(0, id));

        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Card> cards { get; set; }
    }
}
