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
            this.bttnCloseViewQuotes.Location = new System.Drawing.Point(753, 447);
            this.bttnCloseViewQuotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnCloseViewQuotes.Name = "bttnCloseViewQuotes";
            this.bttnCloseViewQuotes.Size = new System.Drawing.Size(221, 43);
            this.bttnCloseViewQuotes.TabIndex = 20;
            this.bttnCloseViewQuotes.Text = "Cancel";
            this.bttnCloseViewQuotes.UseVisualStyleBackColor = true;
            this.bttnCloseViewQuotes.Click += new System.EventHandler(this.bttnCloseViewQuotes_Click);
            // 
            // lblViewQuotes
            // 
            this.lblViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewQuotes.Location = new System.Drawing.Point(329, 31);
            this.lblViewQuotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewQuotes.Name = "lblViewQuotes";
            this.lblViewQuotes.Size = new System.Drawing.Size(392, 48);
            this.lblViewQuotes.TabIndex = 19;
            this.lblViewQuotes.Text = "View Quotes";
            this.lblViewQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bttnCloseViewQuotes);
            this.Controls.Add(this.lblViewQuotes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button bttnCloseViewQuotes;
      private System.Windows.Forms.Label lblViewQuotes;
   }
}