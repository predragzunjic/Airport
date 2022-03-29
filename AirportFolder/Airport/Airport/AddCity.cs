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
    public partial class AddCity : Form
    {
        FormCity parentForm;
        private SqlConnection connection;

        public AddCity(FormCity parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            this.city_cbox.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand readCityCommand = new SqlCommand();
            readCityCommand.Connection = this.parentForm.Connection;
            readCityCommand.CommandText = "SELECT name, city_id FROM city c WHERE c.visibility = 1";

            SqlDataReader reader = readCityCommand.ExecuteReader();

            while (reader.Read())
            {
                city_cbox.Items.Add(reader["name"].ToString() + " (" + reader["city_id"].ToString() + ")");
            }

            reader.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            SqlCommand readCityCommand = new SqlCommand();
            readCityCommand.Connection = this.parentForm.Connection;
            readCityCommand.CommandText = "SELECT * FROM city c";

            SqlDataReader reader = readCityCommand.ExecuteReader();

            bool accept = true;

            while (reader.Read())
            {
                if (reader["city_id"].ToString() == city_id_txt.Text)
                {
                    accept = false;
                }
            }

            reader.Close();

            if (accept)
            {
                if(String.IsNullOrEmpty(city_id_txt.Text) || String.IsNullOrEmpty(city_id_txt.Text))
                {
                    MessageBox.Show("One or more fields are empty.");
                    return;
                }
                command.CommandText = "INSERT INTO city (City_id, Name, Visibility) VALUES (@City_id, @Name, @Visibility)";

                if (!String.IsNullOrEmpty(city_txt.Text) && !String.IsNullOrEmpty(city_id_txt.Text))
                {
                    command.Parameters.AddWithValue("City_id", city_id_txt.Text);
                    command.Parameters.AddWithValue("Name", city_txt.Text);
                }
                else
                {
                    MessageBox.Show("Your input is not correct.");
                    return;
                }

                command.Parameters.AddWithValue("Visibility", 1);
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show("City saved.");
                    city_txt.Text = "";
                    this.parentForm.InitializeData(null);

                }

            }

            else
            {
                MessageBox.Show("This city already exists in the database.");
            }
        }
    }
}
