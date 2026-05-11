namespace UI
{
    partial class Cashier
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
            View_the_catalog = new Button();
            Make_a_purchase_for_customer_ = new Button();
            Updating_existing_customer_details = new Button();
            SuspendLayout();
            // 
            // View_the_catalog
            // 
            View_the_catalog.Location = new Point(567, 114);
            View_the_catalog.Name = "View_the_catalog";
            View_the_catalog.Size = new Size(170, 63);
            View_the_catalog.TabIndex = 0;
            View_the_catalog.Text = "צפיה_בקטלוג";
            View_the_catalog.UseVisualStyleBackColor = true;
            View_the_catalog.Click += View_the_catalog_Click;
            // 
            // Make_a_purchase_for_customer_
            // 
            Make_a_purchase_for_customer_.Location = new Point(551, 214);
            Make_a_purchase_for_customer_.Name = "Make_a_purchase_for_customer_";
            Make_a_purchase_for_customer_.Size = new Size(186, 61);
            Make_a_purchase_for_customer_.TabIndex = 1;
            Make_a_purchase_for_customer_.Text = "ביצוע_הזמנה_עבור_לקוח";
            Make_a_purchase_for_customer_.UseVisualStyleBackColor = true;
            Make_a_purchase_for_customer_.Click += Make_a_purchase_for_customer__Click;
            // 
            // Updating_existing_customer_details
            // 
            Updating_existing_customer_details.Location = new Point(359, 214);
            Updating_existing_customer_details.Name = "Updating_existing_customer_details";
            Updating_existing_customer_details.Size = new Size(164, 61);
            Updating_existing_customer_details.TabIndex = 3;
            Updating_existing_customer_details.Text = "עדכון_פרטי_לקוח_קיים";
            Updating_existing_customer_details.UseVisualStyleBackColor = true;
            Updating_existing_customer_details.Click += Updating_existing_customer_details_Click;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Updating_existing_customer_details);
            Controls.Add(Make_a_purchase_for_customer_);
            Controls.Add(View_the_catalog);
            Name = "Cashier";
            Text = "Cashier";
            ResumeLayout(false);
        }

        #endregion

        private Button View_the_catalog;
        private Button Make_a_purchase_for_customer_;
        private Button Updating_existing_customer_details;
    }
}