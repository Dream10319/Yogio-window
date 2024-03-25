
namespace Gosub
{
    partial class Data_Viewer_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Viewer_frm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.Limited_Data = new System.Windows.Forms.RadioButton();
            this.All_Data = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 382);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(206, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "To Date";
            // 
            // ToDate
            // 
            this.ToDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToDate.CustomFormat = "yyyy-MM-dd";
            this.ToDate.Enabled = false;
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(209, 42);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(158, 26);
            this.ToDate.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "From Date";
            // 
            // FromDate
            // 
            this.FromDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FromDate.CustomFormat = "yyyy-MM-dd";
            this.FromDate.Enabled = false;
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(12, 42);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(158, 26);
            this.FromDate.TabIndex = 19;
            // 
            // Limited_Data
            // 
            this.Limited_Data.AutoSize = true;
            this.Limited_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limited_Data.Location = new System.Drawing.Point(383, 43);
            this.Limited_Data.Name = "Limited_Data";
            this.Limited_Data.Size = new System.Drawing.Size(144, 22);
            this.Limited_Data.TabIndex = 23;
            this.Limited_Data.Text = "Limited By Date";
            this.Limited_Data.UseVisualStyleBackColor = true;
            this.Limited_Data.CheckedChanged += new System.EventHandler(this.Limited_Data_CheckedChanged);
            // 
            // All_Data
            // 
            this.All_Data.AutoSize = true;
            this.All_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.All_Data.Location = new System.Drawing.Point(528, 42);
            this.All_Data.Name = "All_Data";
            this.All_Data.Size = new System.Drawing.Size(143, 22);
            this.All_Data.TabIndex = 24;
            this.All_Data.Text = "View All Orders";
            this.All_Data.UseVisualStyleBackColor = true;
            this.All_Data.CheckedChanged += new System.EventHandler(this.All_Data_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::Gosub.Properties.Resources.delete_button__1_;
            this.button1.Location = new System.Drawing.Point(692, 13);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(204, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete All Orders";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data_Viewer_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 468);
            this.Controls.Add(this.All_Data);
            this.Controls.Add(this.Limited_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(924, 507);
            this.Name = "Data_Viewer_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saved Orders";
            this.Load += new System.EventHandler(this.Data_Viewer_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker ToDate;
        internal System.Windows.Forms.DateTimePicker FromDate;
        internal System.Windows.Forms.RadioButton Limited_Data;
        internal System.Windows.Forms.RadioButton All_Data;
    }
}