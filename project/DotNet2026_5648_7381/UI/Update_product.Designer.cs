namespace UI
{
    partial class Update_product
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
            finish = new Button();
            categoryComboBox = new ComboBox();
            label6 = new Label();
            Amount = new TextBox();
            nameTextBox = new TextBox();
            Price = new TextBox();
            ID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // finish
            // 
            finish.Location = new Point(350, 370);
            finish.Name = "finish";
            finish.Size = new Size(94, 29);
            finish.TabIndex = 24;
            finish.Text = "אישור";
            finish.UseVisualStyleBackColor = true;
            finish.Click += finish_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(382, 208);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(125, 28);
            categoryComboBox.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 51);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 22;
            label6.Text = "טופס לעידכון מוצר קיים";
            // 
            // Amount
            // 
            Amount.Location = new Point(382, 307);
            Amount.Name = "Amount";
            Amount.Size = new Size(125, 27);
            Amount.TabIndex = 21;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(382, 155);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 20;
            // 
            // Price
            // 
            Price.Location = new Point(382, 255);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 19;
            // 
            // ID
            // 
            ID.Location = new Point(382, 113);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 314);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 17;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 162);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 16;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 211);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 15;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 262);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 14;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 120);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 13;
            label1.Text = "Id";
            // 
            // Update_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(finish);
            Controls.Add(categoryComboBox);
            Controls.Add(label6);
            Controls.Add(Amount);
            Controls.Add(nameTextBox);
            Controls.Add(Price);
            Controls.Add(ID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update_product";
            Text = "Update_product";
            Load += Update_product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button finish;
        private ComboBox categoryComboBox;
        private Label label6;
        private TextBox Amount;
        private TextBox nameTextBox;
        private TextBox Price;
        private TextBox ID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}