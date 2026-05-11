namespace UI
{
    partial class Adding_a_new_product
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID = new TextBox();
            Price = new TextBox();
            nameTextBox = new TextBox();
            Amount = new TextBox();
            label6 = new Label();
            categoryComboBox = new ComboBox();
            finish = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 101);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 243);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 192);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 143);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 295);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // ID
            // 
            ID.Location = new Point(425, 94);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 5;
            // 
            // Price
            // 
            Price.Location = new Point(425, 236);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 6;
            // 
            // Name
            // 
            nameTextBox.Location = new Point(425, 136);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 7;
            // 
            // Amount
            // 
            Amount.Location = new Point(425, 288);
            Amount.Name = "Amount";
            Amount.Size = new Size(125, 27);
            Amount.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 32);
            label6.Name = "label6";
            label6.Size = new Size(166, 20);
            label6.TabIndex = 10;
            label6.Text = "טופס להוספת מוצר חדש";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(425, 189);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(125, 28);
            categoryComboBox.TabIndex = 11;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // finish
            // 
            finish.Location = new Point(393, 351);
            finish.Name = "finish";
            finish.Size = new Size(94, 29);
            finish.TabIndex = 12;
            finish.Text = "אישור";
            finish.UseVisualStyleBackColor = true;
            finish.Click += finish_Click;
            // 
            // Adding_a_new_product
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
            Name = "Adding_a_new_product";
            Text = "Adding_a_new_product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID;
        private TextBox Price;
        private TextBox nameTextBox;
        private TextBox Amount;
        private Label label6;
        private ComboBox categoryComboBox;
        private Button finish;
    }
}