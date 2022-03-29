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
    public partial class FormPilot : Form
    {
        private SqlConnection connection;
        FormHome fh;
        String selectedJMBG = " ";

        public FormPilot(FormHome fh)
        {
            InitializeComponent();
            this.fh = fh;
            this.pilot_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.pilot_DGV.CellClick += pilot_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;

            InitializeConnection();
            InitializeData(null);

            pilot_DGV.Rows.RemoveAt(pilot_DGV.Rows.Count - 1);
        }

        public SqlConnection Connection
        {
            get { return this.connection; }
        }

        public String SelectedJMBG
        {
            get { return this.selectedJMBG; }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            this.InitializeData(search_textbox.Text);
        }

        private void pilot_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.pilot_DGV.Rows[e.RowIndex];
                String id = Convert.ToString(tableRow.Cells[0].Value);
                this.selectedJMBG = id;
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
            SqlCommand pilotReadCommand = new SqlCommand();
            pilotReadCommand.Connection = this.connection;

            if (string.IsNullOrEmpty(searchText))
            {
                pilotReadCommand.CommandText = "SELECT w.jmbg, w.name, w.surname, w.phone_number, p.flight_hours FROM (pilot p INNER JOIN " +
                                                 "worker w on p.jmbg = w.jmbg) WHERE visibility = 1";
            }
            else
            {
                pilotReadCommand.CommandText = "SELECT w.jmbg, w.name, w.surname, w.phone_number, p.flight_hours FROM (pilot p INNER JOIN " +
                                                 "worker w on p.jmbg = w.jmbg) WHERE " +
                                                 "visibility = 1 AND " + 
                                                 "p.jmbg LIKE '%' + @SearchText + '%' OR " +
                                                 "w.name LIKE '%' + @SearchText + '%' OR " +
                                                 "w.surname LIKE '%' + @SearchText + '%' OR " +
                                                 "w.phone_number LIKE '%' + @SearchText + '%' OR " +
                                                 "p.flight_hours LIKE '%' + @SearchText + '%'";

                pilotReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }
            SqlDataReader reader = pilotReadCommand.ExecuteReader();
            DataTable airplaneTable = new DataTable();
            airplaneTable.Load(reader);
            
            this.pilot_DGV.DataSource = airplaneTable;
            pilot_DGV.Columns[0].HeaderCell.Value = "JMBG";
            pilot_DGV.Columns[1].HeaderCell.Value = "Name";
            pilot_DGV.Columns[2].HeaderCell.Value = "Surname";
            pilot_DGV.Columns[3].HeaderCell.Value = "Phone number";
            pilot_DGV.Columns[4].HeaderCell.Value = "Flight hours";
            pilot_DGV.Rows.RemoveAt(pilot_DGV.Rows.Count - 1);

            reader.Close();
        }

        private void load_flight_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addFlightPanel();
        }

        private void load_airplane_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addAirplanePanel();
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

        private void add_pilot_btn_Click(object sender, EventArgs e)
        {
            AddEditPilot addPilot = new AddEditPilot(this, false);
            addPilot.Show();
        }

        private void edit_pilot_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedJMBG != " ")
            {
                AddEditPilot editPilot = new AddEditPilot(this, true);
                editPilot.Show();
            }
            else
            {
                MessageBox.Show("Please, select a pilot.");
            }
            
        }

        private void loadTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fh.addTicketPanel();
        }

        private void del_pilot_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedJMBG != " ")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand pilotReadCommand = new SqlCommand();
                    pilotReadCommand.Connection = this.connection;
                    pilotReadCommand.CommandText = "UPDATE worker SET visibility = @Visibility WHERE jmbg = @ID";
                    pilotReadCommand.Parameters.AddWithValue("ID", this.selectedJMBG);
                    pilotReadCommand.Parameters.AddWithValue("Visibility", 0);


                    int rowAffected = pilotReadCommand.ExecuteNonQuery();

                    pilotReadCommand.CommandText = "UPDATE flight SET visibility = @Visibility WHERE jmbg = @ID";

                    int rowAffected2 = pilotReadCommand.ExecuteNonQuery();

                    pilotReadCommand.CommandText = "SELECT id FROM flight WHERE visibility = 1 AND jmbg = @ID";

                    SqlDataReader reader = pilotReadCommand.ExecuteReader();

                    pilotReadCommand.Parameters.AddWithValue("Flight_id", reader["id"].ToString());

                    pilotReadCommand.CommandText = "UPDATE ticket SET visibility = @Visibility WHERE visibility =  AND flight_dd = @Flight_id";

                    int rowAffected3 = pilotReadCommand.ExecuteNonQuery();

                    if (rowAffected > 0 && rowAffected2 > 0 && rowAffected3 > 0)
                    {
                        MessageBox.Show("Pilot deleted!");
                        this.selectedJMBG = " ";
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting pilot!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No pilot selected!");
            }
        }
    }
}
