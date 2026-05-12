namespace UI
{
    partial class btnAddSale
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
            id_product = new TextBox();
            label1 = new Label();
            txtMinAmount = new TextBox();
            label2 = new Label();
            txtMinPrice = new TextBox();
            label3 = new Label();
            chkForWho = new CheckBox();
            dtpStartSale = new DateTimePicker();
            dtpEndSale = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // id_product
            // 
            id_product.Location = new Point(554, 57);
            id_product.Name = "id_product";
            id_product.Size = new Size(191, 27);
            id_product.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "קוד מוצר";
            // 
            // txtMinAmount
            // 
            txtMinAmount.Location = new Point(553, 128);
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(191, 27);
            txtMinAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 100);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "כמות מינימלית";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(555, 198);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(188, 27);
            txtMinPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 170);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "מחיר מינימלי";
            // 
            // chkForWho
            // 
            chkForWho.AutoSize = true;
            chkForWho.Location = new Point(557, 265);
            chkForWho.Name = "chkForWho";
            chkForWho.Size = new Size(120, 24);
            chkForWho.TabIndex = 6;
            chkForWho.Text = "מועדון לקוחות";
            chkForWho.UseVisualStyleBackColor = true;
            // 
            // dtpStartSale
            // 
            dtpStartSale.Location = new Point(554, 322);
            dtpStartSale.Name = "dtpStartSale";
            dtpStartSale.Size = new Size(162, 27);
            dtpStartSale.TabIndex = 7;
            // 
            // dtpEndSale
            // 
            dtpEndSale.Location = new Point(553, 378);
            dtpEndSale.Name = "dtpEndSale";
            dtpEndSale.Size = new Size(165, 27);
            dtpEndSale.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(360, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "שמור";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(dtpEndSale);
            Controls.Add(dtpStartSale);
            Controls.Add(chkForWho);
            Controls.Add(label3);
            Controls.Add(txtMinPrice);
            Controls.Add(label2);
            Controls.Add(txtMinAmount);
            Controls.Add(label1);
            Controls.Add(id_product);
            Name = "btnAddSale";
            Text = "btnAddSale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id_product;
        private Label label1;
        private TextBox txtMinAmount;
        private Label label2;
        private TextBox txtMinPrice;
        private Label label3;
        private CheckBox chkForWho;
        private DateTimePicker dtpStartSale;
        private DateTimePicker dtpEndSale;
        private Button btnSave;
    }
}