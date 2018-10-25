using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto_Quote.ViewModels
{
    public class AdminVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal QuoteAmount { get; set; }
    }
}