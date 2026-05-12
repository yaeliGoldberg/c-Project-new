namespace UI
{
    partial class Promotion_Management
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
            btnLoadSales = new Button();
            dgvSales = new DataGridView();
            btnAddSale = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // btnLoadSales
            // 
            btnLoadSales.Location = new Point(574, 69);
            btnLoadSales.Name = "btnLoadSales";
            btnLoadSales.Size = new Size(180, 59);
            btnLoadSales.TabIndex = 0;
            btnLoadSales.Text = "טען מבצעים";
            btnLoadSales.UseVisualStyleBackColor = true;
            btnLoadSales.Click += btnLoadSales_Click;
            // 
            // dgvSales
            // 
            dgvSales.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(27, 69);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(301, 303);
            dgvSales.TabIndex = 1;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(581, 148);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(172, 53);
            btnAddSale.TabIndex = 2;
            btnAddSale.Text = "הוסף מבצע";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // Promotion_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddSale);
            Controls.Add(dgvSales);
            Controls.Add(btnLoadSales);
            Name = "Promotion_Management";
            Text = "Promotion_Management";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadSales;
        private DataGridView dgvSales;
        private Button btnAddSale;
    }
}