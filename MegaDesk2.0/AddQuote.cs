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
   public partial class AddQuote : Form
   {
      public AddQuote()
      {
         InitializeComponent();

      }

        private void textBox2_TextChanged(object sender, EventArgs e)
      {

      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void bttnCloseNewQuote_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void AddQuote_Load(object sender, EventArgs e)
      {
            getSurfaceMaterial();
      }

        public void getSurfaceMaterial()
        {
            JObject document = JObject.Parse(File.ReadAllText("document.json"));

            JObject surfaceMaterial = (JObject)document["surfaceMaterial"];

            foreach (JProperty property in surfaceMaterial.Properties())
            {
                comboBoxSurfaceMaterial.Items.Add(property.Name);
            }

        }

        private void BttnGetQuote_Click(object sender, EventArgs e)
        {
            // read combobox surface material
            MessageBox.Show(comboBoxSurfaceMaterial.SelectedItem.ToString());



        }
    }
}
