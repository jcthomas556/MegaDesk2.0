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
         this.bttnFilter = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.comboBoxFilterOptions = new System.Windows.Forms.ComboBox();
         this.lblFilterBy = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // bttnCloseSearchQuotes
         // 
         this.bttnCloseSearchQuotes.Location = new System.Drawing.Point(866, 608);
         this.bttnCloseSearchQuotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.bttnCloseSearchQuotes.Name = "bttnCloseSearchQuotes";
         this.bttnCloseSearchQuotes.Size = new System.Drawing.Size(249, 54);
         this.bttnCloseSearchQuotes.TabIndex = 20;
         this.bttnCloseSearchQuotes.Text = "Cancel";
         this.bttnCloseSearchQuotes.UseVisualStyleBackColor = true;
         this.bttnCloseSearchQuotes.Click += new System.EventHandler(this.bttnCloseSearchQuotes_Click);
         // 
         // lblSearchQuotes
         // 
         this.lblSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSearchQuotes.Location = new System.Drawing.Point(381, 43);
         this.lblSearchQuotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblSearchQuotes.Name = "lblSearchQuotes";
         this.lblSearchQuotes.Size = new System.Drawing.Size(441, 60);
         this.lblSearchQuotes.TabIndex = 19;
         this.lblSearchQuotes.Text = "Search Quotes";
         this.lblSearchQuotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // bttnFilter
         // 
         this.bttnFilter.AutoSize = true;
         this.bttnFilter.Location = new System.Drawing.Point(782, 90);
         this.bttnFilter.Name = "bttnFilter";
         this.bttnFilter.Size = new System.Drawing.Size(156, 43);
         this.bttnFilter.TabIndex = 21;
         this.bttnFilter.Text = "Filter";
         this.bttnFilter.UseVisualStyleBackColor = true;
         this.bttnFilter.Click += new System.EventHandler(this.bttnFilter_Click);
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(21, 178);
         this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 24;
         this.dataGridView1.Size = new System.Drawing.Size(1141, 400);
         this.dataGridView1.TabIndex = 22;
         // 
         // comboBoxFilterOptions
         // 
         this.comboBoxFilterOptions.FormattingEnabled = true;
         this.comboBoxFilterOptions.Location = new System.Drawing.Point(520, 105);
         this.comboBoxFilterOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.comboBoxFilterOptions.Name = "comboBoxFilterOptions";
         this.comboBoxFilterOptions.Size = new System.Drawing.Size(180, 28);
         this.comboBoxFilterOptions.TabIndex = 23;
         
         // 
         // lblFilterBy
         // 
         this.lblFilterBy.AutoSize = true;
         this.lblFilterBy.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFilterBy.Location = new System.Drawing.Point(414, 105);
         this.lblFilterBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblFilterBy.Name = "lblFilterBy";
         this.lblFilterBy.Size = new System.Drawing.Size(98, 26);
         this.lblFilterBy.TabIndex = 24;
         this.lblFilterBy.Text = "Filter By:";
         // 
         // SearchQuotes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 692);
         this.Controls.Add(this.lblFilterBy);
         this.Controls.Add(this.comboBoxFilterOptions);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.bttnFilter);
         this.Controls.Add(this.bttnCloseSearchQuotes);
         this.Controls.Add(this.lblSearchQuotes);
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "SearchQuotes";
         this.Text = "SearchQuotes";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button bttnCloseSearchQuotes;
      private System.Windows.Forms.Label lblSearchQuotes;
      private System.Windows.Forms.Button bttnFilter;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.ComboBox comboBoxFilterOptions;
      private System.Windows.Forms.Label lblFilterBy;
   }
}