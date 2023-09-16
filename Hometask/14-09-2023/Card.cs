using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._14_09_2023
{
    public class Card
    {
        public Card(int balance, string ownerId)
        {
            this.balance = balance;
            OwnerId = ownerId;

        }
        public Card() { }

        public decimal balance { get; set; } = 10000;
        public string Id { get; set; }
        public DateOnly expiryDate { get; set; }
        public string OwnerId { get; set; }

    }
}
