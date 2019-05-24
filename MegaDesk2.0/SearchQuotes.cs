using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
   public partial class SearchQuotes : Form
   {
      public SearchQuotes()
      {
         InitializeComponent();
         fillSurfaceMaterials();
      }
      private void bttnCloseSearchQuotes_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      public bool validationErrors()
      {
         bool errors = false;

         if (comboBoxFilterOptions.SelectedIndex == -1) //Nothing selected
         {
            MessageBox.Show("You must select a surface material Filter Option", "Error");
            errors = true;
         }
         return errors;
      }

      private void bttnFilter_Click(object sender, EventArgs e)
      {
         if (!validationErrors())
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
            }).Where(d => (comboBoxFilterOptions.SelectedItem.ToString() == d.Material)).ToList();
         }

      }
      public void fillSurfaceMaterials()
      {
         JObject document = JObject.Parse(File.ReadAllText("document.json"));
         JObject surfaceMaterial = (JObject)document["surfaceMaterial"];

         foreach (JProperty property in surfaceMaterial.Properties())
         {
            comboBoxFilterOptions.Items.Add(property.Name);
         }

      }
   }
}
