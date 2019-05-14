namespace MegaDesk
{
   partial class SearchQuotes
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
         this.bttnCloseSearchQuotes = new System.Windows.Forms.Button();
         this.lblSearchQuotes = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // bttnCloseSearchQuotes
         // 
         this.bttnCloseSearchQuotes.Location = new System.Drawing.Point(572, 366);
         this.bttnCloseSearchQuotes.Name = "bttnCloseSearchQuotes";
         this.bttnCloseSearchQuotes.Size = new System.Drawing.Size(166, 35);
         this.bttnCloseSearchQuotes.TabIndex = 20;
         this.bttnCloseSearchQuotes.Text = "Cancel";
         this.bttnCloseSearchQuotes.UseVisualStyleBackColor = true;
         this.bttnCloseSearchQuotes.Click += new System.EventHandler(this.bttnCloseSearchQuotes_Click);
         // 
         // lblSearchQuotes
         // 
         this.lblSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSearchQuotes.Location = new System.Drawing.Point(254, 28);
         this.lblSearchQuotes.Name = "lblSearchQuotes";
         this.lblSearchQuotes.Size = new System.Drawing.Size(294, 39);
         this.lblSearchQuotes.TabIndex = 19;
         this.lblSearchQuotes.Text = "Search Quotes";
         this.lblSearchQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // SearchQuotes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.bttnCloseSearchQuotes);
         this.Controls.Add(this.lblSearchQuotes);
         this.Name = "SearchQuotes";
         this.Text = "SearchQuotes";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button bttnCloseSearchQuotes;
      private System.Windows.Forms.Label lblSearchQuotes;
   }
}