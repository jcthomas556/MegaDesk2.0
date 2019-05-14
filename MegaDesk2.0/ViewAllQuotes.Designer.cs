namespace MegaDesk
{
   partial class ViewAllQuotes
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
         this.bttnCloseViewQuotes = new System.Windows.Forms.Button();
         this.lblViewQuotes = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // bttnCloseViewQuotes
         // 
         this.bttnCloseViewQuotes.Location = new System.Drawing.Point(565, 363);
         this.bttnCloseViewQuotes.Name = "bttnCloseViewQuotes";
         this.bttnCloseViewQuotes.Size = new System.Drawing.Size(166, 35);
         this.bttnCloseViewQuotes.TabIndex = 20;
         this.bttnCloseViewQuotes.Text = "Cancel";
         this.bttnCloseViewQuotes.UseVisualStyleBackColor = true;
         this.bttnCloseViewQuotes.Click += new System.EventHandler(this.bttnCloseViewQuotes_Click);
         // 
         // lblViewQuotes
         // 
         this.lblViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblViewQuotes.Location = new System.Drawing.Point(247, 25);
         this.lblViewQuotes.Name = "lblViewQuotes";
         this.lblViewQuotes.Size = new System.Drawing.Size(294, 39);
         this.lblViewQuotes.TabIndex = 19;
         this.lblViewQuotes.Text = "View Quotes";
         this.lblViewQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // ViewAllQuotes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.bttnCloseViewQuotes);
         this.Controls.Add(this.lblViewQuotes);
         this.Name = "ViewAllQuotes";
         this.Text = "ViewAllQuotes";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button bttnCloseViewQuotes;
      private System.Windows.Forms.Label lblViewQuotes;
   }
}