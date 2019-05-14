namespace MegaDesk
{
   partial class AddQuote
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
         this.inputCustomerName = new System.Windows.Forms.TextBox();
         this.lblDeskSize = new System.Windows.Forms.Label();
         this.lblCustomerName = new System.Windows.Forms.Label();
         this.lblNewQuote = new System.Windows.Forms.Label();
         this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
         this.comboBoxSurfaceMaterial = new System.Windows.Forms.ComboBox();
         this.comboBoxDelivery = new System.Windows.Forms.ComboBox();
         this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
         this.numericUpDownNumOfDrawers = new System.Windows.Forms.NumericUpDown();
         this.lblWidth = new System.Windows.Forms.Label();
         this.lblDepth = new System.Windows.Forms.Label();
         this.lblSurfaceMaterial = new System.Windows.Forms.Label();
         this.lblDelivery = new System.Windows.Forms.Label();
         this.lblNumOfDrawers = new System.Windows.Forms.Label();
         this.bttnGetQuote = new System.Windows.Forms.Button();
         this.bttnCloseNewQuote = new System.Windows.Forms.Button();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfDrawers)).BeginInit();
         this.SuspendLayout();
         // 
         // inputCustomerName
         // 
         this.inputCustomerName.Location = new System.Drawing.Point(152, 111);
         this.inputCustomerName.Name = "inputCustomerName";
         this.inputCustomerName.Size = new System.Drawing.Size(365, 20);
         this.inputCustomerName.TabIndex = 0;
         this.inputCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // lblDeskSize
         // 
         this.lblDeskSize.Location = new System.Drawing.Point(61, 162);
         this.lblDeskSize.Name = "lblDeskSize";
         this.lblDeskSize.Size = new System.Drawing.Size(100, 23);
         this.lblDeskSize.TabIndex = 2;
         this.lblDeskSize.Text = "Desk Size";
         // 
         // lblCustomerName
         // 
         this.lblCustomerName.Location = new System.Drawing.Point(48, 104);
         this.lblCustomerName.Name = "lblCustomerName";
         this.lblCustomerName.Size = new System.Drawing.Size(85, 33);
         this.lblCustomerName.TabIndex = 3;
         this.lblCustomerName.Text = "Customer Name";
         this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblNewQuote
         // 
         this.lblNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNewQuote.Location = new System.Drawing.Point(327, 22);
         this.lblNewQuote.Name = "lblNewQuote";
         this.lblNewQuote.Size = new System.Drawing.Size(151, 37);
         this.lblNewQuote.TabIndex = 4;
         this.lblNewQuote.Text = "New Quote";
         this.lblNewQuote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // numericUpDownWidth
         // 
         this.numericUpDownWidth.Location = new System.Drawing.Point(178, 224);
         this.numericUpDownWidth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
         this.numericUpDownWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
         this.numericUpDownWidth.Name = "numericUpDownWidth";
         this.numericUpDownWidth.Size = new System.Drawing.Size(120, 20);
         this.numericUpDownWidth.TabIndex = 5;
         this.numericUpDownWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
         // 
         // comboBoxSurfaceMaterial
         // 
         this.comboBoxSurfaceMaterial.FormattingEnabled = true;
         this.comboBoxSurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Veneer",
            "Pine",
            "Rosewood"});
         this.comboBoxSurfaceMaterial.Location = new System.Drawing.Point(452, 223);
         this.comboBoxSurfaceMaterial.Name = "comboBoxSurfaceMaterial";
         this.comboBoxSurfaceMaterial.Size = new System.Drawing.Size(121, 21);
         this.comboBoxSurfaceMaterial.TabIndex = 6;
         // 
         // comboBoxDelivery
         // 
         this.comboBoxDelivery.FormattingEnabled = true;
         this.comboBoxDelivery.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day"});
         this.comboBoxDelivery.Location = new System.Drawing.Point(452, 258);
         this.comboBoxDelivery.Name = "comboBoxDelivery";
         this.comboBoxDelivery.Size = new System.Drawing.Size(121, 21);
         this.comboBoxDelivery.TabIndex = 7;
         // 
         // numericUpDownDepth
         // 
         this.numericUpDownDepth.Location = new System.Drawing.Point(178, 259);
         this.numericUpDownDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
         this.numericUpDownDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
         this.numericUpDownDepth.Name = "numericUpDownDepth";
         this.numericUpDownDepth.Size = new System.Drawing.Size(120, 20);
         this.numericUpDownDepth.TabIndex = 8;
         this.numericUpDownDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
         // 
         // numericUpDownNumOfDrawers
         // 
         this.numericUpDownNumOfDrawers.Location = new System.Drawing.Point(452, 187);
         this.numericUpDownNumOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
         this.numericUpDownNumOfDrawers.Name = "numericUpDownNumOfDrawers";
         this.numericUpDownNumOfDrawers.Size = new System.Drawing.Size(41, 20);
         this.numericUpDownNumOfDrawers.TabIndex = 9;
         // 
         // lblWidth
         // 
         this.lblWidth.Location = new System.Drawing.Point(61, 226);
         this.lblWidth.Name = "lblWidth";
         this.lblWidth.Size = new System.Drawing.Size(52, 18);
         this.lblWidth.TabIndex = 10;
         this.lblWidth.Text = "Width:";
         // 
         // lblDepth
         // 
         this.lblDepth.Location = new System.Drawing.Point(61, 258);
         this.lblDepth.Name = "lblDepth";
         this.lblDepth.Size = new System.Drawing.Size(62, 21);
         this.lblDepth.TabIndex = 11;
         this.lblDepth.Text = "Depth:";
         // 
         // lblSurfaceMaterial
         // 
         this.lblSurfaceMaterial.Location = new System.Drawing.Point(348, 223);
         this.lblSurfaceMaterial.Name = "lblSurfaceMaterial";
         this.lblSurfaceMaterial.Size = new System.Drawing.Size(103, 20);
         this.lblSurfaceMaterial.TabIndex = 12;
         this.lblSurfaceMaterial.Text = "Surface Material:";
         // 
         // lblDelivery
         // 
         this.lblDelivery.Location = new System.Drawing.Point(381, 258);
         this.lblDelivery.Name = "lblDelivery";
         this.lblDelivery.Size = new System.Drawing.Size(55, 20);
         this.lblDelivery.TabIndex = 13;
         this.lblDelivery.Text = "Delivery:";
         // 
         // lblNumOfDrawers
         // 
         this.lblNumOfDrawers.Location = new System.Drawing.Point(330, 187);
         this.lblNumOfDrawers.Name = "lblNumOfDrawers";
         this.lblNumOfDrawers.Size = new System.Drawing.Size(106, 20);
         this.lblNumOfDrawers.TabIndex = 14;
         this.lblNumOfDrawers.Text = "Number of Drawers:";
         // 
         // bttnGetQuote
         // 
         this.bttnGetQuote.Location = new System.Drawing.Point(152, 321);
         this.bttnGetQuote.Name = "bttnGetQuote";
         this.bttnGetQuote.Size = new System.Drawing.Size(166, 35);
         this.bttnGetQuote.TabIndex = 15;
         this.bttnGetQuote.Text = "Get Quote";
         this.bttnGetQuote.UseVisualStyleBackColor = true;
         // 
         // bttnCloseNewQuote
         // 
         this.bttnCloseNewQuote.Location = new System.Drawing.Point(351, 321);
         this.bttnCloseNewQuote.Name = "bttnCloseNewQuote";
         this.bttnCloseNewQuote.Size = new System.Drawing.Size(166, 35);
         this.bttnCloseNewQuote.TabIndex = 17;
         this.bttnCloseNewQuote.Text = "Cancel";
         this.bttnCloseNewQuote.UseVisualStyleBackColor = true;
         this.bttnCloseNewQuote.Click += new System.EventHandler(this.bttnCloseNewQuote_Click);
         // 
         // AddQuote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.bttnCloseNewQuote);
         this.Controls.Add(this.bttnGetQuote);
         this.Controls.Add(this.lblNumOfDrawers);
         this.Controls.Add(this.lblDelivery);
         this.Controls.Add(this.lblSurfaceMaterial);
         this.Controls.Add(this.lblDepth);
         this.Controls.Add(this.lblWidth);
         this.Controls.Add(this.numericUpDownNumOfDrawers);
         this.Controls.Add(this.numericUpDownDepth);
         this.Controls.Add(this.comboBoxDelivery);
         this.Controls.Add(this.comboBoxSurfaceMaterial);
         this.Controls.Add(this.numericUpDownWidth);
         this.Controls.Add(this.lblNewQuote);
         this.Controls.Add(this.lblCustomerName);
         this.Controls.Add(this.lblDeskSize);
         this.Controls.Add(this.inputCustomerName);
         this.Name = "AddQuote";
         this.Text = "AddQuote";
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfDrawers)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox inputCustomerName;
      private System.Windows.Forms.Label lblDeskSize;
      private System.Windows.Forms.Label lblCustomerName;
      private System.Windows.Forms.Label lblNewQuote;
      private System.Windows.Forms.NumericUpDown numericUpDownWidth;
      private System.Windows.Forms.ComboBox comboBoxSurfaceMaterial;
      private System.Windows.Forms.ComboBox comboBoxDelivery;
      private System.Windows.Forms.NumericUpDown numericUpDownDepth;
      private System.Windows.Forms.NumericUpDown numericUpDownNumOfDrawers;
      private System.Windows.Forms.Label lblWidth;
      private System.Windows.Forms.Label lblDepth;
      private System.Windows.Forms.Label lblSurfaceMaterial;
      private System.Windows.Forms.Label lblDelivery;
      private System.Windows.Forms.Label lblNumOfDrawers;
      private System.Windows.Forms.Button bttnGetQuote;
      private System.Windows.Forms.Button bttnCloseNewQuote;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
   }
}