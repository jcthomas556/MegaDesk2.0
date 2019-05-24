using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
  public class DeskQuote
   {
      public string CustomerName;
      public string ShippingType;
      public decimal QuotePrice;
      public DateTime QuoteDate;
      public Desk Desk;

    
      public DeskQuote(string CustomerName, string ShippingType, decimal QuotePrice, DateTime QuoteDate, Desk Desk)
      {
         this.CustomerName = CustomerName;
         this.ShippingType = ShippingType;
         this.QuotePrice = QuotePrice;
         this.QuoteDate = QuoteDate;
         this.Desk = Desk;
      }
   }
}
