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
            this.deliverType = new System.Windows.Forms.Label();
            this.orderShortCode = new System.Windows.Forms.Label();
            this.orderStatus = new System.Windows.Forms.Label();
            this.orderShortInfo = new System.Windows.Forms.Label();
            this.menu_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalMenuCount = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.menuinfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.deliverinfoPage);
            this.tabControl1.Controls.Add(this.menuinfoPage);
            this.tabControl1.Controls.Add(this.reqinfoPage);
            this.tabControl1.Controls.Add(this.orderinfoPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // deliverinfoPage
            // 
            this.deliverinfoPage.Location = new System.Drawing.Point(4, 22);
            this.deliverinfoPage.Name = "deliverinfoPage";
            this.deliverinfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.deliverinfoPage.Size = new System.Drawing.Size(549, 324);
            this.deliverinfoPage.TabIndex = 0;
            this.deliverinfoPage.Text = "배달정보";
            this.deliverinfoPage.UseVisualStyleBackColor = true;
            // 
            // menuinfoPage
            // 
            this.menuinfoPage.Controls.Add(this.totalPrice);
            this.menuinfoPage.Controls.Add(this.totalMenuCount);
            this.menuinfoPage.Controls.Add(this.label1);
            this.menuinfoPage.Controls.Add(this.menu_Items);
            this.menuinfoPage.Location = new System.Drawing.Point(4, 22);
            this.menuinfoPage.Name = "menuinfoPage";
            this.menuinfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuinfoPage.Size = new System.Drawing.Size(549, 324);
            this.menuinfoPage.TabIndex = 1;
            this.menuinfoPage.Text = "메뉴정보";
            this.menuinfoPage.UseVisualStyleBackColor = true;
            // 
            // reqinfoPage
            // 
            this.reqinfoPage.Location = new System.Drawing.Point(4, 22);
            this.reqinfoPage.Name = "reqinfoPage";
            this.reqinfoPage.Size = new System.Drawing.Size(549, 324);
            this.reqinfoPage.TabIndex = 2;
            this.reqinfoPage.Text = "요청사항";
            this.reqinfoPage.UseVisualStyleBackColor = true;
            // 
            // orderinfoPage
            // 
            this.orderinfoPage.Location = new System.Drawing.Point(4, 22);
            this.orderinfoPage.Name = "orderinfoPage";
            this.orderinfoPage.Size = new System.Drawing.Size(549, 324);
            this.orderinfoPage.TabIndex = 3;
            this.orderinfoPage.Text = "주문정보";
            this.orderinfoPage.UseVisualStyleBackColor = true;
            // 
            // deliverType
            // 
            this.deliverType.AutoSize = true;
            this.deliverType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverType.Location = new System.Drawing.Point(12, 9);
            this.deliverType.Name = "deliverType";
            this.deliverType.Size = new System.Drawing.Size(68, 23);
            this.deliverType.TabIndex = 1;
            this.deliverType.Text = "label1";
            // 
            // orderShortCode
            // 
            this.orderShortCode.AutoSize = true;
            this.orderShortCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderShortCode.Location = new System.Drawing.Point(78, 9);
            this.orderShortCode.Name = "orderShortCode";
            this.orderShortCode.Size = new System.Drawing.Size(59, 23);
            this.orderShortCode.TabIndex = 2;
            this.orderShortCode.Text = "label1";
            // 
            // orderStatus
            // 
            this.orderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderStatus.AutoSize = true;
            this.orderStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatus.Location = new System.Drawing.Point(486, 9);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(59, 23);
            this.orderStatus.TabIndex = 3;
            this.orderStatus.Text = "label1";
            this.orderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderShortInfo
            // 
            this.orderShortInfo.AutoSize = true;
            this.orderShortInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderShortInfo.Location = new System.Drawing.Point(12, 33);
            this.orderShortInfo.Name = "orderShortInfo";
            this.orderShortInfo.Size = new System.Drawing.Size(51, 19);
            this.orderShortInfo.TabIndex = 4;
            this.orderShortInfo.Text = "label1";
            // 
            // menu_Items
            // 
            this.menu_Items.AutoScroll = true;
            this.menu_Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_Items.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Items.Location = new System.Drawing.Point(6, 39);
            this.menu_Items.Name = "menu_Items";
            this.menu_Items.Size = new System.Drawing.Size(537, 250);
            this.menu_Items.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "총수량";
            // 
            // totalMenuCount
            // 
            this.totalMenuCount.AutoSize = true;
            this.totalMenuCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMenuCount.Location = new System.Drawing.Point(62, 8);
            this.totalMenuCount.Name = "totalMenuCount";
            this.totalMenuCount.Size = new System.Drawing.Size(59, 23);
            this.totalMenuCount.TabIndex = 2;
            this.totalMenuCount.Text = "label2";
            // 
            // totalPrice
            // 
            this.totalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(441, 294);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(68, 23);
            this.totalPrice.TabIndex = 3;
            this.totalPrice.Text = "label2";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Order_Detail_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 418);
            this.Controls.Add(this.orderShortInfo);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.orderShortCode);
            this.Controls.Add(this.deliverType);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Order_Detail_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order_Detail_frm";
            this.tabControl1.ResumeLayout(false);
            this.menuinfoPage.ResumeLayout(false);
            this.menuinfoPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TabPage deliverinfoPage;
        internal System.Windows.Forms.TabPage menuinfoPage;
        internal System.Windows.Forms.TabPage reqinfoPage;
        internal System.Windows.Forms.TabPage orderinfoPage;
        internal System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.Label deliverType;
        internal System.Windows.Forms.Label orderShortCode;
        internal System.Windows.Forms.Label orderStatus;
        internal System.Windows.Forms.Label orderShortInfo;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label totalMenuCount;
        internal System.Windows.Forms.FlowLayoutPanel menu_Items;
        internal System.Windows.Forms.Label totalPrice;
    }
}