using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace System_APP
{
    public partial class mainScreen : Form
    {
        //double temperature = 0;
        double temp = 0, Soil = 0;
        double mq3 = 0;
        double moistore = 0; 
        //string temp = "", Soil = "";
        bool updateData = false;
        SqlCommand SqlCom;
        SqlDataAdapter Adapter;
        static String lPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Omnicor\OneDrive - Omnicor (Pty) Ltd\Lulamani\second\MyAPP\System APP\Database\dataReport.mdf;Integrated Security=True;Connect Timeout=30";
        static String path_db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mthom\OneDrive\Desktop\work\AgriPlus\MyAPP\System APP\Database\dataReport.mdf;Integrated Security=True;Connect Timeout=30";


        static String pathDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lulamani Maluleka\OneDrive - Omnicor (Pty) Ltd\Lulamani\second\MyAPP\System APP\Database\dataReport.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection conn = new SqlConnection(pathDB);
        
        public mainScreen()
        {
            InitializeComponent();
            // String path_DB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\mthom\OneDrive\Desktop\work\AgriPlus\MyAPP\System APP\Database\dataReport.mdf;Integrated Security=True;Connect Timeout=30;";
            //SqlConnection conn = new SqlConnection(path_DB);
            // String conn = @"C:\Users\mthom\OneDrive\Desktop\work\AgriPlus\MyAPP\System APP\Database\dataReport.mdf";
           
            ShowData_Grid();
           // Clearing();
        }

       private void ShowData_Grid()
        {

           conn.Open();
            DataTable dtable = new DataTable("Recorded_Info");
            Adapter = new SqlDataAdapter("select * from Recorded_Info", conn);
            Adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            conn.Close();
        }

        private void PumpOpen_Click(object sender, EventArgs e)
        {
            //TURNING ON
            
            arduinoPort.Write("ON");
          //  MessageBox.Show(Soil.ToString() +"\t"+ temp.ToString() + "\t" + mq3.ToString() + "\t" + moistore.ToString());
        }

        private void pumpClose_Click(object sender, EventArgs e)
        {
            //TURNING OFF
            arduinoPort.Write("OFF");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            /*
             INSERTING THE DATA TO DATABASE:
             
              WriteDatabase()
             */
        }

        private void siticoneComboBox2_DropDown(object sender, EventArgs e)
        {
            //GETTINGS THE PORTS AVAILABLE

            string[] ports = SerialPort.GetPortNames();
            comboPorts.Items.Clear();
            comboPorts.Items.AddRange(ports);

        }

        private void openSerial_CheckedChanged(object sender, EventArgs e)
        {

            //OPENNING OF THE PORTS

            if (openSerial.Checked == true)
            {
                arduinoPort.PortName = comboPorts.Text;
                arduinoPort.Open();
            }
            else
            {
                arduinoPort.Close();
            }

        }

        private void closeSerial_CheckedChanged(object sender, EventArgs e)
        {
            //CLOSING OF THE PORTS
            if (closeSerial.Checked == true)
            {
                arduinoPort.PortName = comboPorts.Text;
                arduinoPort.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduinoPort.Close();
        }

        private void arduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //receiving the data from arduino  
            string dataFromArduino = arduinoPort.ReadTo("\n");
            Data_Parsing(dataFromArduino);
            this.BeginInvoke(new EventHandler(Show_Data));
        }

        private void Show_Data(object sender, EventArgs e)
        {
            if (updateData==true)
            {
                string final_soil;
                string final_temp;

                // final_soil = string.Format("Soil Moisture = {0}%F", Soil.ToString());
                // final_temp = string.Format("Temperature = {0}C", temp.ToString());
            
                lbl_TEMP.Text= temp.ToString();
                lbl_HUM.Text = Soil.ToString();
                lbl_SOI.Text = moistore.ToString();

            }
            else
            {
                updateData = false;
            }
        }
        //CLEARING THE DATABASE TABLES:
        private void Clearing()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Recorded_Info ";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        //INSERT T0 DATABASE
        private void WriteDatabase()
        {
            SqlCom = new SqlCommand("INSERT INTO Recorded_Info(TEMPERATURE,HUMANITY,MOISTURE) VALUES(@Temp,@Hum,@mois)", conn);
            conn.Open();
            SqlCom.Parameters.AddWithValue("@Temp", temp.ToString());
            SqlCom.Parameters.AddWithValue("@Hum", Soil.ToString());
           // SqlCom.Parameters.AddWithValue("@Ran", mq3.ToString());
            SqlCom.Parameters.AddWithValue("@mois", moistore.ToString());
            SqlCom.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Inserted Successfully");
            ShowData_Grid();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
           // Clearing();
            WriteDatabase();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            ///Downloading the data

            //coyp to clipboard
            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null)
            {
                Clipboard.SetDataObject(copydata);
            }
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];
            xlr.Select();

            xlSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

        }

        private void Scan_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click_1(object sender, EventArgs e)
        {

            //TURNING ON

            arduinoPort.Write("ON");
        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {

            //TURNING OFF
            arduinoPort.Write("OFF");
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            WriteDatabase();
        }

        private void Data_Parsing(string FromArduino)
        {

            /*
             double mq3 = 0;
             double moistore = 0;              
             */
            int pos = -1;
            string temp_mq3="";
           string temp_moistores="";
            string Soil_A ;
            string temp_A;
            if (true)
            {
                try
                {
                   // MessageBox.Show(FromArduino);
                    //from arduio raw data
                    string line;
                    //getting the first value
                    pos = FromArduino.IndexOf(";");
                    temp_A = FromArduino.Substring(0,pos);
                    FromArduino = FromArduino.Remove(0, pos+1);

                   // temp_A = FromArduino;
                    //second 
                    pos = FromArduino.IndexOf(";");
                    Soil_A = FromArduino.Substring(0, pos);
                    FromArduino = FromArduino.Remove(0, pos + 1);


                    //third
                    //pos = FromArduino.IndexOf(";");
                    //temp_moistores = FromArduino.Substring(0, pos);
                    //FromArduino = FromArduino.Remove(0, pos + 1);

                    //last
                    temp_moistores = FromArduino;


                    //converting data from arduino to double
                    temp = Convert.ToDouble(temp_A);
                    Soil = Convert.ToDouble(Soil_A);
                   moistore = Convert.ToDouble(temp_moistores);
                    //mq3 = Convert.ToDouble(temp_mq3);
                    //Soil = FromArduino;
                    // MessageBox.Show(Soil_A + temp_A + temp_mq3 + temp_moistores);
                    updateData = true;
                }
                catch (Exception)
                { 
                }
            }
            else
            {
                updateData = false;
            }
        }
    }
}
