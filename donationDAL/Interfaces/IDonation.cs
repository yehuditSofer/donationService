using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.DAL.Interfaces
{
    public class IDonation
    {
        public string name { get; set; }
        public int sumPay { get; set; }
        public string type { get; set; }
        public string designation { get; set; }
        public string terms { get; set; }
        public string CurrencyType { get; set; }
        public int ExchangeRate { get; set; }
    }
}
