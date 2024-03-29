
namespace Gosub
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Status = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.CurrentTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_accepted = new System.Windows.Forms.RadioButton();
            this.order_new = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Auto_Save_Data = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.waiter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.order_expired = new System.Windows.Forms.RadioButton();
            this.order_nofilter = new System.Windows.Forms.RadioButton();
            this.orders_recent = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label6 = new System.Windows.Forms.Label();
            this.Restaurants = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accepter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promisedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seenAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(157, 112);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(23, 18);
            this.Status.TabIndex = 3;
            this.Status.Text = "...";
            // 
            // FromDate
            // 
            this.FromDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FromDate.CustomFormat = "yyyy-MM-dd";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(18, 38);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(158, 26);
            this.FromDate.TabIndex = 10;
            // 
            // CurrentTime
            // 
            this.CurrentTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentTime.CustomFormat = "hh:mm:ss";
            this.CurrentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CurrentTime.Location = new System.Drawing.Point(406, 38);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(158, 26);
            this.CurrentTime.TabIndex = 11;
            this.CurrentTime.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "To Date";
            // 
            // ToDate
            // 
            this.ToDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToDate.CustomFormat = "yyyy-MM-dd";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(212, 38);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(158, 26);
            this.ToDate.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shortCode,
            this.vendorName,
            this.address,
            this.customer,
            this.comment,
            this.itemsname,
            this.itemsamount,
            this.itemsprice,
            this.feesname,
            this.feesvalue,
            this.Total,
            this.paymentMethod,
            this.acceptedAt,
            this.accepter,
            this.deliverAt,
            this.expiresAt,
            this.promisedTime,
            this.seenAt,
            this.timestamp,
            this.state,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 412);
            this.dataGridView1.TabIndex = 16;
            // 
            // order_accepted
            // 
            this.order_accepted.AutoSize = true;
            this.order_accepted.Checked = true;
            this.order_accepted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_accepted.Location = new System.Drawing.Point(401, 4);
            this.order_accepted.Name = "order_accepted";
            this.order_accepted.Size = new System.Drawing.Size(104, 22);
            this.order_accepted.TabIndex = 17;
            this.order_accepted.TabStop = true;
            this.order_accepted.Text = "ACCEPTED";
            this.order_accepted.UseVisualStyleBackColor = true;
            // 
            // order_new
            // 
            this.order_new.AutoSize = true;
            this.order_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_new.Location = new System.Drawing.Point(516, 4);
            this.order_new.Name = "order_new";
            this.order_new.Size = new System.Drawing.Size(62, 22);
            this.order_new.TabIndex = 18;
            this.order_new.Text = "NEW";
            this.order_new.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time";
            this.label3.Visible = false;
            // 
            // Auto_Save_Data
            // 
            this.Auto_Save_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Auto_Save_Data.AutoSize = true;
            this.Auto_Save_Data.Checked = true;
            this.Auto_Save_Data.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Auto_Save_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Auto_Save_Data.Location = new System.Drawing.Point(446, 111);
            this.Auto_Save_Data.Name = "Auto_Save_Data";
            this.Auto_Save_Data.Size = new System.Drawing.Size(254, 22);
            this.Auto_Save_Data.TabIndex = 20;
            this.Auto_Save_Data.Text = "Auto Save Orders To Database";
            this.Auto_Save_Data.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Location = new System.Drawing.Point(643, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 22);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Check Orders Every";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // waiter
            // 
            this.waiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.waiter.Enabled = false;
            this.waiter.Location = new System.Drawing.Point(643, 45);
            this.waiter.MaxLength = 5;
            this.waiter.Name = "waiter";
            this.waiter.Size = new System.Drawing.Size(100, 26);
            this.waiter.TabIndex = 23;
            this.waiter.Text = "2";
            this.waiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waiter_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(749, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Minutes";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // order_expired
            // 
            this.order_expired.AutoSize = true;
            this.order_expired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_expired.Location = new System.Drawing.Point(297, 4);
            this.order_expired.Name = "order_expired";
            this.order_expired.Size = new System.Drawing.Size(93, 22);
            this.order_expired.TabIndex = 26;
            this.order_expired.Text = "EXPIRED";
            this.order_expired.UseVisualStyleBackColor = true;
            // 
            // order_nofilter
            // 
            this.order_nofilter.AutoSize = true;
            this.order_nofilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_nofilter.Location = new System.Drawing.Point(3, 4);
            this.order_nofilter.Name = "order_nofilter";
            this.order_nofilter.Size = new System.Drawing.Size(118, 22);
            this.order_nofilter.TabIndex = 27;
            this.order_nofilter.Text = "NO FILTERS";
            this.order_nofilter.UseVisualStyleBackColor = true;
            // 
            // orders_recent
            // 
            this.orders_recent.AutoSize = true;
            this.orders_recent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orders_recent.Location = new System.Drawing.Point(132, 4);
            this.orders_recent.Name = "orders_recent";
            this.orders_recent.Size = new System.Drawing.Size(154, 22);
            this.orders_recent.TabIndex = 28;
            this.orders_recent.Text = "RECENT ORDERS";
            this.orders_recent.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Response Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.order_nofilter);
            this.panel1.Controls.Add(this.order_accepted);
            this.panel1.Controls.Add(this.orders_recent);
            this.panel1.Controls.Add(this.order_new);
            this.panel1.Controls.Add(this.order_expired);
            this.panel1.Location = new System.Drawing.Point(18, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 31);
            this.panel1.TabIndex = 30;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "order (1).png");
            this.imageList1.Images.SetKeyName(1, "icons8-database-64.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 585);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Your Restaurant status";
            // 
            // Restaurants
            // 
            this.Restaurants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurants.AutoScroll = true;
            this.Restaurants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Restaurants.Location = new System.Drawing.Point(5, 28);
            this.Restaurants.Name = "Restaurants";
            this.Restaurants.Size = new System.Drawing.Size(283, 387);
            this.Restaurants.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(15, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 420);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Restaurants);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(745, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 418);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ImageKey = "icons8-database-64.png";
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(878, 84);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(176, 51);
            this.button5.TabIndex = 25;
            this.button5.Text = "Saved Orders";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(878, 25);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(176, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "Get Orders";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(706, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 51);
            this.button2.TabIndex = 36;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shortCode
            // 
            this.shortCode.HeaderText = "Order No";
            this.shortCode.Name = "shortCode";
            this.shortCode.ReadOnly = true;
            // 
            // vendorName
            // 
            this.vendorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendorName.HeaderText = "Vendor Name";
            this.vendorName.Name = "vendorName";
            this.vendorName.ReadOnly = true;
            this.vendorName.Width = 122;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.HeaderText = "Comment";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // itemsname
            // 
            this.itemsname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemsname.HeaderText = "Items Name";
            this.itemsname.Name = "itemsname";
            this.itemsname.ReadOnly = true;
            this.itemsname.Width = 113;
            // 
            // itemsamount
            // 
            this.itemsamount.HeaderText = "Items Amount";
            this.itemsamount.Name = "itemsamount";
            this.itemsamount.ReadOnly = true;
            // 
            // itemsprice
            // 
            this.itemsprice.HeaderText = "Items Price";
            this.itemsprice.Name = "itemsprice";
            this.itemsprice.ReadOnly = true;
            // 
            // feesname
            // 
            this.feesname.HeaderText = "Fees Name";
            this.feesname.Name = "feesname";
            this.feesname.ReadOnly = true;
            // 
            // feesvalue
            // 
            this.feesvalue.HeaderText = "Fees Value";
            this.feesvalue.Name = "feesvalue";
            this.feesvalue.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // paymentMethod
            // 
            this.paymentMethod.HeaderText = "Paid With";
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.ReadOnly = true;
            // 
            // acceptedAt
            // 
            this.acceptedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.acceptedAt.HeaderText = "Accepted At";
            this.acceptedAt.Name = "acceptedAt";
            this.acceptedAt.ReadOnly = true;
            this.acceptedAt.Width = 111;
            // 
            // accepter
            // 
            this.accepter.HeaderText = "Accepter";
            this.accepter.Name = "accepter";
            this.accepter.ReadOnly = true;
            // 
            // deliverAt
            // 
            this.deliverAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliverAt.HeaderText = "Deliver At";
            this.deliverAt.Name = "deliverAt";
            this.deliverAt.ReadOnly = true;
            this.deliverAt.Width = 99;
            // 
            // expiresAt
            // 
            this.expiresAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expiresAt.HeaderText = "Expires At";
            this.expiresAt.Name = "expiresAt";
            this.expiresAt.ReadOnly = true;
            // 
            // promisedTime
            // 
            this.promisedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.promisedTime.HeaderText = "Promised Time";
            this.promisedTime.Name = "promisedTime";
            this.promisedTime.ReadOnly = true;
            this.promisedTime.Width = 131;
            // 
            // seenAt
            // 
            this.seenAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.seenAt.HeaderText = "Seen At";
            this.seenAt.Name = "seenAt";
            this.seenAt.ReadOnly = true;
            this.seenAt.Width = 83;
            // 
            // timestamp
            // 
            this.timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timestamp.HeaderText = "Times Samp";
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 112;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 73;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.waiter);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Auto_Save_Data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Status);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(975, 567);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker CurrentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.RadioButton order_accepted;
        internal System.Windows.Forms.RadioButton order_new;
        internal System.Windows.Forms.CheckBox Auto_Save_Data;
        internal System.Windows.Forms.CheckBox checkBox2;
        internal System.Windows.Forms.TextBox waiter;
        internal System.Windows.Forms.RadioButton order_expired;
        internal System.Windows.Forms.RadioButton order_nofilter;
        internal System.Windows.Forms.RadioButton orders_recent;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel Restaurants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesname;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn accepter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn promisedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn seenAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

