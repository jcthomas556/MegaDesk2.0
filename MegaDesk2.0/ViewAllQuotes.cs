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

        }
    }
}
