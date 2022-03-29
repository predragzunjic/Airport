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
    public partial class FormTicket : Form
    {
        private SqlConnection connection;
        FormHome fh;
        int selectedId = -1;

        public FormTicket(FormHome fh)
        {
            InitializeComponent();

            this.fh = fh;
            this.ticket_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ticket_DGV.CellClick += ticket_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;

            InitializeConnection();
            InitializeData(null);


        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            this.InitializeData(search_textbox.Text);
        }

        private void ticket_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.ticket_DGV.Rows[e.RowIndex];
                int id = Convert.ToInt32(tableRow.Cells[0].Value);
                this.selectedId = id;
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
            SqlCommand ticketReadCommand = new SqlCommand();
            ticketReadCommand.Connection = this.connection;

            if (string.IsNullOrEmpty(searchText))
            {
                ticketReadCommand.CommandText = "SELECT t.id, c.name, c.surname, f.flight_date, f.name FROM (flight f " +
                                                    "INNER JOIN ticket t ON f.id = t.flight_id INNER JOIN customer c " +
                                                    "ON t.jmbg = c.jmbg) WHERE t.visibility = 1";
            }
            else
            {
                ticketReadCommand.CommandText = "SELECT t.id, c.name, c.surname, f.flight_date, f.name FROM (flight f " +
                                                    "INNER JOIN ticket t ON f.id = t.flight_id INNER JOIN customer c WHERE " +
                                                    "t.visibility = 1 AND " +
                                                    "c.name LIKE '%' + @SearchText + '%' OR " +
                                                    "c.surname LIKE '%' + @SearchText + '%' OR " +
                                                    "f.name LIKE '%' + @SearchText + '%'";
                ticketReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }
            
            SqlDataReader reader = ticketReadCommand.ExecuteReader();
            DataTable airplaneTable = new DataTable();
            airplaneTable.Load(reader);
            this.ticket_DGV.DataSource = airplaneTable;
            //ticket_DGV.Rows.RemoveAt(ticket_DGV.Rows.Count - 1);
            ticket_DGV.Columns[0].HeaderCell.Value = "Ticket id";
            ticket_DGV.Columns[1].HeaderCell.Value = "Name";
            ticket_DGV.Columns[2].HeaderCell.Value = "Surname";
            ticket_DGV.Columns[3].HeaderCell.Value = "Flight date";
            ticket_DGV.Columns[4].HeaderCell.Value = "Airplane model";

            reader.Close();
        }

        

        private void load_manager_options_TSM_Click_1(object sender, EventArgs e)
        {
            fh.adddManagerPanel();
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

        private void load_pilot_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addPilotPanel();
        }

        private void del_ticket_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand flightReadCommand = new SqlCommand();
                    flightReadCommand.Connection = this.connection;
                    flightReadCommand.CommandText = "UPDATE ticket SET visibility = @Visibility WHERE id = @ID";
                    flightReadCommand.Parameters.AddWithValue("ID", this.selectedId);
                    flightReadCommand.Parameters.AddWithValue("Visibility", 0);


                    int rowAffected = flightReadCommand.ExecuteNonQuery();
                    

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Ticket deleted!");
                        this.selectedId = -1;
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting ticket!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No ticket selected!");
            }
        }
    }
}
