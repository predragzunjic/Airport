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
    public partial class AddEditAirplane : Form
    {
        private SqlConnection connection;
        private FormAirplane parentForm;
        private bool edit;

        public AddEditAirplane(FormAirplane parentForm, bool edit)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.edit = edit;
            this.name_cbox.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand readAirplaneModelCommand = new SqlCommand();
            readAirplaneModelCommand.Connection = this.parentForm.Connection;
            readAirplaneModelCommand.CommandText = "SELECT am.name FROM airplane_model am WHERE am.visibility = 1";

            SqlDataReader reader = readAirplaneModelCommand.ExecuteReader();

            while (reader.Read())
            {
                name_cbox.Items.Add(reader["name"].ToString());
            }

            reader.Close();

            if (edit == true)
            {
               
                SqlCommand readAirplaneCommand = new SqlCommand();
                readAirplaneCommand.Connection = this.parentForm.Connection;
                readAirplaneCommand.CommandText = "SELECT * FROM airplane a WHERE registration = @ID";
                readAirplaneCommand.Parameters.AddWithValue("ID", this.parentForm.SelectedAirplaneId);

                SqlDataReader reader2 = readAirplaneCommand.ExecuteReader();
                reader2.Read();

                name_cbox.SelectedItem = reader2.GetString(0);
                name_cbox.SelectedText = reader2.GetString(0);
                registration_txt.Text = reader2.GetString(1);
                capacity_txt.Text = reader2.GetInt32(2).ToString();
                tonnage_txt.Text = reader2.GetInt32(3).ToString();

                reader2.Close();
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            if (this.edit)
            {
                command.CommandText = "UPDATE airplane " +
                                            "SET registration = @Registration, " +
                                            "name = @Name, " +
                                            "capacity = @Capacity, " +
                                            "tonnage = @Tonnage " + 
                                            "WHERE registration = @AirplaneRegistration";

                command.Parameters.AddWithValue("AirplaneRegistration", this.parentForm.SelectedAirplaneId);

            }
            else
            {
                command.CommandText = "INSERT INTO airplane (Registration, Name, Capacity, Tonnage, Visibility) " +
                                            " VALUES(@Registration, @Name, @Capacity, @Tonnage, @Visibility)";
            }

            if(String.IsNullOrEmpty(registration_txt.Text) || String.IsNullOrEmpty(capacity_txt.Text)) 
            {
                MessageBox.Show("Registration and capacity fields must be filled in.");
                return;
            }

            if (String.IsNullOrEmpty(tonnage_txt.Text))
            {
                command.Parameters.AddWithValue("Tonnage", "No data");
            }
            else
            {
                command.Parameters.AddWithValue("Tonnage", tonnage_txt.Text);
            }

            command.Parameters.AddWithValue("Registration", registration_txt.Text);
            command.Parameters.AddWithValue("Name", name_cbox.SelectedItem.ToString());
            if(string.IsNullOrEmpty(name_cbox.Text) || name_cbox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an airplane model.");
                return;
            }

            command.Parameters.AddWithValue("Capacity", capacity_txt.Text);
            command.Parameters.AddWithValue("Visibility", 1);

            int rowAffected = command.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                MessageBox.Show("Airplane saved.");
                registration_txt.Text = name_cbox.Text = capacity_txt.Text = tonnage_txt.Text = "";
                this.parentForm.InitializeData(null);

            }
            else
            {
                MessageBox.Show("Error while saving employee.");
            }
        }
    }
}
