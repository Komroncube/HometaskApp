using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._14_09_2023
{
    public class ClickApp
    {
        public void TransferMoney(string cardId, Payment payment)
        {
            var from = FileService.GetCard(cardId);
            var to = FileService.GetCard(payment.RecieveCardId);
            if(from != null && to != null)
            {
                if (from.balance >= payment.Amount * 1.02M)
                {
                    from.balance -= payment.Amount * 1.01M;
                    FileService.UpdateCard(from);
                    FileService.UpdateCard(to);
                }
            }
            
        }
    }
}
