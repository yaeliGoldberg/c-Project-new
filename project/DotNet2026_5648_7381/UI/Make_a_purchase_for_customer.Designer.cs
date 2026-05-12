namespace UI
{
    partial class Make_a_purchase_for_customer
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
            ProductsTable = new DataGridView();
            txtAmount = new TextBox();
            label1 = new Label();
            btnAddProduct = new Button();
            btnJoinClub = new Button();
            btnRemoveClub = new Button();
            btnDoOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // ProductsTable
            // 
            ProductsTable.BackgroundColor = SystemColors.ButtonFace;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.GridColor = SystemColors.InactiveCaptionText;
            ProductsTable.Location = new Point(500, 56);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersWidth = 51;
            ProductsTable.Size = new Size(226, 310);
            ProductsTable.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(363, 63);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(118, 27);
            txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(360, 139);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(123, 30);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnJoinClub
            // 
            btnJoinClub.Location = new Point(356, 215);
            btnJoinClub.Name = "btnJoinClub";
            btnJoinClub.Size = new Size(122, 27);
            btnJoinClub.TabIndex = 4;
            btnJoinClub.Text = "Join Club";
            btnJoinClub.UseVisualStyleBackColor = true;
            btnJoinClub.Click += btnJoinClub_Click;
            // 
            // btnRemoveClub
            // 
            btnRemoveClub.Location = new Point(356, 269);
            btnRemoveClub.Name = "btnRemoveClub";
            btnRemoveClub.Size = new Size(121, 27);
            btnRemoveClub.TabIndex = 5;
            btnRemoveClub.Text = "Remove Club";
            btnRemoveClub.UseVisualStyleBackColor = true;
            btnRemoveClub.Click += btnRemoveClub_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.Location = new Point(503, 387);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(222, 32);
            btnDoOrder.TabIndex = 6;
            btnDoOrder.Text = "Do Order";
            btnDoOrder.UseVisualStyleBackColor = true;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // Make_a_purchase_for_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoOrder);
            Controls.Add(btnRemoveClub);
            Controls.Add(btnJoinClub);
            Controls.Add(btnAddProduct);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(ProductsTable);
            Name = "Make_a_purchase_for_customer";
            Text = "Make_a_purchase_for_customer";
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsTable;
        private TextBox txtAmount;
        private Label label1;
        private Button btnAddProduct;
        private Button btnJoinClub;
        private Button btnRemoveClub;
        private Button btnDoOrder;
    }
}