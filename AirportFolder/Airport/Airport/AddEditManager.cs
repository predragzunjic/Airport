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
    public partial class AddEditManager : Form
    {
        private SqlConnection connection;
        private FormManager parentForm;
        private bool edit;

        public AddEditManager(FormManager parentForm, bool edit)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.edit = edit;
            this.name_cbox.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand readManagerCommand = new SqlCommand();
            readManagerCommand.Connection = this.parentForm.Connection;
            readManagerCommand.CommandText = "SELECT qualification FROM sss s WHERE s.visibility = 1";
            SqlDataReader reader = readManagerCommand.ExecuteReader();

            while (reader.Read())
            {
                name_cbox.Items.Add(reader["qualification"].ToString());
            }

            reader.Close();

            if (edit == true)
            {
               
                SqlCommand readManagerCommand2 = new SqlCommand();
                readManagerCommand2.Connection = this.parentForm.Connection;
                readManagerCommand2.CommandText = "SELECT m.jmbg, w.name, w.surname, w.phone_number, m.qualification FROM (manager m INNER JOIN " +
                                                "worker w on m.jmbg =  w.jmbg INNER JOIN sss s on m.qualification = s.qualification) " +
                                                "WHERE m.jmbg = @ID AND w.visibility = 1";
                readManagerCommand.Parameters.AddWithValue("ID", this.parentForm.SelectedJMBG);

                SqlDataReader reader2 = readManagerCommand.ExecuteReader();
                reader2.Read();

                jmbg_txt.Text = reader2.GetString(0);
                name_txt.Text = reader2.GetString(1);
                surname_txt.Text = reader2.GetString(2);
                if (reader2.IsDBNull(3))
                {
                    phone_number_txt.Text = "No data";
                }
                else
                {
                    phone_number_txt.Text = reader2.GetString(3);
                }
                name_cbox.SelectedItem = reader2.GetString(4);
                name_cbox.SelectedText = reader2.GetString(4);
                
                

                reader2.Close();
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
                                            "phone_number = @Phone_number, " +
                                            "visibility = @Visibility" +
                                            "WHERE jmbg = @ManagerJMBG";

                command.Parameters.AddWithValue("ManagerJMBG", this.parentForm.SelectedJMBG);

                if (jmbg_txt.Text.Length < 13)
                {
                    MessageBox.Show("Jmbg must have thirteen numbers.");
                    return;
                }

                if (String.IsNullOrEmpty(jmbg_txt.Text) || String.IsNullOrEmpty(name_txt.Text) || String.IsNullOrEmpty(surname_txt.Text)
                    || String.IsNullOrEmpty(name_cbox.SelectedItem.ToString()))
                {
                    MessageBox.Show("Jmbg, name, surname and S.S.B. fields must be filled in.");
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
                command.Parameters.AddWithValue("Visibility", 1);

                int rowAffected1 = command.ExecuteNonQuery();

                command.CommandText = "UPDATE manager " +
                                        "SET jmbg = @Jmbg, " +
                                        "qualification = @Qualification " +
                                        "WHERE jmbg = @ManagerJMBG";

                command.Parameters.AddWithValue("Flight_hours", name_cbox.SelectedItem.ToString());
                int rowAffected2 = command.ExecuteNonQuery();

                if (rowAffected1 > 0 && rowAffected2 > 0)
                {
                    MessageBox.Show("Manager saved.");
                    jmbg_txt.Text = name_txt.Text = surname_txt.Text = phone_number_txt.Text = "";
                    this.parentForm.InitializeData(null);

                }
                else
                {
                    MessageBox.Show("Error while saving a manager.");
                }

            }
            else
            {
                command.CommandText = "SELECT * FROM worker w WHERE w.jmbg = @ID";
                command.Parameters.AddWithValue("ID", jmbg_txt.Text);

                SqlDataReader reader2 = command.ExecuteReader();

                if (reader2.HasRows)
                {
                    MessageBox.Show("This manager already exists in the database.");
                    return;
                }

                reader2.Close();


                command.CommandText = "INSERT INTO worker (Jmbg, Name, Surname, Phone_number, Visibility) " +
                                            " VALUES(@Jmbg, @Name, @Surname, @Phone_number, @Visibility)";

                if (jmbg_txt.Text.Length < 13)
                {
                    MessageBox.Show("Invalid entry.");
                    return;
                }

                if (String.IsNullOrEmpty(jmbg_txt.Text) || String.IsNullOrEmpty(name_txt.Text) || String.IsNullOrEmpty(surname_txt.Text)
                    || String.IsNullOrEmpty(name_cbox.SelectedItem.ToString()))
                {
                    MessageBox.Show("Jmbg, name, surname and S.S.B. fields must be filled in.");
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
                command.Parameters.AddWithValue("Qualification", name_cbox.SelectedItem.ToString());
                command.Parameters.AddWithValue("Visibility", 1);

                int rowAffected1 = command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO manager (jmbg, qualification)" +
                                        "VALUES(@Jmbg, @Qualification)";
                //command.Parameters.AddWithValue("Qualification", name_cbox.SelectedItem.ToString());
                int rowAffected2 = command.ExecuteNonQuery();

                if (rowAffected1 > 0 && rowAffected2 > 0)
                {
                    MessageBox.Show("Manager saved.");
                    jmbg_txt.Text = name_txt.Text = surname_txt.Text = phone_number_txt.Text = "";
                    this.parentForm.InitializeData(null);

                }
                else
                {
                    MessageBox.Show("Error while saving a manager.");
                }
            }
        }
    }
}
