namespace UI
{
    partial class Updating_existing_customer
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
            Id = new TextBox();
            label1 = new Label();
            Nametxt = new TextBox();
            label2 = new Label();
            Address = new TextBox();
            label3 = new Label();
            Phone = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // Id
            // 
            Id.Location = new Point(541, 65);
            Id.Name = "Id";
            Id.Size = new Size(207, 27);
            Id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 30);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // Name
            // 
            Nametxt.Location = new Point(542, 147);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(208, 27);
            Nametxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(545, 119);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // Address
            // 
            Address.Location = new Point(541, 230);
            Address.Name = "Address";
            Address.Size = new Size(212, 27);
            Address.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 198);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // Phone
            // 
            Phone.Location = new Point(542, 311);
            Phone.Name = "Phone";
            Phone.Size = new Size(211, 27);
            Phone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 275);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(536, 372);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(250, 38);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Customer";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Updating_existing_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(Phone);
            Controls.Add(label3);
            Controls.Add(Address);
            Controls.Add(label2);
            Controls.Add(Nametxt);
            Controls.Add(label1);
            Controls.Add(Id);
            Name = "Updating_existing_customer";
            Text = "Updating_existing_customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Id;
        private Label label1;
        private TextBox Nametxt;
        private Label label2;
        private TextBox Address;
        private Label label3;
        private TextBox Phone;
        private Label label4;
        private Button btnUpdate;
    }
}