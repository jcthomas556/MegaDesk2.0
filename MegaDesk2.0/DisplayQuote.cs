﻿using System;
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
      public DisplayQuote()
      {
         InitializeComponent();
      }

      private void lblNewQuote_Click(object sender, EventArgs e)
      {

      }

      private void bttnCloseNewQuote_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
