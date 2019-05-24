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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // bttnCloseViewQuotes
         // 
         this.bttnCloseViewQuotes.Location = new System.Drawing.Point(847, 559);
         this.bttnCloseViewQuotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.bttnCloseViewQuotes.Name = "bttnCloseViewQuotes";
         this.bttnCloseViewQuotes.Size = new System.Drawing.Size(249, 54);
         this.bttnCloseViewQuotes.TabIndex = 20;
         this.bttnCloseViewQuotes.Text = "Cancel";
         this.bttnCloseViewQuotes.UseVisualStyleBackColor = true;
         this.bttnCloseViewQuotes.Click += new System.EventHandler(this.bttnCloseViewQuotes_Click);
         // 
         // lblViewQuotes
         // 
         this.lblViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblViewQuotes.Location = new System.Drawing.Point(370, 39);
         this.lblViewQuotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblViewQuotes.Name = "lblViewQuotes";
         this.lblViewQuotes.Size = new System.Drawing.Size(441, 60);
         this.lblViewQuotes.TabIndex = 19;
         this.lblViewQuotes.Text = "View Quotes";
         this.lblViewQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(27, 121);
         this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 24;
         this.dataGridView1.Size = new System.Drawing.Size(1141, 400);
         this.dataGridView1.TabIndex = 21;
         
         // 
         // ViewAllQuotes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.bttnCloseViewQuotes);
         this.Controls.Add(this.lblViewQuotes);
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "ViewAllQuotes";
         this.Text = "ViewAllQuotes";
         this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button bttnCloseViewQuotes;
      private System.Windows.Forms.Label lblViewQuotes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}