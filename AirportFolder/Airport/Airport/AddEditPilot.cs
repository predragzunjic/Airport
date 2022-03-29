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
    public partial class AddEditPilot : Form
    {
        private SqlConnection connection;
        private FormPilot parentForm;
        private bool edit;

        public AddEditPilot(FormPilot parentForm, bool edit)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.edit = edit;

            if (edit == true)
            {
                // Load an airplane from the database
                SqlCommand readPilotCommand = new SqlCommand();
                readPilotCommand.Connection = this.parentForm.Connection;
                readPilotCommand.CommandText = "SELECT p.jmbg, w.name, w.surname, w.phone_number, p.flight_hours FROM (pilot p INNER JOIN " +
                                                "worker w on p.jmbg =  w.jmbg) WHERE p.jmbg = @ID";
                readPilotCommand.Parameters.AddWithValue("ID", this.parentForm.SelectedJMBG);

                SqlDataReader reader = readPilotCommand.ExecuteReader();
                reader.Read();

                jmbg_txt.Text = reader.GetString(0);
                name_txt.Text = reader.GetString(1);
                surname_txt.Text = reader.GetString(2);
                if (reader.IsDBNull(3)){
                    phone_number_txt.Text = "No data";
                }
                else
                {
                    phone_number_txt.Text = reader.GetString(3);
                }
                
                flight_hours_txt.Text = reader.GetInt32(4).ToString();

                reader.Close();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            if (this.edit)
            {
                command.CommandText = "UPDATE worker " +
                                            "SET jmbg = @Jmbg, " +
                                            "name = @Name, " +
                                            "surname = @Surname, " +
                                            "phone_number = @Phone_number " +
                                            "WHERE jmbg = @PilotJMBG";

                command.Parameters.AddWithValue("PilotJMBG", this.parentForm.SelectedJMBG);

                if (jmbg_txt.Text.Length < 13)
                {
                    MessageBox.Show("Jmbg must have thirteen numbers.");
                    return;
                }

                if (String.IsNullOrEmpty(jmbg_txt.Text) || String.IsNullOrEmpty(name_txt.Text) || String.IsNullOrEmpty(surname_txt.Text)
                    || String.IsNullOrEmpty(flight_hours_txt.Text))
                {
                    MessageBox.Show("Jmbg, name, surname and flight hours fields must be filled in.");
                    return;
                }

                if (String.IsNullOrEmpty(phone_number_txt.Text))
                {
                    command.Parameters.AddWithValue("Phone_number", "No data");
                }
                else
                {
                    command.Parameters.AddWithValue("Phone_number", phone_number_txt.Text);
                }

                command.Parameters.AddWithValue("Jmbg", jmbg_txt.Text);
                command.Parameters.AddWithValue("Name", name_txt.Text);
                command.Parameters.AddWithValue("Surname", surname_txt.Text);

                int rowAffected1 = command.ExecuteNonQuery();

                command.CommandText = "UPDATE pilot " +
                                        "SET jmbg = @Jmbg, " +
                                        "flight_hours = @Flight_hours " +
                                        "WHERE jmbg = @PilotJMBG";

                command.Parameters.AddWithValue("Flight_hours", flight_hours_txt.Text);
                int rowAffected2 = command.ExecuteNonQuery();

                if (rowAffected1 > 0 && rowAffected2 > 0)
                {
                    MessageBox.Show("Pilot saved.");
                    jmbg_txt.Text = name_txt.Text = surname_txt.Text = phone_number_txt.Text = "";
                    this.parentForm.InitializeData(null);

                }
                else
                {
                    MessageBox.Show("Error while saving a pilot.");
                }

            }
            else
            {
                command.CommandText = "SELECT * FROM worker w WHERE w.jmbg = @ID";
                command.Parameters.AddWithValue("ID", jmbg_txt.Text);

                SqlDataReader reader2 = command.ExecuteReader();

                if (reader2.HasRows)
                {
                    MessageBox.Show("This pilot already exists in the database.");
                    return;
                }

                reader2.Close();


                command.CommandText = "INSERT INTO worker (Jmbg, Name, Surname, Phone_number, Visibility) " +
                                            " VALUES(@Jmbg, @Name, @Surname, @Phone_number, @Visibility)";

                if(jmbg_txt.Text.Length < 13)
                {
                    MessageBox.Show("Invalid entry.");
                    return;
                }

                if (String.IsNullOrEmpty(jmbg_txt.Text) || String.IsNullOrEmpty(name_txt.Text) || String.IsNullOrEmpty(surname_txt.Text)
                    || String.IsNullOrEmpty(flight_hours_txt.Text))
                {
                    MessageBox.Show("Jmbg, name, surname and flight hours fields must be filled in.");
                    return;
                }

                if (String.IsNullOrEmpty(phone_number_txt.Text))
                {
                    command.Parameters.AddWithValue("Phone_number", "No data");
                }
                else
                {
                    command.Parameters.AddWithValue("Phone_number", phone_number_txt.Text);
                }

                command.Parameters.AddWithValue("Jmbg", jmbg_txt.Text);
                command.Parameters.AddWithValue("Name", name_txt.Text);
                command.Parameters.AddWithValue("Surname", surname_txt.Text);                        
                command.Parameters.AddWithValue("Flight_hours", flight_hours_txt.Text);
                command.Parameters.AddWithValue("Visibility", 1);

                int rowAffected1 = command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO pilot (jmbg, flight_hours)" +
                                        "VALUES(@Jmbg, @Flight_hours)";
                
                int rowAffected2 = command.ExecuteNonQuery();

                if (rowAffected1 > 0 && rowAffected2 > 0)
                {
                    MessageBox.Show("Pilot saved.");
                    jmbg_txt.Text = name_txt.Text = surname_txt.Text = phone_number_txt.Text = flight_hours_txt.Text = "";
                    this.parentForm.InitializeData(null);

                }
                else
                {
                    MessageBox.Show("Error while saving a pilot.");
                }
            }

        }
    }
}
