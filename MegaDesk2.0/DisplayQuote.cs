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
      public DisplayQuote(DeskQuote quote)
      {
         InitializeComponent();

            lblDeliveriFill.Text = quote.ShippingType;
            lblFillTotal.Text = lblFillTotal.Text + quote.QuotePrice.ToString();
            lblFillMaterial.Text = quote.Desk.SurfaceMaterial;
            lblFillName.Text = quote.CustomerName;
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
