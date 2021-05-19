using Donation.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.BL
{
    public class saveDonationBL
    {
        public static bool Get(IDonation myDonation)
        {
            if (myDonation.name != '' && myDonation.sumPay > 0 && myDonation.type != '' && myDonation.designation != '' && myDonation.CurrencyType != '' && myDonation.ExchangeRate > 0)
            {
                return saveOnDataBaseBL.Get(myDonation);
            }
            else return false;
        }

    }
}
