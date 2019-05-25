using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
   public partial class DisplayQuote : Form
   {
      public DisplayQuote(DeskQuote quote, decimal basePrice, decimal shippingCost, decimal drawersCost, decimal surfaceDecimal, decimal weight)
      {
         InitializeComponent();

            lblDeliveriFill.Text = quote.ShippingType;
            lblFillTotal.Text = lblFillTotal.Text + quote.QuotePrice.ToString();
            lblAreaCost.Text = "$" + weight.ToString();
            lblFillName.Text = quote.CustomerName;
            lblFillShipping.Text = "$" + shippingCost.ToString();
            lblFillDrawers.Text = "$" + drawersCost.ToString();
            lblSurfaceCost.Text = "$" + surfaceDecimal.ToString();
            lblBaseCost.Text = "$" + basePrice.ToString();

      }

      private void bttnCloseNewQuote_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void DisplayQuote_Load(object sender, EventArgs e)
      {
            
      }

    }
}
