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
    public partial class AddAirplaneModel : Form
    {
        FormAirplane parentForm;
        private SqlConnection connection;
       
        public AddAirplaneModel(FormAirplane parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.name_cbox.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand readAirplaneModelCommand = new SqlCommand();
            readAirplaneModelCommand.Connection = this.parentForm.Connection;
            readAirplaneModelCommand.CommandText = "SELECT * FROM airplane_model am";

            SqlDataReader reader = readAirplaneModelCommand.ExecuteReader();

            while (reader.Read())
            {
                name_cbox.Items.Add(reader["name"].ToString());
            }

            reader.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            SqlCommand readAirplaneModelCommand = new SqlCommand();
            readAirplaneModelCommand.Connection = this.parentForm.Connection;
            readAirplaneModelCommand.CommandText = "SELECT * FROM airplane_model am";

            SqlDataReader reader = readAirplaneModelCommand.ExecuteReader();

            bool accept = true;

            while (reader.Read())
            {
                if(reader["name"].ToString() == new_model_txt.Text)
                {
                    accept = false;
                }
            }

            reader.Close();

            if (accept)
            {
                command.CommandText = "INSERT INTO airplane_model (Name, Visibility) VALUES (@Name, @Visibility)";
                command.Parameters.AddWithValue("Name", new_model_txt.Text);
                command.Parameters.AddWithValue("Visibility", 1);



                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Airplane model saved.");
                    new_model_txt.Text = "";
                    this.parentForm.InitializeData(null);

                }

                SqlCommand readAirplaneModelCommand2 = new SqlCommand();
                readAirplaneModelCommand2.Connection = this.parentForm.Connection;
                readAirplaneModelCommand2.CommandText = "SELECT * FROM airplane_model am";

                SqlDataReader reader2 = readAirplaneModelCommand2.ExecuteReader();

                while (reader2.Read())
                {
                    name_cbox.Items.Add(reader2["name"].ToString());
                }

                reader2.Close();

            }

            else
            {
                MessageBox.Show("This airplane model already exists.");
            }
        }
    }
}
