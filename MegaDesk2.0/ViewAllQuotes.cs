using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
   public partial class ViewAllQuotes : Form
   {
      public ViewAllQuotes()
      {
         InitializeComponent();
      }

      private void bttnCloseViewQuotes_Click(object sender, EventArgs e)
      {
         this.Close();
      }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            string fileName = "quotes.json";

            List<DeskQuote> result = JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(fileName));

            dataGridView1.DataSource = result.Select(d => new
            {
               Date = d.QuoteDate,
               Name = d.CustomerName,
               Material = d.Desk.SurfaceMaterial,
               Price = d.QuotePrice.ToString("c"),
               Delivery = d.ShippingType,
               Drawers = d.Desk.NumberOfDrawers,
               Width = d.Desk.Width,
               Depth = d.Desk.Depth

            }).ToList();

      }
   }
}
