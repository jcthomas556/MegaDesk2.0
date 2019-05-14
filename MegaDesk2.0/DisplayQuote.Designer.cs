namespace MegaDesk
{
   partial class DisplayQuote
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
         this.lblDisplayQuotes = new System.Windows.Forms.Label();
         this.bttnCloseDisplayQuotes = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblDisplayQuotes
         // 
         this.lblDisplayQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDisplayQuotes.Location = new System.Drawing.Point(225, 37);
         this.lblDisplayQuotes.Name = "lblDisplayQuotes";
         this.lblDisplayQuotes.Size = new System.Drawing.Size(294, 39);
         this.lblDisplayQuotes.TabIndex = 5;
         this.lblDisplayQuotes.Text = "Display Quotes";
         this.lblDisplayQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblDisplayQuotes.Click += new System.EventHandler(this.lblNewQuote_Click);
         // 
         // bttnCloseDisplayQuotes
         // 
         this.bttnCloseDisplayQuotes.Location = new System.Drawing.Point(543, 375);
         this.bttnCloseDisplayQuotes.Name = "bttnCloseDisplayQuotes";
         this.bttnCloseDisplayQuotes.Size = new System.Drawing.Size(166, 35);
         this.bttnCloseDisplayQuotes.TabIndex = 18;
         this.bttnCloseDisplayQuotes.Text = "Cancel";
         this.bttnCloseDisplayQuotes.UseVisualStyleBackColor = true;
         this.bttnCloseDisplayQuotes.Click += new System.EventHandler(this.bttnCloseNewQuote_Click);
         // 
         // DisplayQuote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.bttnCloseDisplayQuotes);
         this.Controls.Add(this.lblDisplayQuotes);
         this.Name = "DisplayQuote";
         this.Text = "DisplayQuote";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label lblDisplayQuotes;
      private System.Windows.Forms.Button bttnCloseDisplayQuotes;
   }
}