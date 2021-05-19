using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.DAL.Interfaces
{
    public class IEmail
    {
        public string toname { get; set; }
        public string toemail { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}
