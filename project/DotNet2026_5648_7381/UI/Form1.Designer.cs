namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Manager = new Button();
            Salesperson = new Button();
            SuspendLayout();
            // 
            // Manager
            // 
            Manager.Location = new Point(353, 117);
            Manager.Name = "Manager";
            Manager.Size = new Size(94, 29);
            Manager.TabIndex = 0;
            Manager.Text = "Manager";
            Manager.UseVisualStyleBackColor = true;
            Manager.Click += button1_Click;
            // 
            // Salesperson
            // 
            Salesperson.Location = new Point(353, 181);
            Salesperson.Name = "Salesperson";
            Salesperson.Size = new Size(94, 29);
            Salesperson.TabIndex = 1;
            Salesperson.Text = "Salesperson";
            Salesperson.UseVisualStyleBackColor = true;
            Salesperson.Click += Salesperson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salesperson);
            Controls.Add(Manager);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Manager;
        private Button Salesperson;
    }
}
