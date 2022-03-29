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
using System.Configuration;

namespace Airport
{
    public partial class AddTicket : Form
    {
        FormFlights parentForm;
        private SqlConnection connection;
        int selectedFlightId;

        public AddTicket(FormFlights parentForm, int selectedFlightId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.selectedFlightId = selectedFlightId;            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            command.CommandText = "INSERT INTO customer (Jmbg, Name, Surname) " +
                                            " VALUES(@Jmbg, @Name, @Surname)";

            if (jmbg_txt.Text.Length < 13)
            {
                MessageBox.Show("Invalid entry.");
                return;
            }

            if (String.IsNullOrEmpty(jmbg_txt.Text) || String.IsNullOrEmpty(name_txt.Text) || String.IsNullOrEmpty(surname_txt.Text))
            {
                MessageBox.Show("Jmbg, name and surname fields must be filled in.");
                return;
            }

            command.Parameters.AddWithValue("Jmbg", jmbg_txt.Text);
            command.Parameters.AddWithValue("Name", name_txt.Text);
            command.Parameters.AddWithValue("Surname", surname_txt.Text);

            int rowAffected1 = command.ExecuteNonQuery();

            command.CommandText = "INSERT INTO ticket (jmbg, flight_id, visibility) " +
                                            " VALUES(@Jmbg, @Flight_id, @Visibility)";

            command.Parameters.AddWithValue("Flight_id", selectedFlightId);
            command.Parameters.AddWithValue("Visibility", 1);

            int rowAffected2 = command.ExecuteNonQuery();

            SqlCommand readFlightCommand = new SqlCommand();
            readFlightCommand.Connection = this.parentForm.Connection;
            readFlightCommand.CommandText = "SELECT reserved_cards FROM flight f WHERE f.id = @ID";
            readFlightCommand.Parameters.AddWithValue("ID", this.selectedFlightId);

            SqlDataReader reader = readFlightCommand.ExecuteReader();
            reader.Read();

            int reservedCards = reader.GetInt32(0);
            reservedCards++;
            reader.Close();

            command.CommandText = "UPDATE flight " +
                                    "SET reserved_cards = @Reserved_cards " +
                                    "WHERE id = @ID";
            command.Parameters.AddWithValue("Reserved_cards", reservedCards);
            command.Parameters.AddWithValue("ID", this.selectedFlightId);

            int rowAffected3 = command.ExecuteNonQuery();

            if (rowAffected1 > 0 && rowAffected2 > 0 && rowAffected3 > 0)
            {
                MessageBox.Show("Ticket saved.");
                jmbg_txt.Text = name_txt.Text = surname_txt.Text = "";
                this.parentForm.InitializeData(null);

            }
            else
            {
                MessageBox.Show("Error while saving a ticket.");
            }

        }
    }
}
