namespace Gosub.Controls
{
    partial class Order_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.O_Title = new System.Windows.Forms.Label();
            this.O_Amount = new System.Windows.Forms.Label();
            this.O_Price = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.O_category = new System.Windows.Forms.Label();
            this.O_modifiers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // O_Title
            // 
            this.O_Title.AutoSize = true;
            this.O_Title.Location = new System.Drawing.Point(19, 11);
            this.O_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O_Title.Name = "O_Title";
            this.O_Title.Size = new System.Drawing.Size(55, 18);
            this.O_Title.TabIndex = 0;
            this.O_Title.Text = "label1";
            // 
            // O_Amount
            // 
            this.O_Amount.AutoSize = true;
            this.O_Amount.Location = new System.Drawing.Point(363, 24);
            this.O_Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O_Amount.Name = "O_Amount";
            this.O_Amount.Size = new System.Drawing.Size(55, 18);
            this.O_Amount.TabIndex = 1;
            this.O_Amount.Text = "label2";
            // 
            // O_Price
            // 
            this.O_Price.AutoSize = true;
            this.O_Price.Location = new System.Drawing.Point(482, 24);
            this.O_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O_Price.Name = "O_Price";
            this.O_Price.Size = new System.Drawing.Size(55, 18);
            this.O_Price.TabIndex = 2;
            this.O_Price.Text = "label4";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment.ForeColor = System.Drawing.Color.Red;
            this.comment.Location = new System.Drawing.Point(19, 60);
            this.comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(42, 16);
            this.comment.TabIndex = 3;
            this.comment.Text = "label2";
            // 
            // O_category
            // 
            this.O_category.AutoSize = true;
            this.O_category.Location = new System.Drawing.Point(19, 36);
            this.O_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O_category.Name = "O_category";
            this.O_category.Size = new System.Drawing.Size(55, 18);
            this.O_category.TabIndex = 4;
            this.O_category.Text = "label5";
            // 
            // O_modifiers
            // 
            this.O_modifiers.AutoSize = true;
            this.O_modifiers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.O_modifiers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.O_modifiers.Location = new System.Drawing.Point(19, 84);
            this.O_modifiers.Name = "O_modifiers";
            this.O_modifiers.Size = new System.Drawing.Size(0, 0);
            this.O_modifiers.TabIndex = 5;
            // 
            // Order_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.O_modifiers);
            this.Controls.Add(this.O_category);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.O_Price);
            this.Controls.Add(this.O_Amount);
            this.Controls.Add(this.O_Title);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Order_Item";
            this.Size = new System.Drawing.Size(541, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.FlowLayoutPanel O_modifiers;
        internal System.Windows.Forms.Label O_Title;
        internal System.Windows.Forms.Label O_Amount;
        internal System.Windows.Forms.Label O_Price;
        internal System.Windows.Forms.Label comment;
        internal System.Windows.Forms.Label O_category;
    }
}
