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

namespace System_APP
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\mthom\OneDrive\Desktop\work\AgriPlus\MyAPP\System APP\Database\dataReport.mdf";Integrated Security=True;Connect Timeout=30
        
        
        static String pathDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lulamani Maluleka\OneDrive - Omnicor (Pty) Ltd\Lulamani\second\MyAPP\System APP\Database\dataReport.mdf;Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(pathDB);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string user = siticoneTextBox1.Text;
            string pass = siticoneTextBox2.Text;
            conn.Open();
            SqlCommand infoReader = new SqlCommand("SELECT [USERNAME][PASSWORD] FROM LOGIN_USER WHERE [USERNAME] = '" +user+ "' AND [PASSWORD] = '" +pass+ "'", conn);
            SqlDataReader readerDB = infoReader.ExecuteReader();

            if (readerDB.Read()==true)
            {
                MessageBox.Show("CORRECT DETAILS!!");
                this.Hide();
                mainScreen form1 = new mainScreen();
                form1.Show();
            }
            else 
            {
                MessageBox.Show("INCORRECT DETAILS!!");
            }
            conn.Close();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
