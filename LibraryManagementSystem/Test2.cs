using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // commenting here to test github
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samrachhika\source\C#Project\frompushparough\LibraryManagementSystem\AppData\tryDB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "Select * from userTB";
                SqlDataAdapter sa = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sa.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    messageLabel.Text = "Connection Successful ";
                }
            }
            catch (Exception ex)
            {
                messageLabel.Text = ex.Message;

            }
        }
    }
}
