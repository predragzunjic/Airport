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
    public partial class FormAirplane : Form
    {
        private String selectedAirplaneId = " ";
        private SqlConnection connection;
        FormHome fh;

        public FormAirplane(FormHome fh)
        {
            InitializeComponent();

            this.fh = fh;
            this.airplane_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.airplane_DGV.CellClick += airplane_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;

            InitializeConnection();
            InitializeData(null);

        }

        public SqlConnection Connection
        {
            get { return this.connection; }
        }

        public String SelectedAirplaneId
        {
            get { return this.selectedAirplaneId; }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            this.InitializeData(search_textbox.Text);
        }

        private void airplane_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.airplane_DGV.Rows[e.RowIndex];
                String id = Convert.ToString(tableRow.Cells[1].Value);
                this.selectedAirplaneId = id;
            }
        }

        private void InitializeConnection()
        {
            string connectionString = ConfigurationManager.AppSettings["DbConnection"];
            this.connection = new SqlConnection(connectionString);
            try
            {
                this.connection.Open();
                //MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeData(string searchText)
        {
            SqlCommand airplaneReadCommand = new SqlCommand();
            airplaneReadCommand.Connection = this.connection;

            if (string.IsNullOrEmpty(searchText))
            {
                airplaneReadCommand.CommandText = "SELECT a.name, a.registration, a.capacity, a.tonnage FROM airplane a WHERE a.visibility = 1";
            }
            else
            {
                airplaneReadCommand.CommandText = "SELECT * FROM airplane a WHERE " +
                                                    "a.visibility = 1 AND " +
                                                    "a.name LIKE '%' + @SearchText + '%' OR " +
                                                    "a.registration LIKE '%' + @SearchText + '%' OR " +
                                                    "a.capacity LIKE '%' + @SearchText + '%' OR " +
                                                    "a.tonnage LIKE '%' + @SearchText + '%'";
                airplaneReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }

            SqlDataReader reader = airplaneReadCommand.ExecuteReader();
            DataTable airplaneTable = new DataTable();
            airplaneTable.Load(reader);
            this.airplane_DGV.DataSource = airplaneTable;
            airplane_DGV.Columns[0].HeaderCell.Value = "Airplane model";
            airplane_DGV.Columns[1].HeaderCell.Value = "Registration";
            airplane_DGV.Columns[2].HeaderCell.Value = "Capacity";
            airplane_DGV.Columns[3].HeaderCell.Value = "Tonnage";
            airplane_DGV.Rows.RemoveAt(airplane_DGV.Rows.Count - 1);

            reader.Close();
        }

        private void load_flight_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addFlightPanel();
        }

        private void load_route_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addRoutePanel();
        }

        private void load_city_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addCityPanel();
        }

        private void load_manager_options_TSM_Click(object sender, EventArgs e)
        {
            fh.adddManagerPanel();
        }

        private void load_pilot_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addPilotPanel();
        }

        private void add_airplane_btn_Click(object sender, EventArgs e)
        {
            AddEditAirplane editAirplane = new AddEditAirplane(this, false);
            editAirplane.Show();
        }

        private void edit_airplane_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedAirplaneId != " ")
            {
                AddEditAirplane editAirplane = new AddEditAirplane(this, true);
                editAirplane.Show();
            }
            else
            {
                MessageBox.Show("Please, select an airplane.");
            }
        }

        private void add_model_btn_Click(object sender, EventArgs e)
        {
            AddAirplaneModel addModel = new AddAirplaneModel(this);
            addModel.Show();
        }

        private void loadTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fh.addTicketPanel();
        }

        private void del_airplane_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedAirplaneId != " ")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand airplaneReadCommand = new SqlCommand();
                    airplaneReadCommand.Connection = this.connection;
                    airplaneReadCommand.CommandText = "UPDATE airplane SET visibility = @Visibility WHERE registration = @Registration";
                    airplaneReadCommand.Parameters.AddWithValue("Registration", this.selectedAirplaneId);
                    airplaneReadCommand.Parameters.AddWithValue("Visibility", 0);


                    int rowAffected = airplaneReadCommand.ExecuteNonQuery();

                    airplaneReadCommand.CommandText = "UPDATE flight SET visibility = @Visibility WHERE registration = @Registration";

                    int rowAffected2 = airplaneReadCommand.ExecuteNonQuery();

                    if (rowAffected > 0 && rowAffected2 > 0)
                    {
                        MessageBox.Show("Airplane deleted!");
                        this.selectedAirplaneId = " ";
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting airplane!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Flight Selected!");
            }
        }

        private void del_model_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedAirplaneId != " ")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand airplaneReadCommand = new SqlCommand();
                    airplaneReadCommand.Connection = this.connection;
                    airplaneReadCommand.CommandText = "SELECT name FROM airplane WHERE registration = @Registration";
                    MessageBox.Show(this.selectedAirplaneId);
                    airplaneReadCommand.Parameters.AddWithValue("Registration", this.selectedAirplaneId);
                    airplaneReadCommand.Parameters.AddWithValue("Visibility", 0);
                    SqlDataReader reader = airplaneReadCommand.ExecuteReader();

                    //String s = reader.GetString(0);
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    
                    airplaneReadCommand.CommandText = "UPDATE airplane_model SET visibility = @Visibility WHERE name = @Name";
                    
                    airplaneReadCommand.Parameters.AddWithValue("Name", dt.Rows[0]["name"].ToString());
                    
                    int rowAffected = airplaneReadCommand.ExecuteNonQuery();
                    reader.Close();

                    airplaneReadCommand.CommandText = "UPDATE airplane SET visibility = @Visibility WHERE name = @Name";

                    int rowAffected2 = airplaneReadCommand.ExecuteNonQuery();

                    airplaneReadCommand.CommandText = "UPDATE flight SET visibility = @Visibility WHERE registration = @Registration";

                    int rowAffected3 = airplaneReadCommand.ExecuteNonQuery();

                    if (rowAffected > 0 && rowAffected2 > 0 && rowAffected3 > 0)
                    {
                        MessageBox.Show("Airplane model deleted!");
                        this.selectedAirplaneId = " ";
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting airplane model!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No model selected!");
            }
        }
    }
    
}

