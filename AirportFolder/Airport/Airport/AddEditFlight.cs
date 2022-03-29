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
using System.Configuration;

namespace Airport
{
    public partial class AddEditFlight : Form
    {
        private SqlConnection connection;
        private FormFlights parentForm;
        private bool edit;

        public AddEditFlight(FormFlights parentForm, Boolean edit)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.edit = edit;
            this.pilot_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.airplane_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.route_cbox.DropDownStyle = ComboBoxStyle.DropDownList;


            SqlCommand readFlightCommand = new SqlCommand();
            readFlightCommand.Connection = this.parentForm.Connection;
            readFlightCommand.CommandText = "SELECT w.name, w.surname, w.jmbg FROM worker w INNER JOIN pilot p on w.jmbg = p.jmbg " +
                                                "WHERE w.visibility = 1"; 

            SqlDataReader reader = readFlightCommand.ExecuteReader();

            while (reader.Read())
            {
                pilot_cbox.Items.Add(reader["name"].ToString() + " " + reader["surname"].ToString() + "(" + reader["jmbg"]+ ")");
                
            }

            reader.Close();

            readFlightCommand.CommandText = "SELECT registration, name FROM airplane " +
                                                "WHERE visibility = 1";
            reader = readFlightCommand.ExecuteReader();

            while (reader.Read())
            {
                airplane_cbox.Items.Add(reader["registration"].ToString() + " " + reader["name"].ToString());

            }

            reader.Close();

            readFlightCommand.CommandText = "SELECT r.current_city, r.destination FROM route r " +
                                                "WHERE r.visibility = 1";

            reader = readFlightCommand.ExecuteReader();

            while (reader.Read())
            {
                route_cbox.Items.Add(reader["current_city"].ToString() + "-" + reader["destination"].ToString());
            }

            

            reader.Close();
            if (edit == true)
            { 
                readFlightCommand.CommandText = "SELECT f.id, w.name, w.surname, am.name, a.registration, f.flight_date, f.current_city, f.destination, w.jmbg " +
                                                "FROM(airplane_model am INNER JOIN airplane a on am.name = a.name " +
                                                "INNER JOIN flight f on a.registration = f.registration and a.name = f.name " +
                                                "INNER JOIN worker w on f.jmbg = w.jmbg " +
                                                "INNER JOIN route r on f.current_city = r.current_city and f.destination = r.destination) " +
                                                "WHERE f.visibility = 1 AND f.id = @ID";
                readFlightCommand.Parameters.AddWithValue("ID", this.parentForm.SelectedFlightId);

                reader = readFlightCommand.ExecuteReader();
                reader.Read();


                pilot_cbox.SelectedItem = reader.GetString(1) + " " + reader.GetString(2) + "(" + reader["jmbg"] + ")";
                airplane_cbox.SelectedItem = reader.GetString(4) + " " + reader.GetString(3);
                route_cbox.SelectedItem = reader.GetString(6) + "-" + reader.GetString(7); ;
                flight_date_dtp.Value = reader.GetDateTime(5);

                reader.Close();
            }

            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            if (this.edit)
            {
                command.CommandText = "UPDATE flight " +
                                            "SET registration = @Registration, " +
                                            "name = @Name, " +
                                            "jmbg = @Jmbg, " +
                                            "flight_date = @Flight_date, " +
                                            "current_city = @Current_city, " +
                                            "destination = @Destination, " +
                                            "reserved_cards = @Reserved_cards " +
                                            "WHERE id = @ID";

                command.Parameters.AddWithValue("ID", this.parentForm.SelectedFlightId);

            }
            else
            {
                command.CommandText = "INSERT INTO flight (Name, Registration, Jmbg, Flight_date, Current_city, Destination, Visibility, Reserved_Cards) " +
                                            " VALUES(@Name, @Registration, @Jmbg, @Flight_date, @Current_city, @Destination, @Visibility, @Reserved_Cards)";
            }

            if (String.IsNullOrEmpty(pilot_cbox.SelectedItem.ToString()) || String.IsNullOrEmpty(airplane_cbox.SelectedItem.ToString()) ||
                String.IsNullOrEmpty(route_cbox.SelectedItem.ToString()))
            {
                MessageBox.Show("Data is not properly entered");
                return;
            }

            DateTime today = DateTime.Today;

            if(DateTime.Compare(today, flight_date_dtp.Value) > 0)
            {
                MessageBox.Show("Date is impossible.");
                return;
            }

            int i = 0;
            while(airplane_cbox.SelectedItem.ToString()[i] != ' ')
            {
                i++;
            }

            command.Parameters.AddWithValue("Name", airplane_cbox.SelectedItem.ToString().Substring(i + 1, airplane_cbox.SelectedItem.ToString().Length - i - 1));
            command.Parameters.AddWithValue("Registration", airplane_cbox.SelectedItem.ToString().Substring(0, i));

            i = 0;
            int j = 0;

            for(int k = 0; k < pilot_cbox.SelectedItem.ToString().Length; k++)
            {
                if(pilot_cbox.SelectedItem.ToString()[k] == '(')
                {
                    i = k;
                }
                if (pilot_cbox.SelectedItem.ToString()[k] == ')')
                {
                    j = k;
                }

            }

            command.Parameters.AddWithValue("Jmbg", pilot_cbox.SelectedItem.ToString().Substring(i + 1, j - i - 1));
            command.Parameters.AddWithValue("Visibility", 1);

            i = 0;

            while(route_cbox.SelectedItem.ToString()[i] != '-')
            {
                i++;
            }

            command.Parameters.AddWithValue("Current_city", route_cbox.SelectedItem.ToString().Substring(0, i));
            command.Parameters.AddWithValue("Destination", route_cbox.SelectedItem.ToString().Substring(i + 1, route_cbox.SelectedItem.ToString().Length - i - 1));

            SqlCommand readFlightCommand = new SqlCommand();
            readFlightCommand.Connection = this.parentForm.Connection;
            readFlightCommand.CommandText = "SELECT a.registration FROM flight f INNER JOIN airplane a on f.registration = a.registration " + 
                                                "WHERE f.visibility = 1 AND f.flight_date = @Flight_date";

            readFlightCommand.Parameters.AddWithValue("Flight_date", flight_date_dtp.Value);
            using (SqlDataReader reader = readFlightCommand.ExecuteReader())
            {
                reader.Read();

                if (reader.HasRows)
                {
                    MessageBox.Show("This plane already has a flight on that date.");
                    return;
                }

                reader.Close();
            }
            command.Parameters.AddWithValue("Flight_date", flight_date_dtp.Value);
            command.Parameters.AddWithValue("Reserved_cards", 0);

            int rowAffected = command.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                MessageBox.Show("Flight saved.");
               
                this.parentForm.InitializeData(null);

            }
            else
            {
                MessageBox.Show("Error while saving flight.");
            }
        }
    }
}
