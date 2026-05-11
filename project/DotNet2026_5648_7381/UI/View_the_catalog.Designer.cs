namespace UI
{
    partial class View_the_catalog
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
            Product_table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Product_table).BeginInit();
            SuspendLayout();
            // 
            // Product_table
            // 
            Product_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Product_table.Location = new Point(362, 55);
            Product_table.Name = "Product_table";
            Product_table.RowHeadersWidth = 51;
            Product_table.Size = new Size(398, 356);
            Product_table.TabIndex = 0;
            Product_table.CellContentClick += Product_table_CellContentClick;
            // 
            // View_the_catalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Product_table);
            Name = "View_the_catalog";
            Text = "View_the_catalog";
            ((System.ComponentModel.ISupportInitialize)Product_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Product_table;
    }
}