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
    public partial class FormManager : Form
    {
        private SqlConnection connection;
        FormHome fh;
        String selectedJMBG = " ";

        public FormManager(FormHome fh)
        {
            InitializeComponent();

            this.fh = fh;
            this.manager_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.manager_DGV.CellClick += manager_DGV_CellClick;
            this.search_textbox.TextChanged += search_textbox_TextChanged;

            InitializeConnection();
            InitializeData(null);

            if (manager_DGV.Rows.Count > 0)
            {
                manager_DGV.Rows.RemoveAt(manager_DGV.Rows.Count - 1);

            }
            
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

        private void manager_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.manager_DGV.Rows[e.RowIndex];
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
            SqlCommand managerReadCommand = new SqlCommand();
            managerReadCommand.Connection = this.connection;

            if (string.IsNullOrEmpty(searchText))
            {
                managerReadCommand.CommandText = "SELECT m.jmbg, w.name, w.surname, w.phone_number, m.qualification FROM(manager as m INNER JOIN " +
                                                 "worker as w on m.jmbg = w.jmbg INNER JOIN sss as s on m.qualification = s.qualification) " +
                                                 "WHERE w.visibility = 1";


            }
            else
            {
                managerReadCommand.CommandText = "SELECT m.jmbg, w.name, w.surname, w.phone_number, m.qualification FROM (manager m INNER JOIN " +
                                                 "worker w on m.jmbg = w.jmbg) WHERE " +
                                                 "w.visibility = 1 AND "+
                                                 "m.jmbg LIKE '%' + @SearchText + '%' OR " +
                                                 "w.name LIKE '%' + @SearchText + '%' OR " +
                                                 "w.surname LIKE '%' + @SearchText + '%' OR " +
                                                 "w.phone_number LIKE '%' + @SearchText + '%' OR " +
                                                 "m.qualification LIKE '%' + @SearchText + '%'";


                managerReadCommand.Parameters.AddWithValue("SearchText", this.search_textbox.Text);
            }
            SqlDataReader reader = managerReadCommand.ExecuteReader();
       
            DataTable managerTable = new DataTable();
            MessageBox.Show(managerTable.Rows.Count.ToString());
            managerTable.Load(reader);

            this.manager_DGV.DataSource = managerTable;

            //manager_DGV.Columns[0].HeaderCell.Value = "JMBG";
            //manager_DGV.Columns[1].HeaderCell.Value = "Name";
            //manager_DGV.Columns[2].HeaderCell.Value = "Surname";
            //manager_DGV.Columns[3].HeaderCell.Value = "Phone number";
            //manager_DGV.Columns[4].HeaderCell.Value = "Qualification";
            if (manager_DGV.Rows.Count > 0)
            {
                manager_DGV.Rows.RemoveAt(manager_DGV.Rows.Count - 1);
            }
            


            reader.Close();
        }

        private void edit_airplane_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedJMBG == " ")
            {
                MessageBox.Show("Please, select a manager.");
                return;
            }
            else
            {
                AddEditManager aem = new AddEditManager(this, true);
                aem.Show();
            }
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

        private void add_ssb_btn_Click(object sender, EventArgs e)
        {
            AddSSB addS = new AddSSB(this);
            addS.Show();
        }

        private void add_manager_btn_Click(object sender, EventArgs e)
        {
            AddEditManager aem = new AddEditManager(this, false);
            aem.Show();
        }

        private void loadTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fh.addTicketPanel();
        }

        private void del_manager_btn_Click(object sender, EventArgs e)
        {
            if (this.selectedJMBG != " ")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand managerReadCommand = new SqlCommand();
                    managerReadCommand.Connection = this.connection;
                    managerReadCommand.CommandText = "UPDATE worker SET visibility = @Visibility WHERE id = @ID";
                    managerReadCommand.Parameters.AddWithValue("ID", this.selectedJMBG);
                    managerReadCommand.Parameters.AddWithValue("Visibility", 0);


                    int rowAffected = managerReadCommand.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Manager deleted!");
                        this.selectedJMBG = " ";
                        this.InitializeData(null);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting manager!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No manager selected!");
            }
        }
    }
}
