namespace Gosub
{
    partial class Order_Viewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Order_No = new System.Windows.Forms.Label();
            this.V_Name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Decline_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Accept_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Order_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Collect_from_customer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Decline_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No";
            // 
            // Order_No
            // 
            this.Order_No.AutoSize = true;
            this.Order_No.Location = new System.Drawing.Point(95, 30);
            this.Order_No.Name = "Order_No";
            this.Order_No.Size = new System.Drawing.Size(23, 18);
            this.Order_No.TabIndex = 1;
            this.Order_No.Text = "...";
            // 
            // V_Name
            // 
            this.V_Name.AutoSize = true;
            this.V_Name.Location = new System.Drawing.Point(12, 69);
            this.V_Name.Name = "V_Name";
            this.V_Name.Size = new System.Drawing.Size(23, 18);
            this.V_Name.TabIndex = 2;
            this.V_Name.Text = "...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(881, 234);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Decline_Panel
            // 
            this.Decline_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Decline_Panel.Controls.Add(this.label3);
            this.Decline_Panel.Controls.Add(this.flowLayoutPanel1);
            this.Decline_Panel.Location = new System.Drawing.Point(858, 438);
            this.Decline_Panel.Name = "Decline_Panel";
            this.Decline_Panel.Size = new System.Drawing.Size(891, 295);
            this.Decline_Panel.TabIndex = 6;
            this.Decline_Panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Accept_Button);
            this.panel2.Controls.Add(this.Accept_Buttons);
            this.panel2.Location = new System.Drawing.Point(15, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 239);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Accept";
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Button.BackColor = System.Drawing.Color.Green;
            this.Accept_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept_Button.Location = new System.Drawing.Point(3, 180);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(250, 53);
            this.Accept_Button.TabIndex = 6;
            this.Accept_Button.Tag = "15";
            this.Accept_Button.Text = "Select cooking time to 15 min";
            this.Accept_Button.UseVisualStyleBackColor = false;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Accept_Buttons
            // 
            this.Accept_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Buttons.AutoSize = true;
            this.Accept_Buttons.Location = new System.Drawing.Point(3, 31);
            this.Accept_Buttons.MaximumSize = new System.Drawing.Size(0, 143);
            this.Accept_Buttons.MinimumSize = new System.Drawing.Size(250, 143);
            this.Accept_Buttons.Name = "Accept_Buttons";
            this.Accept_Buttons.Size = new System.Drawing.Size(250, 143);
            this.Accept_Buttons.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.IndianRed;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(753, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 39);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Decline";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Order_Items
            // 
            this.Order_Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Order_Items.Location = new System.Drawing.Point(290, 99);
            this.Order_Items.Name = "Order_Items";
            this.Order_Items.Size = new System.Drawing.Size(589, 308);
            this.Order_Items.TabIndex = 9;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(734, 425);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(23, 18);
            this.Total.TabIndex = 11;
            this.Total.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // Collect_from_customer
            // 
            this.Collect_from_customer.AutoSize = true;
            this.Collect_from_customer.ForeColor = System.Drawing.Color.Red;
            this.Collect_from_customer.Location = new System.Drawing.Point(734, 455);
            this.Collect_from_customer.Name = "Collect_from_customer";
            this.Collect_from_customer.Size = new System.Drawing.Size(23, 18);
            this.Collect_from_customer.TabIndex = 13;
            this.Collect_from_customer.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Collect from customer";
            // 
            // Order_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 509);
            this.Controls.Add(this.Collect_from_customer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Order_Items);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Decline_Panel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.V_Name);
            this.Controls.Add(this.Order_No);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Order_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Viewer";
            this.Load += new System.EventHandler(this.Order_Viewer_Load);
            this.Decline_Panel.ResumeLayout(false);
            this.Decline_Panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Order_No;
        internal System.Windows.Forms.Label V_Name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Decline_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.FlowLayoutPanel Accept_Buttons;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.FlowLayoutPanel Order_Items;
        internal System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label Collect_from_customer;
        private System.Windows.Forms.Label label7;
    }
}