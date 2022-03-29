using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class FormHome : Form
    {
        Form currentForm = null; 
        public FormHome()
        {
            InitializeComponent();
            FormFlights f = new FormFlights(this);
            addPanel(f);
        }

        public void addPanel(Form f)
        {
            if(this.panel.Controls.Count > 0)
            {
                this.panel.Controls.Remove(this.currentForm);
                if(this.currentForm != null)
                {
                    this.currentForm.Close();
                }
            }

            Form contentForm = f;
            contentForm.TopLevel = false;
            contentForm.Dock = DockStyle.Fill;
            this.currentForm = f;
            this.panel.Controls.Add(contentForm);
            this.Size = f.Size;
            contentForm.Show();
        }

        public void addFlightPanel()
        {
            FormFlights flight_form = new FormFlights(this);
            addPanel(flight_form);
        }
        
        public void addAirplanePanel()
        {
            FormAirplane airplane_form = new FormAirplane(this);
            addPanel(airplane_form);
        }

        public void addRoutePanel()
        {
            FormRoute route_form = new FormRoute(this);
            addPanel(route_form);
        }

        public void addCityPanel()
        {
            FormCity city_form = new FormCity(this);
            addPanel(city_form);
        }

        public void adddManagerPanel()
        {
            FormManager manager_form = new FormManager(this);
            addPanel(manager_form);
        }



        public void addPilotPanel()
        {
            FormPilot pilot_form = new FormPilot(this);
            addPanel(pilot_form);
        }

        public void addTicketPanel()
        {
            FormTicket ticket_form = new FormTicket(this);
            addPanel(ticket_form);
        }
    }
}
