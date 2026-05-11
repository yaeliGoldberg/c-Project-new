namespace UI
{
    partial class Manager
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
            Product_Management = new Button();
            Product_Order_Management = new Button();
            Promotion_Management = new Button();
            SuspendLayout();
            // 
            // Product_Management
            // 
            Product_Management.Location = new Point(288, 95);
            Product_Management.Name = "Product_Management";
            Product_Management.Size = new Size(100, 50);
            Product_Management.TabIndex = 0;
            Product_Management.Text = "ניהול מוצרים";
            Product_Management.UseVisualStyleBackColor = true;
            Product_Management.Click += Product_Management_Click;
            // 
            // Product_Order_Management
            // 
            Product_Order_Management.Location = new Point(288, 151);
            Product_Order_Management.Name = "Product_Order_Management";
            Product_Order_Management.Size = new Size(100, 50);
            Product_Order_Management.TabIndex = 1;
            Product_Order_Management.Text = "ניהול הזמנת מוצרים";
            Product_Order_Management.UseVisualStyleBackColor = true;
            Product_Order_Management.Click += Product_Order_Management_Click;
            // 
            // Promotion_Management
            // 
            Promotion_Management.Location = new Point(288, 207);
            Promotion_Management.Name = "Promotion_Management";
            Promotion_Management.Size = new Size(100, 50);
            Promotion_Management.TabIndex = 2;
            Promotion_Management.Text = "ניהול מבצעים";
            Promotion_Management.UseVisualStyleBackColor = true;
            Promotion_Management.Click += Promotion_Management_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Promotion_Management);
            Controls.Add(Product_Order_Management);
            Controls.Add(Product_Management);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button Product_Management;
        private Button Product_Order_Management;
        private Button Promotion_Management;
    }
}