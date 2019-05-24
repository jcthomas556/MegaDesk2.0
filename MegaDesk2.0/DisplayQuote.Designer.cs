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
         this.lblDelivery = new System.Windows.Forms.Label();
         this.lblFillDelivery = new System.Windows.Forms.Label();
         this.lblFillShipping = new System.Windows.Forms.Label();
         this.lblShipping = new System.Windows.Forms.Label();
         this.lblFillMaterialCost = new System.Windows.Forms.Label();
         this.lblMaterialCost = new System.Windows.Forms.Label();
         this.lblFillDrawerCost = new System.Windows.Forms.Label();
         this.lbl = new System.Windows.Forms.Label();
         this.lblBaseCost = new System.Windows.Forms.Label();
         this.lblFillTotal = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.lblSizeCost = new System.Windows.Forms.Label();
         this.lblFillSizeCost = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblDisplayQuotes
         // 
         this.lblDisplayQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDisplayQuotes.Location = new System.Drawing.Point(166, 23);
         this.lblDisplayQuotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblDisplayQuotes.Name = "lblDisplayQuotes";
         this.lblDisplayQuotes.Size = new System.Drawing.Size(441, 60);
         this.lblDisplayQuotes.TabIndex = 5;
         this.lblDisplayQuotes.Text = "Your Order";
         this.lblDisplayQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblDisplayQuotes.Click += new System.EventHandler(this.lblNewQuote_Click);
         // 
         // bttnCloseDisplayQuotes
         // 
         this.bttnCloseDisplayQuotes.Location = new System.Drawing.Point(262, 589);
         this.bttnCloseDisplayQuotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.bttnCloseDisplayQuotes.Name = "bttnCloseDisplayQuotes";
         this.bttnCloseDisplayQuotes.Size = new System.Drawing.Size(249, 54);
         this.bttnCloseDisplayQuotes.TabIndex = 18;
         this.bttnCloseDisplayQuotes.Text = "OK";
         this.bttnCloseDisplayQuotes.UseVisualStyleBackColor = true;
         this.bttnCloseDisplayQuotes.Click += new System.EventHandler(this.bttnCloseNewQuote_Click);
         // 
         // lblDelivery
         // 
         this.lblDelivery.AutoSize = true;
         this.lblDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDelivery.Location = new System.Drawing.Point(13, 102);
         this.lblDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblDelivery.Name = "lblDelivery";
         this.lblDelivery.Size = new System.Drawing.Size(172, 47);
         this.lblDelivery.TabIndex = 19;
         this.lblDelivery.Text = "Delivery";
         this.lblDelivery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblFillDelivery
         // 
         this.lblFillDelivery.AutoSize = true;
         this.lblFillDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFillDelivery.Location = new System.Drawing.Point(367, 99);
         this.lblFillDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFillDelivery.Name = "lblFillDelivery";
         this.lblFillDelivery.Size = new System.Drawing.Size(0, 47);
         this.lblFillDelivery.TabIndex = 20;
         this.lblFillDelivery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblFillDelivery.Click += new System.EventHandler(this.label2_Click);
         // 
         // lblFillShipping
         // 
         this.lblFillShipping.AutoSize = true;
         this.lblFillShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFillShipping.Location = new System.Drawing.Point(367, 158);
         this.lblFillShipping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFillShipping.Name = "lblFillShipping";
         this.lblFillShipping.Size = new System.Drawing.Size(43, 47);
         this.lblFillShipping.TabIndex = 22;
         this.lblFillShipping.Text = "$";
         this.lblFillShipping.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblShipping
         // 
         this.lblShipping.AutoSize = true;
         this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblShipping.Location = new System.Drawing.Point(13, 161);
         this.lblShipping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblShipping.Name = "lblShipping";
         this.lblShipping.Size = new System.Drawing.Size(182, 47);
         this.lblShipping.TabIndex = 21;
         this.lblShipping.Text = "Shipping";
         this.lblShipping.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblFillMaterialCost
         // 
         this.lblFillMaterialCost.AutoSize = true;
         this.lblFillMaterialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFillMaterialCost.Location = new System.Drawing.Point(367, 229);
         this.lblFillMaterialCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFillMaterialCost.Name = "lblFillMaterialCost";
         this.lblFillMaterialCost.Size = new System.Drawing.Size(43, 47);
         this.lblFillMaterialCost.TabIndex = 24;
         this.lblFillMaterialCost.Text = "$";
         this.lblFillMaterialCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblMaterialCost
         // 
         this.lblMaterialCost.AutoSize = true;
         this.lblMaterialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblMaterialCost.Location = new System.Drawing.Point(13, 229);
         this.lblMaterialCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblMaterialCost.Name = "lblMaterialCost";
         this.lblMaterialCost.Size = new System.Drawing.Size(264, 47);
         this.lblMaterialCost.TabIndex = 23;
         this.lblMaterialCost.Text = "Material Cost";
         this.lblMaterialCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblFillDrawerCost
         // 
         this.lblFillDrawerCost.AutoSize = true;
         this.lblFillDrawerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFillDrawerCost.Location = new System.Drawing.Point(367, 291);
         this.lblFillDrawerCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFillDrawerCost.Name = "lblFillDrawerCost";
         this.lblFillDrawerCost.Size = new System.Drawing.Size(43, 47);
         this.lblFillDrawerCost.TabIndex = 26;
         this.lblFillDrawerCost.Text = "$";
         this.lblFillDrawerCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lbl
         // 
         this.lbl.AutoSize = true;
         this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl.Location = new System.Drawing.Point(13, 291);
         this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lbl.Name = "lbl";
         this.lbl.Size = new System.Drawing.Size(250, 47);
         this.lbl.TabIndex = 25;
         this.lbl.Text = "Drawer Cost";
         this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblBaseCost
         // 
         this.lblBaseCost.AutoSize = true;
         this.lblBaseCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBaseCost.Location = new System.Drawing.Point(367, 420);
         this.lblBaseCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblBaseCost.Name = "lblBaseCost";
         this.lblBaseCost.Size = new System.Drawing.Size(112, 47);
         this.lblBaseCost.TabIndex = 28;
         this.lblBaseCost.Text = "$200";
         this.lblBaseCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblBaseCost.Click += new System.EventHandler(this.lblBaseCost_Click);
         // 
         // lblFillTotal
         // 
         this.lblFillTotal.AutoSize = true;
         this.lblFillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFillTotal.Location = new System.Drawing.Point(367, 497);
         this.lblFillTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFillTotal.Name = "lblFillTotal";
         this.lblFillTotal.Size = new System.Drawing.Size(43, 47);
         this.lblFillTotal.TabIndex = 30;
         this.lblFillTotal.Text = "$";
         this.lblFillTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblTotal
         // 
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.Location = new System.Drawing.Point(16, 497);
         this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(122, 60);
         this.lblTotal.TabIndex = 29;
         this.lblTotal.Text = "Total";
         this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblSizeCost
         // 
         this.lblSizeCost.AutoSize = true;
         this.lblSizeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSizeCost.Location = new System.Drawing.Point(13, 354);
         this.lblSizeCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblSizeCost.Name = "lblSizeCost";
         this.lblSizeCost.Size = new System.Drawing.Size(197, 47);
         this.lblSizeCost.TabIndex = 31;
         this.lblSizeCost.Text = "Size Cost";
         this.lblSizeCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblFillSizeCost
         // 
         this.lblFillSizeCost.AutoSize = true;
         this.lblFillSizeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFillSizeCost.Location = new System.Drawing.Point(367, 352);
         this.lblFillSizeCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFillSizeCost.Name = "lblFillSizeCost";
         this.lblFillSizeCost.Size = new System.Drawing.Size(43, 47);
         this.lblFillSizeCost.TabIndex = 32;
         this.lblFillSizeCost.Text = "$";
         this.lblFillSizeCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblFillSizeCost.Click += new System.EventHandler(this.lblFillSizeCost_Click);
         // 
         // DisplayQuote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(798, 720);
         this.Controls.Add(this.lblFillSizeCost);
         this.Controls.Add(this.lblSizeCost);
         this.Controls.Add(this.lblFillTotal);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.lblBaseCost);
         this.Controls.Add(this.lblFillDrawerCost);
         this.Controls.Add(this.lbl);
         this.Controls.Add(this.lblFillMaterialCost);
         this.Controls.Add(this.lblMaterialCost);
         this.Controls.Add(this.lblFillShipping);
         this.Controls.Add(this.lblShipping);
         this.Controls.Add(this.lblFillDelivery);
         this.Controls.Add(this.lblDelivery);
         this.Controls.Add(this.bttnCloseDisplayQuotes);
         this.Controls.Add(this.lblDisplayQuotes);
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "DisplayQuote";
         this.Text = "DisplayQuote";
         this.Load += new System.EventHandler(this.DisplayQuote_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblDisplayQuotes;
      private System.Windows.Forms.Button bttnCloseDisplayQuotes;
      private System.Windows.Forms.Label lblDelivery;
      private System.Windows.Forms.Label lblFillDelivery;
      private System.Windows.Forms.Label lblFillShipping;
      private System.Windows.Forms.Label lblShipping;
      private System.Windows.Forms.Label lblFillMaterialCost;
      private System.Windows.Forms.Label lblMaterialCost;
      private System.Windows.Forms.Label lblFillDrawerCost;
      private System.Windows.Forms.Label lbl;
      private System.Windows.Forms.Label lblBaseCost;
      private System.Windows.Forms.Label lblFillTotal;
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.Label lblSizeCost;
      private System.Windows.Forms.Label lblFillSizeCost;
   }
}