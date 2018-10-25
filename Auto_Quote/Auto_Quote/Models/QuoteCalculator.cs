using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto_Quote.Models
{
    public class QuoteCalculator
    {
        public static decimal Calculate(QuoteDetails quote)
        {
            decimal quoteAmount = 50;
            DateTime today = DateTime.Now;
            int userAge = Convert.ToInt32(today.Year - quote.Birthday.Year);
            if (userAge < 25 || userAge > 100)
            {
                quoteAmount += 25;
            }
            if (userAge < 18)
            {
                quoteAmount += 100;
            }
            if (quote.CarYear < 2000)
            {
                quoteAmount += 25;
            }
            if (quote.CarYear > 2015)
            {
                quoteAmount += 25;
            }
            if (quote.CarMake.ToLower() == "porsche")
            {
                quoteAmount += 25;
            }
            if (quote.CarModel.ToLower() == "911 carrera")
            {
                quoteAmount += 25;
            }
            if (quote.SpeedingTicket > 0)
            {
                quoteAmount += quote.SpeedingTicket * 10;
            }
            if (quote.DUI == true)
            {
                quoteAmount = quoteAmount * 1.25m;
            }
            if (quote.Coverage == true)
            {
                quoteAmount = quoteAmount * 1.5m;
            }
            return quoteAmount;
        }
    }
}