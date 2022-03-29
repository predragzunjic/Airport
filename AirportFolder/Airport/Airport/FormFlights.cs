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
    public partial class FormFlights : Form
    {
        private SqlConnection connection;
        private int selectedFlightId = -1;
        FormHome fh;
        public FormFlights(FormHome fh)
        {
            InitializeComponent();

            this.fh = fh;
            this.flight_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.flight_DGV.CellClick += flights_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;


            Controls.Add(date_search_cbox);

            InitializeConnection();
            InitializeData(null);
        }

        public SqlConnection Connection
        {
            get { return this.connection; }
        }

        public int SelectedFlightId
        {
            get { return this.selectedFlightId; }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            this.InitializeData(search_textbox.Text);
        }

        private void flights_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.flight_DGV.Rows[e.RowIndex];
                int id = Convert.ToInt32(tableRow.Cells[0].Value);
                this.selectedFlightId = id;
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
            SqlCommand flightReadCommand = new SqlCommand();
            flightReadCommand.Connection = this.connection;

            if (date_search_cbox.Checked)
            {
                flightReadCommand.CommandText = "SELECT f.id, w.name, w.surname, am.name, a.registration, f.flight_date, f.current_city, f.destination, f.reserved_cards " +
                                                "FROM(airplane_model am INNER JOIN airplane a on am.name = a.name " +
                                                "INNER JOIN flight f on a.registration = f.registration and a.name = f.name " +
                                                "INNER JOIN worker w on f.jmbg = w.jmbg " +
                                                "INNER JOIN route r on f.current_city = r.current_city and f.destination = r.destination) WHERE " +
                                                "(w.name LIKE '%' + @SearchText + '%' OR " +
                                                "w.surname LIKE '%' + @SearchText + '%' OR " +
                                                "am.name LIKE '%' + @SearchText + '%' OR " +
                                                "r.current_city LIKE '%' + @SearchText + '%' OR " +
                                                "r.destination LIKE '%' + @SearchText + '%' OR " +
                                                "a.registration LIKE '%' + @SearchText + '%') AND " +
                                                "(f.flight_date >= @DateTimePicker1 AND " +
                                                "f.flight_date <= @DateTimePicker2) AND " +
                                                "f.visibility = 1";

                DateTime datum1 = dateTimePicker1.Value.Date;
                DateTime datum2 = dateTimePicker2.Value.Date;

                flightReadCommand.Parameters.AddWithValue("DateTimePicker1", datum1.ToString());
                flightReadCommand.Parameters.AddWithValue("DateTimePicker2", datum2.ToString());

                flightReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }
            else if (string.IsNullOrEmpty(searchText))
            {
                flightReadCommand.CommandText = "SELECT f.id, w.name, w.surname, am.name, a.registration, f.flight_date, f.current_city, f.destination, f.reserved_cards " +   
                                                "FROM(airplane_model am INNER JOIN airplane a on am.name = a.name " +
                                                "INNER JOIN flight f on a.registration = f.registration and a.name = f.name " +
                                                "INNER JOIN worker w on f.jmbg = w.jmbg " +
                                                "INNER JOIN route r on f.current_city = r.current_city and f.destination = r.destination) " +
                                                "WHERE f.visibility = 1";
            }
            else
            {
                flightReadCommand.CommandText = "SELECT f.id, w.name, w.surname, am.name, a.registration, f.flight_date, f.current_city, f.destination, f.reserved_cards " +
                                                "FROM(airplane_model am INNER JOIN airplane a on am.name = a.name " +
                                                "INNER JOIN flight f on a.registration = f.registration and a.name = f.name " +
                                                "INNER JOIN worker w on f.jmbg = w.jmbg " +
                                                "INNER JOIN route r on f.current_city = r.current_city and f.destination = r.destination) WHERE " +
                                                "w.name LIKE '%' + @SearchText + '%' OR " +
                                                "w.surname LIKE '%' + @SearchText + '%' OR " +
                                                "am.name LIKE '%' + @SearchText + '%' OR " +
                                                "r.current_city LIKE '%' + @SearchText + '%' OR " +
                                                "a.registration LIKE '% + @SearchText + '%' OR " +
                                                "r.destination LIKE '%' + @SearchText + '%' AND " + 
                                                "f.visibility = 1";

                flightReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }

            
            SqlDataReader reader = flightReadCommand.ExecuteReader();
            DataTable flightTable = new DataTable();
            flightTable.Load(reader);
            this.flight_DGV.DataSource = flightTable;
            flight_DGV.Columns[0].HeaderCell.Value = "Flight id";
            flight_DGV.Columns[1].HeaderCell.Value = "Name";
            flight_DGV.Columns[2].HeaderCell.Value = "Surname";
            flight_DGV.Columns[3].HeaderCell.Value = "Airplane model";
            flight_DGV.Columns[4].HeaderCell.Value = "Airplane reg.";
            flight_DGV.Columns[5].HeaderCell.Value = "Flight date";
            flight_DGV.Columns[6].HeaderCell.Value = "Current city";
            flight_DGV.Columns[7].HeaderCell.Value = "Destination";
            if(flight_DGV.Rows.Count != 0) {
                flight_DGV.Rows.RemoveAt(flight_DGV.Rows.Count - 1);
            }
            

            reader.Close();
        }

        private void load_airplanes_options_TSM_Click(object sender, EventArgs e)
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

        private void load_pilot_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addPilotPanel();
        }

        private void loadTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fh.addTicketPanel();
        }

        private void reserve_ticket_btn_Click(object sender, EventArgs e)
        {
            if(this.selectedFlightId == -1)
            {
                MessageBox.Show("Flight was not picked.");
            }
            else
            {
                AddTicket at = new AddTicket(this, this.selectedFlightId);
                at.Show();
            }
        }

        private void add_flight_btn_Click(object sender, EventArgs e)
        {
            AddEditFlight aef = new AddEditFlight(this, false);
            aef.Show();
        }

        private void edit_flight_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedFlightId != -1)
            {
                AddEditFlight aef = new AddEditFlight(this, true);
                aef.Show();
            }
            else
            {
                MessageBox.Show("You need to pick a flight.");
            }
        }



        private void del_flight_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedFlightId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand flightReadCommand = new SqlCommand();
                    flightReadCommand.Connection = this.connection;
                    flightReadCommand.CommandText = "UPDATE flight SET visibility = @Visibility WHERE id = @ID";
                    flightReadCommand.Parameters.AddWithValue("ID", this.selectedFlightId);
                    flightReadCommand.Parameters.AddWithValue("Visibility", 0);


                    int rowAffected = flightReadCommand.ExecuteNonQuery();
                    flightReadCommand.CommandText = "UPDATE ticket SET visibility = @Visibility WHERE flight_id = @ID";
                    int rowAffected2 = flightReadCommand.ExecuteNonQuery();

                    if (rowAffected > 0 && rowAffected2 > 0) 
                    {
                        MessageBox.Show("Flight deleted!");
                        this.selectedFlightId = -1;
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting flight!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Flight Selected!");
            }
        }

        private void date_search_cbox_CheckedChanged(object sender, EventArgs e)
        {
            InitializeData(null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            InitializeData(null);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            InitializeData(null);
        }

        private void listOfPilotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(ReportType.PilotList);
            fReport.Show();
        }

        private void listOfAirplanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(ReportType.AirplaneList);
            fReport.Show();
        
        }

        private void listOfFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(ReportType.FlightList);
            fReport.Show();
        }
    }
}
