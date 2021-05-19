using Donation.BL;
using Donation.DAL.Interfaces;
using MailSendingWithWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace donation.Controllers
{
    public class editDonationController : ApiController
    {
        public bool Get(IDonation myDonation)
        {
            if (myDonation.sumPay > 10000)
                new EmailController().SendEmail();
            return editDonationBL.Get(myDonation);
        }
    }
}
