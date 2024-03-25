using System;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gosub
{
    static class Program
    {
        //public static  SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
        //     Application.StartupPath + @"\Orders.mdf;Integrated Security=True;Connect Timeout=30");

        public static SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
       Application.StartupPath + @"\Orders.mdf;Integrated Security=True;Connect Timeout=30");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // https://web.rpsyogiyo.io/login
            Application.EnableVisualStyles();

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // To Enable HTTPS

            string db_error= null;
            try
            {
                db.Open();
            }
            catch (Exception db_ex)
            {
                db_error = db_ex.Message;
            }
           


            Application.SetCompatibleTextRenderingDefault(false);

            Form1 main_frm = new Form1();
          
        
            foreach (RadioButton c in main_frm.panel1.Controls)
            {
                if (Properties.Settings.Default.Order_FILTERS == c.Name)
                {
                    c.Checked = true;
                }
            }

            main_frm.checkBox2.Checked = Properties.Settings.Default.Auto_Check;
            main_frm.waiter.Text = Properties.Settings.Default.Auto_Check_Value;
            main_frm.Auto_Save_Data.Checked = Properties.Settings.Default.Auto_Save;


            if( db.State != System.Data.ConnectionState.Open )
            {
                if(db_error != null)
                {
                    MessageBox.Show(db_error, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                main_frm.Auto_Save_Data.Checked = false;
                main_frm.Auto_Save_Data.Enabled = false;
                main_frm.button5.Enabled = false;
            }



            try
            {
                Application.Run(main_frm);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Application Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error );

                if(MessageBox.Show("Do You Want To Restart Application ?", "Restart Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }

            }
           
        }
    }
}
