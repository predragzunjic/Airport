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
    public partial class FormRoute : Form
    {
        private SqlConnection connection;
        FormHome fh;
        String selectedCurrentCityId;
        String selectedDestinationId;

        public FormRoute(FormHome fh)
        {
            InitializeComponent();

            this.fh = fh;
            this.route_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.route_DGV.CellClick += route_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;
            this.selectedCurrentCityId = " ";
            this.selectedDestinationId = " ";

            InitializeConnection();
            InitializeData(null);

            route_DGV.Rows.RemoveAt(route_DGV.Rows.Count - 1);
        }

        public SqlConnection Connection
        {
            get { return this.connection; }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            this.InitializeData(search_textbox.Text);
        }

        private void route_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.route_DGV.Rows[e.RowIndex];
                String id1 = Convert.ToString(tableRow.Cells[0].Value);
                String id2 = Convert.ToString(tableRow.Cells[1].Value);
                this.selectedCurrentCityId = id1;
                this.selectedDestinationId = id2;

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
            SqlCommand routeReadCommand = new SqlCommand();
            routeReadCommand.Connection = this.connection;

            if (string.IsNullOrEmpty(searchText))
            {
                routeReadCommand.CommandText = "SELECT current_city, destination FROM route WHERE visibility = 1";
            }
            else
            {
                routeReadCommand.CommandText = "SELECT * FROM route WHERE " +
                                                    "visibility = 1 AND " + 
                                                    "current_city LIKE '%' + @SearchText + '%' OR " +
                                                    "destination LIKE '%' + @SearchText + '%'";

                routeReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }
            SqlDataReader reader = routeReadCommand.ExecuteReader();
            DataTable routeTable = new DataTable();
            routeTable.Load(reader);
            this.route_DGV.DataSource = routeTable;
            route_DGV.Columns[0].HeaderCell.Value = "Current city";
            route_DGV.Columns[1].HeaderCell.Value = "Destination";
            route_DGV.Rows.RemoveAt(route_DGV.Rows.Count - 1);

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

        private void add_route_btn_Click(object sender, EventArgs e)
        {
            AddRoute ar = new AddRoute(this);
            ar.Show();
        }

        private void loadTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fh.addTicketPanel();
        }

        private void del_route_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedCurrentCityId != " " && this.selectedDestinationId != " ")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand routeReadCommand = new SqlCommand();
                    routeReadCommand.Connection = this.connection;
                    routeReadCommand.CommandText = "UPDATE route SET visibility = @Visibility WHERE current_city = @ID1 AND destination = @ID2";
                    routeReadCommand.Parameters.AddWithValue("ID1", this.selectedCurrentCityId);
                    routeReadCommand.Parameters.AddWithValue("ID2", this.selectedDestinationId);
                    routeReadCommand.Parameters.AddWithValue("Visibility", 0);


                    int rowAffected = routeReadCommand.ExecuteNonQuery();

                    routeReadCommand.CommandText = "UPDATE flight SET visibility = @Visibility WHERE current_city = @ID1 AND destination = @ID2";

                    int rowAffected2 = routeReadCommand.ExecuteNonQuery();

                    if (rowAffected > 0 && rowAffected2 > 0)
                    {
                        MessageBox.Show("Route deleted!");
                        this.selectedCurrentCityId = " ";
                        this.selectedDestinationId = " ";
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting route!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No route selected!");
            }
        }
    }
}
