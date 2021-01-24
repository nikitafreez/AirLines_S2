using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLines_S2
{

    public partial class ShedulesForm : Form
    {

        public String conString = @"Data Source=LAPTOP-GTKGDTGS\NIKITASERVER;Initial Catalog=Session2_10;Integrated Security=True";

        private SqlConnection connection;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        public ShedulesForm()
        {
            InitializeComponent();

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Airports", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("dbo.FromAirports");
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Airports", connection);
                DataTable dt = dataSet.Tables.Add("dbo.ToAirports");

                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            FromComboBox.DataSource = dataSet.Tables["dbo.FromAirports"];
            FromComboBox.DisplayMember = "IATACode";
            FromComboBox.ValueMember = "ID";
            ToComboBox.DataSource = dataSet.Tables["dbo.ToAirports"];
            ToComboBox.DisplayMember = "IATACode";
            ToComboBox.ValueMember = "ID";


            FontsInProject();
            ApplyFonts();
        }
        PrivateFontCollection font;
        private void FontsInProject()
        {
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("Fonts/TeXGyreAdventor-Regular.ttf");
        }
        private void ApplyFonts()
        {
            dataGridView1.Font = new Font(font.Families[0], 8);
            CancelButton.Font = new Font(font.Families[0], 8);
            label1.Font = new Font(font.Families[0], 8);
            label2.Font = new Font(font.Families[0], 8);
            label3.Font = new Font(font.Families[0], 8);
            FromComboBox.Font = new Font(font.Families[0], 8);
            ToComboBox.Font = new Font(font.Families[0], 8);
            ApplyAirportsButton.Font = new Font(font.Families[0], 8);
            ClearButton.Font = new Font(font.Families[0], 8);
            label4.Font = new Font(font.Families[0], 8);
            ApplyNumbersButton.Font = new Font(font.Families[0], 8);
            label7.Font = new Font(font.Families[0], 8);
            DatePicker.Font = new Font(font.Families[0], 8);
            DateButton.Font = new Font(font.Families[0], 8);
            EditButton.Font = new Font(font.Families[0], 8);

        }

        private void GetTable()
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                //dataAdapter = new SqlDataAdapter("SELECT dbo.Schedules.ID, Date, Time, dbo.Routes.DepartureAirportID AS FromAirport, dbo.Routes.ArrivalAirportID AS ToAirport, FlightNumber, dbo.Aircrafts.Name AS Aircraft, CAST(EconomyPrice as numeric(10,0)) AS Price FROM dbo.Schedules" +
                //    " INNER JOIN dbo.Routes ON dbo.Schedules.RouteID = dbo.Routes.ID JOIN dbo.Airports ON dbo.Routes.DepartureAirportID = dbo.Airports.ID" +
                //    " INNER JOIN dbo.Aircrafts ON dbo.Schedules.AircraftID = dbo.Aircrafts.ID", connection);
                dataAdapter = new SqlDataAdapter("SELECT dbo.Schedules.ID, Date, Time, (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.DepartureAirportID) AS FromAirport, (SELECT IATACode FROM dbo.Airports WHERE ID = dbo.Routes.ArrivalAirportID) AS ToAirport, FlightNumber, dbo.Aircrafts.Name AS Aircraft, CAST(EconomyPrice as numeric(10,0)) AS Price FROM dbo.Schedules" +
                    " INNER JOIN dbo.Routes ON dbo.Schedules.RouteID = dbo.Routes.ID JOIN dbo.Airports ON dbo.Routes.DepartureAirportID = dbo.Airports.ID" +
                    " INNER JOIN dbo.Aircrafts ON dbo.Schedules.AircraftID = dbo.Aircrafts.ID", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("dbo.Schedules");
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dataSet.Tables["dbo.Schedules"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                    int status = Convert.ToInt32(command.ExecuteScalar());
                    if (status == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ShedulesForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID='{id}'", connection);
                byte k = Convert.ToByte(command.ExecuteScalar());
                if (k == 0)
                {
                    k = 1;
                }
                else
                {
                    k = 0;
                }
                SqlCommand command1 = new SqlCommand(String.Format("UPDATE dbo.Schedules SET Confirmed='{0}' WHERE ID='{1}'", k, id), connection);
                command1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                GetTable();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FromComboBox.Text) && string.IsNullOrEmpty(ToComboBox.Text))
            {
                GetTable();
            }
            else if (FromComboBox.Text == ToComboBox.Text)
            {
                MessageBox.Show("Invalid Filter", "Warning");
            }
            else
            {
                if (!string.IsNullOrEmpty(FromComboBox.Text))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}'", FromComboBox.Text);
                }
                if (!string.IsNullOrEmpty(ToComboBox.Text))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("ToAirport = '{0}'", ToComboBox.Text);
                }
                if (!string.IsNullOrEmpty(FromComboBox.Text) && !string.IsNullOrEmpty(ToComboBox.Text))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("FromAirport = '{0}'", FromComboBox.Text);
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("ToAirport = '{0}'", ToComboBox.Text);
                }
            }

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                    int status = Convert.ToInt32(command.ExecuteScalar());
                    if (status == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private void DeleteFromButton_Click(object sender, EventArgs e)
        {
            FromComboBox.Text = null;
        }

        private void DeleteToButton_Click(object sender, EventArgs e)
        {
            ToComboBox.Text = null;
        }

        private void DeleteNumButton_Click(object sender, EventArgs e)
        {
            FlightNumBox.Text = null;
        }

        private void ApplyNumbersButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FlightNumBox.Text))
            {
                GetTable();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("FlightNumber = '{0}'", FlightNumBox.Text);
            }

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                    int status = Convert.ToInt32(command.ExecuteScalar());
                    if (status == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DateButton_Click(object sender, EventArgs e)
        {
            string date = DatePicker.Value.ToString("dd.MM.yyyy");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date = '{0}'", date);

            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    SqlCommand command = new SqlCommand($"SELECT Confirmed FROM dbo.Schedules WHERE ID LIKE '%{id}%'", connection);
                    int status = Convert.ToInt32(command.ExecuteScalar());
                    if (status == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int editingFlightID;
        public static int editingPrice;
        public static string editingAirportFrom;
        public static string editingAirportTo;
        public static string editingAircraftName;
        public static string editingFlightDate;
        public static string editingFlightTime;
        private void EditButton_Click(object sender, EventArgs e)
        {
            editingFlightID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            editingAirportFrom = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            editingAirportTo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            editingAircraftName = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            editingFlightDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()).ToString("dd.MM.yyyy");
            editingFlightTime = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()).ToString("HH:mm");
            editingPrice = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            EditFlight flight = new EditFlight();
            flight.Show();
        }
    }
}
