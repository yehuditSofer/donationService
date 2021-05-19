﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace donation.Models
//{
//    public class EmailModel
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;  
  
namespace MailSendingWithWebApi.Models
{
    public class EmailModel
    {
        [Required, Display(Name = "Your name")]
        public string toname { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string toemail { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string message { get; set; }
    }
}