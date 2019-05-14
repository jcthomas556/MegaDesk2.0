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
   public partial class MainMenu : Form
   {
      private Form _mainMenu;

      public MainMenu()
      {
         InitializeComponent();
      }

      private void btnAddNewQuote_Click(object sender, EventArgs e)
      {
         AddQuote newQuote = new AddQuote();
         newQuote.ShowDialog();

      }

      private void bttnViewQuotes_Click(object sender, EventArgs e)
      {
         ViewAllQuotes ViewQuotes = new ViewAllQuotes();
         ViewQuotes.ShowDialog();
      }

      private void bttnSearchQuotes_Click(object sender, EventArgs e)
      {
         SearchQuotes SearchQuotes = new SearchQuotes();
         SearchQuotes.ShowDialog();
      }

      private void bttnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
