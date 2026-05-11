namespace UI
{
    partial class Product_Management
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
            Product_List = new Button();
            Add_a_product = new Button();
            Update_product = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Product_List
            // 
            Product_List.Location = new Point(650, 33);
            Product_List.Name = "Product_List";
            Product_List.Size = new Size(100, 50);
            Product_List.TabIndex = 0;
            Product_List.Text = "רשימת המוצרים";
            Product_List.UseVisualStyleBackColor = true;
            Product_List.Click += Product_List_Click;
            // 
            // Add_a_product
            // 
            Add_a_product.Location = new Point(650, 91);
            Add_a_product.Name = "Add_a_product";
            Add_a_product.Size = new Size(100, 50);
            Add_a_product.TabIndex = 1;
            Add_a_product.Text = "הוספת מוצר חדש";
            Add_a_product.UseVisualStyleBackColor = true;
            Add_a_product.Click += Add_a_product_Click;
            // 
            // Update_product
            // 
            Update_product.Location = new Point(650, 147);
            Update_product.Name = "Update_product";
            Update_product.Size = new Size(100, 50);
            Update_product.TabIndex = 2;
            Update_product.Text = "לעדכן מוצר חדש";
            Update_product.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 164);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(Update_product);
            Controls.Add(Add_a_product);
            Controls.Add(Product_List);
            Name = "Product_Management";
            Text = "Product_Management";
            ResumeLayout(false);
        }

        #endregion

        private Button Product_List;
        private Button Add_a_product;
        private Button Update_product;
        private ListBox listBox1;
    }
}