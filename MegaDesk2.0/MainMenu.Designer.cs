namespace MegaDesk
{
   partial class MainMenu
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.btnAddNewQuote = new System.Windows.Forms.Button();
         this.bttnViewQuotes = new System.Windows.Forms.Button();
         this.bttnSearchQuotes = new System.Windows.Forms.Button();
         this.bttnExit = new System.Windows.Forms.Button();
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         this.SuspendLayout();
         // 
         // btnAddNewQuote
         // 
         this.btnAddNewQuote.AutoSize = true;
         this.btnAddNewQuote.Location = new System.Drawing.Point(13, 39);
         this.btnAddNewQuote.Name = "btnAddNewQuote";
         this.btnAddNewQuote.Size = new System.Drawing.Size(93, 47);
         this.btnAddNewQuote.TabIndex = 0;
         this.btnAddNewQuote.Text = "Add New Quote";
         this.btnAddNewQuote.UseVisualStyleBackColor = true;
         this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
         // 
         // bttnViewQuotes
         // 
         this.bttnViewQuotes.AutoSize = true;
         this.bttnViewQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.bttnViewQuotes.Location = new System.Drawing.Point(13, 92);
         this.bttnViewQuotes.Name = "bttnViewQuotes";
         this.bttnViewQuotes.Size = new System.Drawing.Size(93, 39);
         this.bttnViewQuotes.TabIndex = 1;
         this.bttnViewQuotes.Text = "Veiw All Quotes";
         this.bttnViewQuotes.UseVisualStyleBackColor = true;
         this.bttnViewQuotes.Click += new System.EventHandler(this.bttnViewQuotes_Click);
         // 
         // bttnSearchQuotes
         // 
         this.bttnSearchQuotes.AutoSize = true;
         this.bttnSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.bttnSearchQuotes.Location = new System.Drawing.Point(13, 137);
         this.bttnSearchQuotes.Name = "bttnSearchQuotes";
         this.bttnSearchQuotes.Size = new System.Drawing.Size(93, 38);
         this.bttnSearchQuotes.TabIndex = 2;
         this.bttnSearchQuotes.Text = "Search Quotes";
         this.bttnSearchQuotes.UseVisualStyleBackColor = true;
         this.bttnSearchQuotes.Click += new System.EventHandler(this.bttnSearchQuotes_Click);
         // 
         // bttnExit
         // 
         this.bttnExit.AutoSize = true;
         this.bttnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.bttnExit.Location = new System.Drawing.Point(13, 181);
         this.bttnExit.Name = "bttnExit";
         this.bttnExit.Size = new System.Drawing.Size(93, 41);
         this.bttnExit.TabIndex = 3;
         this.bttnExit.Text = "Exit";
         this.bttnExit.UseVisualStyleBackColor = true;
         this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
         // 
         // imageList1
         // 
         this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
         this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         // 
         // MainMenu
         // 
         this.BackgroundImage = global::MegaDesk.Properties.Resources.Cherry_wood_full_sheet_large;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.CancelButton = this.bttnExit;
         this.ClientSize = new System.Drawing.Size(511, 267);
         this.Controls.Add(this.bttnExit);
         this.Controls.Add(this.bttnSearchQuotes);
         this.Controls.Add(this.bttnViewQuotes);
         this.Controls.Add(this.btnAddNewQuote);
         this.Name = "MainMenu";
         this.Text = "MegaDesk";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnAddNewQuote;
      private System.Windows.Forms.Button bttnViewQuotes;
      private System.Windows.Forms.Button bttnSearchQuotes;
      private System.Windows.Forms.Button bttnExit;
      private System.Windows.Forms.ImageList imageList1;
   }
}

