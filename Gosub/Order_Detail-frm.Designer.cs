namespace Gosub
{
    partial class Order_Detail_frm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.deliverinfoPage = new System.Windows.Forms.TabPage();
            this.menuinfoPage = new System.Windows.Forms.TabPage();
            this.reqinfoPage = new System.Windows.Forms.TabPage();
            this.orderinfoPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.deliverinfoPage);
            this.tabControl1.Controls.Add(this.menuinfoPage);
            this.tabControl1.Controls.Add(this.reqinfoPage);
            this.tabControl1.Controls.Add(this.orderinfoPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // deliverinfoPage
            // 
            this.deliverinfoPage.Location = new System.Drawing.Point(4, 22);
            this.deliverinfoPage.Name = "deliverinfoPage";
            this.deliverinfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.deliverinfoPage.Size = new System.Drawing.Size(549, 368);
            this.deliverinfoPage.TabIndex = 0;
            this.deliverinfoPage.Text = "배달정보";
            this.deliverinfoPage.UseVisualStyleBackColor = true;
            // 
            // menuinfoPage
            // 
            this.menuinfoPage.Location = new System.Drawing.Point(4, 22);
            this.menuinfoPage.Name = "menuinfoPage";
            this.menuinfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuinfoPage.Size = new System.Drawing.Size(549, 368);
            this.menuinfoPage.TabIndex = 1;
            this.menuinfoPage.Text = "메뉴정보";
            this.menuinfoPage.UseVisualStyleBackColor = true;
            // 
            // reqinfoPage
            // 
            this.reqinfoPage.Location = new System.Drawing.Point(4, 22);
            this.reqinfoPage.Name = "reqinfoPage";
            this.reqinfoPage.Size = new System.Drawing.Size(549, 368);
            this.reqinfoPage.TabIndex = 2;
            this.reqinfoPage.Text = "요청사항";
            this.reqinfoPage.UseVisualStyleBackColor = true;
            // 
            // orderinfoPage
            // 
            this.orderinfoPage.Location = new System.Drawing.Point(4, 22);
            this.orderinfoPage.Name = "orderinfoPage";
            this.orderinfoPage.Size = new System.Drawing.Size(549, 368);
            this.orderinfoPage.TabIndex = 3;
            this.orderinfoPage.Text = "주문정보";
            this.orderinfoPage.UseVisualStyleBackColor = true;
            // 
            // Order_Detail_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Order_Detail_frm";
            this.Text = "Order_Detail_frm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TabPage deliverinfoPage;
        internal System.Windows.Forms.TabPage menuinfoPage;
        internal System.Windows.Forms.TabPage reqinfoPage;
        internal System.Windows.Forms.TabPage orderinfoPage;
        internal System.Windows.Forms.TabControl tabControl1;
    }
}