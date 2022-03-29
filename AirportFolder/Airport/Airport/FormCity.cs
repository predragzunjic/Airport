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
    public partial class FormCity : Form
    {
        private SqlConnection connection;
        FormHome fh;
        int selectedFlightId;

        public FormCity(FormHome fh)
        {
            InitializeComponent();

            this.fh = fh;
            this.city_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.city_DGV.CellClick += city_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;

            InitializeConnection();
            InitializeData(null);

            city_DGV.Rows.RemoveAt(city_DGV.Rows.Count - 1);
        }

        public SqlConnection Connection
        {
            get { return this.connection; }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            this.InitializeData(search_textbox.Text);
        }

        private void city_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.city_DGV.Rows[e.RowIndex];
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
            SqlCommand cityReadCommand = new SqlCommand();
            cityReadCommand.Connection = this.connection;

            if (string.IsNullOrEmpty(searchText))
            {
                cityReadCommand.CommandText = "SELECT city_id, name FROM city WHERE visibility = 1";
            }
            else
            {
                cityReadCommand.CommandText = "SELECT * FROM city WHERE " +
                                                    "visibility = 1 AND " +
                                                    "city_id LIKE '%' + @SearchText + '%' OR " +
                                                    "name LIKE '%' + @SearchText + '%'";

                cityReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }
            SqlDataReader reader = cityReadCommand.ExecuteReader();
            DataTable routeTable = new DataTable();
            routeTable.Load(reader);
            this.city_DGV.DataSource = routeTable;
            city_DGV.Columns[0].HeaderCell.Value = "City ID";
            city_DGV.Columns[1].HeaderCell.Value = "City name";
            city_DGV.Rows.RemoveAt(city_DGV.Rows.Count - 1);


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

        private void load_manager_options_TSM_Click(object sender, EventArgs e)
        {
            fh.adddManagerPanel();
        }

        private void load_pilot_options_TSM_Click(object sender, EventArgs e)
        {
            fh.addPilotPanel();
        }

        private void add_city_btn_Click(object sender, EventArgs e)
        {
            AddCity editCity = new AddCity(this);
            editCity.Show();
        }

        private void loadTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fh.addTicketPanel();
        }
    }
}
