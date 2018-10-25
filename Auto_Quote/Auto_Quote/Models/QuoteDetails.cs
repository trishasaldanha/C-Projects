using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto_Quote.Models
{
    public class QuoteDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Birthday { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTicket { get; set; }
        public bool Coverage { get; set; }
        public decimal QuoteAmount { get; set; }
    }
}