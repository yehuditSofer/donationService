using Donation.BL;
using Donation.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using MailSendingWithWebApi.Controllers;

namespace Donation.Controllers
{
    public class saveDonationController : ApiController
    {
        public bool Get(IDonation myDonation)
        {
            if (myDonation.sumPay > 10000)
                new EmailController().SendEmail();
            return saveDonationBL.Get(myDonation);
        }
    }
}
