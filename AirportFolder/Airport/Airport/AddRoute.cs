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
    public partial class AddRoute : Form
    {
        FormRoute parentForm;
        private SqlConnection connection;

        public AddRoute(FormRoute parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            this.left_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.right_cbox.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand readCityCommand = new SqlCommand();
            readCityCommand.Connection = this.parentForm.Connection;
            readCityCommand.CommandText = "SELECT c.city_id, c.name FROM city c WHERE c.visibility = 1";

            SqlDataReader reader = readCityCommand.ExecuteReader();

            while (reader.Read())
            {
                left_cbox.Items.Add(reader["name"].ToString() + "(" + reader["city_id"].ToString() + ")");
                right_cbox.Items.Add(reader["name"].ToString() + "(" + reader["city_id"].ToString() + ")");
            }

            reader.Close();
        }

        private string returnCityId(String  s)
        {

            int x = 0;
            int y = 0;
            string ret = "";

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(')
                {
                    x = i;
                }
                if (s[i] == ')')
                {
                    y = i;
                }
            }
          
            ret = s.Substring(x + 1, y - x - 1);

            MessageBox.Show(ret);

            return ret;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            string left = returnCityId(left_cbox.Text);
            string right = returnCityId(right_cbox.Text);

            command.CommandText = "SELECT r.current_city, r.destination FROM route r WHERE r.current_city = @ID1 AND r.destination = @ID2";
            command.Parameters.AddWithValue("ID1", left);
            command.Parameters.AddWithValue("ID2", right);

            SqlDataReader reader2 = command.ExecuteReader();

            if (reader2.HasRows)
            {
                MessageBox.Show("This route already exists in the database.");
                return;
            }

            reader2.Close();

            if (String.IsNullOrEmpty(left) || String.IsNullOrEmpty(right))
            {
                MessageBox.Show("One or more fields are empty.");
                return;
            }

            if (left == right)
            {
                MessageBox.Show("The fields are the same");
                return;
            }

            command.CommandText = "INSERT INTO route (Current_city, Destination, Visibility) VALUES (@Current_city, @Destination, @Visibility)";
            command.Parameters.AddWithValue("Current_city", left);
            command.Parameters.AddWithValue("Destination", right);
            command.Parameters.AddWithValue("Visibility", 1);

            int rowAffected = command.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                MessageBox.Show("Route saved.");
                left_cbox.Text = right_cbox.Text ="";
                this.parentForm.InitializeData(null);

            }

        }
    }
}
