using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._14_09_2023
{
    public class Payment
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;
        public string RecieveCardId { get; set; }
    }
}
