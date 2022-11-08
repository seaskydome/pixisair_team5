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

namespace PixisAir_Team5
{
    public partial class OskarForm1 : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public OskarForm1()
        {
            InitializeComponent();
        }

        private void OskarForm1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=v2studentpoc;Initial Catalog=PixisAir;" +
                "Persist Security Info=True;User ID=Student;Password=ichooseGateway";

            SQL = "Select * from dbo.employee";

            connection = new SqlConnection(connectionString);
            // data adapter takes sql and connection
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void btnEmployeeInRegion_Click(object sender, EventArgs e)
        {
            String airport = txtAirport.Text;
            String city = "";
            SQL = "Select ARCITYNM from dbo.airport " +
                "where ARNM = '" + airport +"'";

            lstRecords.Items.Clear();

            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(SQL, connection);
                dataSet = new DataSet();

                // put data into dataset
                dataAdapter.Fill(dataSet);

                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    city = (String) dataRow[0];
                }

                dataSet.Clear();

                SQL = "Select EMPNO, EFNAME, ELNAME from dbo.employee " +
                "where ECITY = '" + city + "'";

                lstRecords.Items.Add("List of employees in: " + city);
                dataAdapter = new SqlDataAdapter(SQL, connection);
                dataSet = new DataSet();

                // put data into dataset
                dataAdapter.Fill(dataSet);

                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    lstRecords.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2]);
                }

                dataSet.Clear();

            }
            catch (Exception ex)
            {
                lstRecords.Items.Add(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void btnAirplane_Click(object sender, EventArgs e)
        {
            SQL = "Select PlaneNo, PMAKE, PLANEMODEL from dbo.airplane ";
            lstRecords.Items.Clear();

            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(SQL, connection);
                dataSet = new DataSet();

                // put data into dataset
                dataAdapter.Fill(dataSet);

                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    lstRecords.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2]);
                }

            }
            catch (Exception ex)
            {
                lstRecords.Items.Add(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String num = txtPlaneNo.Text;
            String make = txtMake.Text;
            String model = txtModel.Text;

            String cmdText = "UPDATE dbo.airplane SET PMAKE = '" + make + "', PLANEMODEL = '" + model + "' "
                + "WHERE PLANENO = '" + num + "'";

            try
            {
                
                connection.Open();

                SqlCommand command = new SqlCommand(cmdText, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                lstRecords.Items.Add(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
