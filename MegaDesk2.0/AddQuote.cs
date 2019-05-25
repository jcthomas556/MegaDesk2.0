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

        public JObject document = JObject.Parse(File.ReadAllText("document.json"));
        public decimal basePrice = 200;

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
            fillSurfaceMaterials();
            fillShippingOptions();
        }

        public decimal getWeight()
        {
            decimal depth = numericUpDownDepth.Value;

            decimal width = numericUpDownWidth.Value;

            decimal surfaceArea = (depth * width);

            return surfaceArea;

        }

        public decimal getSurfaceMaterialPrice()
        {
            JObject surfaceMaterial = (JObject)document["surfaceMaterial"];


            return int.Parse(surfaceMaterial[comboBoxSurfaceMaterial.SelectedItem].ToString());
        }

        public decimal getShippingCost()
        {
            int shippingPrice;

            JObject shippingOptions = (JObject)document["shippingOptions"];

            if (getWeight() <= 1000)
            {
                shippingPrice = int.Parse(shippingOptions[comboBoxDelivery.SelectedItem][0].ToString());
            }

            else if (getWeight() > 1000 && getWeight() < 2000)
            {
                shippingPrice = int.Parse(shippingOptions[comboBoxDelivery.SelectedItem][1].ToString());
            }

            else
            {
                shippingPrice = int.Parse(shippingOptions[comboBoxDelivery.SelectedItem][2].ToString());

            }

            return shippingPrice;
        }

        public decimal getDrawerCost()
        {
            return (numericUpDownNumOfDrawers.Value * 50);
        }

        public decimal GetQuotePrice()
        {

            return (getDrawerCost() + getShippingCost() + getWeight() + basePrice + getSurfaceMaterialPrice());

        }


        public void fillSurfaceMaterials()
        {
            JObject surfaceMaterial = (JObject)document["surfaceMaterial"];

            foreach (JProperty property in surfaceMaterial.Properties())
            {
                comboBoxSurfaceMaterial.Items.Add(property.Name);
            }

        }

        public void fillShippingOptions()
        {
            JObject shippingOptions = (JObject)document["shippingOptions"];

            foreach (JProperty property in shippingOptions.Properties())
            {
                comboBoxDelivery.Items.Add(property.Name);
            }

        }

        public bool validationErrors()
        {
            bool errors = false;

            if (comboBoxSurfaceMaterial.SelectedIndex == -1) //Nothing selected
            {
                MessageBox.Show("You must select a surface material", "Error");
                errors = true;
            }

            if (comboBoxDelivery.SelectedIndex == -1) //Nothing selected
            {
                MessageBox.Show("You must select a delivery option", "Error");
                errors = true;
            }

            return errors;

        }

        private void BttnGetQuote_Click(object sender, EventArgs e)
        {

            if (!validationErrors())
            {
                Desk newDesk = new Desk(int.Parse(numericUpDownWidth.Value.ToString()), int.Parse(numericUpDownDepth.Value.ToString()), int.Parse(numericUpDownNumOfDrawers.Value.ToString()), comboBoxSurfaceMaterial.SelectedItem.ToString());

                DeskQuote newQuote = new DeskQuote(inputCustomerName.Text, comboBoxDelivery.SelectedItem.ToString(), GetQuotePrice(), DateTime.Now, newDesk);

                string fileName = "quotes.json";
                List<DeskQuote> quotesList;

                if (File.Exists(fileName))
                {
                    quotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(fileName));
                }
                else
                {
                    quotesList = new List<DeskQuote>();
                }

                quotesList.Add(newQuote);
                string convertedJson = JsonConvert.SerializeObject(quotesList, Formatting.Indented);

                File.WriteAllText(fileName, convertedJson);

                DisplayQuote quote = new DisplayQuote(newQuote, basePrice, getShippingCost(), getDrawerCost(), getSurfaceMaterialPrice(), getWeight());
                quote.Show();
            }



        }
    }
}
