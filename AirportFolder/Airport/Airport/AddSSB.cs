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
    public partial class AddSSB : Form
    {
        FormManager parentForm;
        private SqlConnection connection;

        public AddSSB(FormManager parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.name_cbox.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand readSSBCommand = new SqlCommand();
            readSSBCommand.Connection = this.parentForm.Connection;
            readSSBCommand.CommandText = "SELECT qualification FROM  sss s WHERE s.visibility = 1";

            SqlDataReader reader = readSSBCommand.ExecuteReader();

            while (reader.Read())
            {
                name_cbox.Items.Add(reader["qualification"].ToString());
            }

            reader.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.parentForm.Connection;

            if (String.IsNullOrEmpty(new_ssb_txt.Text))
            {
                MessageBox.Show("Incorrect input.");
            }

            command.CommandText = "SELECT * FROM sss s WHERE s.qualification = @ID";
            command.Parameters.AddWithValue("ID", new_ssb_txt.Text);


            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("This S.S.B. already exists in the database.");
                return;
            }

            reader.Close();

            command.CommandText = "INSERT INTO sss (qualification, visibility) VALUES (@Ssb, @Visibility)";
            command.Parameters.AddWithValue("Ssb", new_ssb_txt.Text);
            command.Parameters.AddWithValue("Visibility", 1);

            int rowAffected = command.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                MessageBox.Show("S.S.B. saved.");
                new_ssb_txt.Text =  "";
                this.parentForm.InitializeData(null);

            }
            else
            {
                MessageBox.Show("Error while saving S.S.B.");
            }
        }
    }
}
