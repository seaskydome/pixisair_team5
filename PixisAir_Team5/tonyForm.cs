using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAir_Team5
{
    public partial class tonyForm : Form
    {
        //Class level variables
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        string SQL;
        string connectionString;

        public tonyForm()
        {
            InitializeComponent();
        }

        private void tonyForm_Load(object sender, EventArgs e)
        {
            //Connection logic 
            connectionString = "Data Source=v2studentpoc;Initial Catalog=PixisAir;Persist Security Info=True;User ID=Student;Password=ichooseGateway";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            //SQL statement to get specific fields
            SQL = "SELECT TASKID, TASKDESC FROM dbo.Tasks";

            try
            {
                //clear the listbox each time a button is pressed / 
                // have to also create new dataset or there will be an error
                listDisplay.Items.Clear();
                dataSet = new DataSet();

                //Open the connection
                connection.Open();

                //Use the SQL command on the data adapter and fill the dataset
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);

                //Display to the listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    listDisplay.Items.Add(dataRow[0] + ",    " + dataRow[1]);
                }
                connection.Close();

            }catch(Exception ex)
            {
                listDisplay.Items.Add(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SQL statement to get specific fields
            SQL = "SELECT CITY,STATE,ZIP FROM dbo.ZIPPF";

            try
            {
                //clear the listbox each time a button is pressed / 
                // have to also create new dataset or there will be an error
                listDisplay.Items.Clear();
                dataSet = new DataSet();

                //Open the connection
                connection.Open();

                //Use the SQL command on the data adapter and fill the dataset
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);

                //Display to the listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    listDisplay.Items.Add(dataRow[0] + ",    " + dataRow[1] + ",    " + dataRow[2]);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                listDisplay.Items.Add(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SQL = "INSERT INTO dbo.ZIPPF (CITY, STATE, ZIP) VALUES(" + "'" + txtCity.Text + "'" + ", " + "'" + txtState.Text + "'" + ", " + "'" + txtZip.Text + "'" + ")";

            //Create SQL Command
            SqlCommand command = new SqlCommand(SQL, connection);
            
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                listDisplay.Items.Add(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
