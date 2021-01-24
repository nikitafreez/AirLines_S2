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
    public partial class EditFlight : Form
    {

        public String conString = @"Data Source=LAPTOP-GTKGDTGS\NIKITASERVER;Initial Catalog=Session2_10;Integrated Security=True";

        private SqlConnection connection;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        public EditFlight()
        {
            InitializeComponent();
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
            label1.Font = new Font(font.Families[0], 8);
            label4.Font = new Font(font.Families[0], 8);
            label7.Font = new Font(font.Families[0], 8);
            FromLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            ToLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            DatePicker.Font = new Font(font.Families[0], 8);
            label3.Font = new Font(font.Families[0], 8);
            AircraftLabel.Font = new Font(font.Families[0], 8, FontStyle.Bold);
            label2.Font = new Font(font.Families[0], 8);
            FlightTimeBox.Font = new Font(font.Families[0], 8);
            label5.Font = new Font(font.Families[0], 8);
            PriceBox.Font = new Font(font.Families[0], 8);
            UpdateButton.Font = new Font(font.Families[0], 8);
            CancelButton.Font = new Font(font.Families[0], 8);

        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            FromLabel.Text = ShedulesForm.editingAirportFrom;
            ToLabel.Text = ShedulesForm.editingAirportTo;
            AircraftLabel.Text = ShedulesForm.editingAircraftName;
            DatePicker.Value = DateTime.Parse(ShedulesForm.editingFlightDate);
            FlightTimeBox.Text = DateTime.Parse(ShedulesForm.editingFlightTime).ToShortTimeString();
            PriceBox.Text = ShedulesForm.editingPrice.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE dbo.Schedules SET Date='{DatePicker.Value}', Time='{FlightTimeBox.Value}', EconomyPrice='{PriceBox.Text}' WHERE ID='{ShedulesForm.editingFlightID}'", connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Close();
        }
    }
}
