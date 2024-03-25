using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gosub
{
    public partial class Data_Viewer_frm : Form
    {
        public Data_Viewer_frm()
        {
            InitializeComponent();
        }

        private void Data_Viewer_frm_Load(object sender, EventArgs e)
        {
            //Load_Data("ORDER BY [shortCode] ASC;");
            FromDate.ValueChanged += FromDate_ValueChanged;
            ToDate.ValueChanged += FromDate_ValueChanged;
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            Load_Data($@"WHERE ([timestamp] BETWEEN '{FromDate.Value.ToString("dd/MM/yyyy")}%' AND '{ToDate.Value.ToString("dd/MM/yyyy")}%')
                       OR ([timestamp] <=  '{FromDate.Value.ToString("dd/MM/yyyy")}%' AND [timestamp] >=  '{ToDate.Value.ToString("dd/MM/yyyy")}%') 
                       ORDER BY  [timestamp] ASC;");
        }
        DataSet ds ;
        private void Load_Data(string filter = null)
        {
            dataGridView1.Columns.Clear();
            //SqlDataReader rd = new SqlCommand("Select * from Orders_Table", Program.db).ExecuteReader();

            //DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter($@" 
                SELECT [Order_ID] AS 'Order ID'
                ,[shortCode] AS 'Order No'
                ,[vendorName] AS 'Vendor Name'
                ,[street] AS 'Address'
                ,[phone] AS 'Customer'
                ,[comment] AS 'Comment'
                ,[name] AS 'Items name'
                ,[amount] AS 'Items Amount'
                ,[price] AS 'Items Price'
                ,[fees_name] AS 'Fees Name'
                ,[fees_value] AS 'Fees Value'
                ,[Total] AS 'Total'
                ,[paymentMethod] AS 'Paid With'
                ,[acceptedAt] AS 'Accepted At'
                ,[accepter] AS 'Accepter'
                ,[deliverAt] AS 'Deliver At'
                ,[expiresAt] AS 'Expires At'
                ,[promisedTime] AS 'Promised Time'
                ,[seenAt] AS 'Seen At'
                ,[timestamp] AS 'Times Samp'
                ,[state] AS 'State'
                FROM [Orders_Table] {filter}
                ", Program.db);
         
             ds = new DataSet();
         
            ad.Fill(ds);
            //dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            //foreach (DataGridViewColumn c in this.dataGridView1.Columns)
            //{
            //    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}

            //this.dataGridView1.DataSource = ds;
            //this.dataGridView1.Refresh();

          
        }
        private void Limited_Data_CheckedChanged(object sender, EventArgs e)
        {
            if(Limited_Data.Checked == true)
            {
                this.label1.Enabled = true;
                this.label2.Enabled = true;
                this.ToDate.Enabled = true;
                this.FromDate.Enabled = true;

                //Load_Data($@"WHERE [timestamp] LIKE '{FromDate.Value.ToString("dd/MM/yyyy")}%' or [timestamp] LIKE '{ToDate.Value.ToString("dd/MM/yyyy")}%' 
                //            ORDER BY  [timestamp] ASC;");


                Load_Data($@"WHERE ([timestamp] BETWEEN '{FromDate.Value.ToString("dd/MM/yyyy")}%' AND '{ToDate.Value.ToString("dd/MM/yyyy")}%')
                       OR ([timestamp] <=  '{FromDate.Value.ToString("dd/MM/yyyy")}%' AND [timestamp] >=  '{ToDate.Value.ToString("dd/MM/yyyy")}%') 
                       ORDER BY  [timestamp] ASC;");

                Properties.Settings.Default.Saved_Data_Viewer = "Limited_Data";
                Properties.Settings.Default.Save();
            }
        }

        private void All_Data_CheckedChanged(object sender, EventArgs e)
        {
            if (All_Data.Checked == true)
            {
                this.label1.Enabled = false;
                this.label2.Enabled = false;
                this.ToDate.Enabled = false;
                this.FromDate.Enabled = false;
                Load_Data("ORDER BY [shortCode] ASC;");

                Properties.Settings.Default.Saved_Data_Viewer = "All_Data";
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (Limited_Data.Checked == true && MessageBox.Show(this, "Delete All Orders That Selected By Date Range Only", "Empty the Database",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               string  cmd = $@"DELETE FROM [Orders_Table] WHERE ([timestamp] BETWEEN '{FromDate.Value.ToString("dd/MM/yyyy")}%' AND '{ToDate.Value.ToString("dd/MM/yyyy")}%')
                       OR ([timestamp] <=  '{FromDate.Value.ToString("dd/MM/yyyy")}%' AND [timestamp] >=  '{ToDate.Value.ToString("dd/MM/yyyy")}%')";

                SqlCommand sc = new SqlCommand(cmd, Program.db);
                sc.ExecuteNonQuery();

                ds.Clear();
            }

            if (All_Data.Checked == true && MessageBox.Show(this, "Are You Sure To Delete All Orders", "Empty the Database",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                SqlCommand sc = new SqlCommand(@"DELETE FROM [Orders_Table];
                                                DBCC CHECKIDENT ('[Orders_Table]', RESEED, 0);", Program.db);
                sc.ExecuteNonQuery();
                ds.Clear();
            }

        }
    }
}
