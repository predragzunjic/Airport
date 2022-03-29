namespace Airport
{
    partial class FormFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.del_flight_btn = new System.Windows.Forms.Button();
            this.flight_DGV = new System.Windows.Forms.DataGridView();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.edit_flight_btn = new System.Windows.Forms.Button();
            this.flight_lbl = new System.Windows.Forms.Label();
            this.add_flight_btn = new System.Windows.Forms.Button();
            this.reports_item_flight_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPilotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.options_item_flight_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_airplane_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_route_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_city_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_manager_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_pilot_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flight_menu_strip = new System.Windows.Forms.MenuStrip();
            this.date_search_cbox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reserve_ticket_btn = new System.Windows.Forms.Button();
            this.listOfAirplanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.flight_DGV)).BeginInit();
            this.flight_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // del_flight_btn
            // 
            this.del_flight_btn.Location = new System.Drawing.Point(305, 50);
            this.del_flight_btn.Name = "del_flight_btn";
            this.del_flight_btn.Size = new System.Drawing.Size(120, 35);
            this.del_flight_btn.TabIndex = 9;
            this.del_flight_btn.Text = "Delete a flight";
            this.del_flight_btn.UseVisualStyleBackColor = true;
            this.del_flight_btn.Click += new System.EventHandler(this.del_flight_btn_Click);
            // 
            // flight_DGV
            // 
            this.flight_DGV.AllowUserToAddRows = false;
            this.flight_DGV.AllowUserToDeleteRows = false;
            this.flight_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.flight_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flight_DGV.Location = new System.Drawing.Point(31, 186);
            this.flight_DGV.Name = "flight_DGV";
            this.flight_DGV.ReadOnly = true;
            this.flight_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.flight_DGV.RowHeadersWidth = 51;
            this.flight_DGV.RowTemplate.Height = 24;
            this.flight_DGV.Size = new System.Drawing.Size(1044, 303);
            this.flight_DGV.TabIndex = 11;
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(31, 149);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(373, 22);
            this.search_textbox.TabIndex = 13;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // edit_flight_btn
            // 
            this.edit_flight_btn.Location = new System.Drawing.Point(167, 50);
            this.edit_flight_btn.Name = "edit_flight_btn";
            this.edit_flight_btn.Size = new System.Drawing.Size(120, 35);
            this.edit_flight_btn.TabIndex = 10;
            this.edit_flight_btn.Text = "Edit a flight";
            this.edit_flight_btn.UseVisualStyleBackColor = true;
            this.edit_flight_btn.Click += new System.EventHandler(this.edit_flight_btn_Click);
            // 
            // flight_lbl
            // 
            this.flight_lbl.AutoSize = true;
            this.flight_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight_lbl.Location = new System.Drawing.Point(470, 104);
            this.flight_lbl.Name = "flight_lbl";
            this.flight_lbl.Size = new System.Drawing.Size(140, 44);
            this.flight_lbl.TabIndex = 12;
            this.flight_lbl.Text = "Flights";
            // 
            // add_flight_btn
            // 
            this.add_flight_btn.Location = new System.Drawing.Point(31, 50);
            this.add_flight_btn.Name = "add_flight_btn";
            this.add_flight_btn.Size = new System.Drawing.Size(120, 35);
            this.add_flight_btn.TabIndex = 8;
            this.add_flight_btn.Text = "Add a flight";
            this.add_flight_btn.UseVisualStyleBackColor = true;
            this.add_flight_btn.Click += new System.EventHandler(this.add_flight_btn_Click);
            // 
            // reports_item_flight_TSM
            // 
            this.reports_item_flight_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfPilotsToolStripMenuItem,
            this.listOfAirplanesToolStripMenuItem,
            this.listOfFlightsToolStripMenuItem});
            this.reports_item_flight_TSM.Name = "reports_item_flight_TSM";
            this.reports_item_flight_TSM.Size = new System.Drawing.Size(74, 24);
            this.reports_item_flight_TSM.Text = "Reports";
            // 
            // listOfPilotsToolStripMenuItem
            // 
            this.listOfPilotsToolStripMenuItem.Name = "listOfPilotsToolStripMenuItem";
            this.listOfPilotsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listOfPilotsToolStripMenuItem.Text = "List of pilots";
            this.listOfPilotsToolStripMenuItem.Click += new System.EventHandler(this.listOfPilotsToolStripMenuItem_Click);
            // 
            // options_item_flight_TSM
            // 
            this.options_item_flight_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_airplane_options_TSM,
            this.load_route_options_TSM,
            this.load_city_options_TSM,
            this.load_manager_options_TSM,
            this.load_pilot_options_TSM,
            this.loadTicketsToolStripMenuItem});
            this.options_item_flight_TSM.Name = "options_item_flight_TSM";
            this.options_item_flight_TSM.Size = new System.Drawing.Size(75, 24);
            this.options_item_flight_TSM.Text = "Options";
            // 
            // load_airplane_options_TSM
            // 
            this.load_airplane_options_TSM.Name = "load_airplane_options_TSM";
            this.load_airplane_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_airplane_options_TSM.Text = "Load airplanes";
            this.load_airplane_options_TSM.Click += new System.EventHandler(this.load_airplanes_options_TSM_Click);
            // 
            // load_route_options_TSM
            // 
            this.load_route_options_TSM.Name = "load_route_options_TSM";
            this.load_route_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_route_options_TSM.Text = "Load routes";
            this.load_route_options_TSM.Click += new System.EventHandler(this.load_route_options_TSM_Click);
            // 
            // load_city_options_TSM
            // 
            this.load_city_options_TSM.Name = "load_city_options_TSM";
            this.load_city_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_city_options_TSM.Text = "Load cities";
            this.load_city_options_TSM.Click += new System.EventHandler(this.load_city_options_TSM_Click);
            // 
            // load_manager_options_TSM
            // 
            this.load_manager_options_TSM.Name = "load_manager_options_TSM";
            this.load_manager_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_manager_options_TSM.Text = "Load managers";
            this.load_manager_options_TSM.Click += new System.EventHandler(this.load_manager_options_TSM_Click);
            // 
            // load_pilot_options_TSM
            // 
            this.load_pilot_options_TSM.Name = "load_pilot_options_TSM";
            this.load_pilot_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_pilot_options_TSM.Text = "Load pilots";
            this.load_pilot_options_TSM.Click += new System.EventHandler(this.load_pilot_options_TSM_Click);
            // 
            // loadTicketsToolStripMenuItem
            // 
            this.loadTicketsToolStripMenuItem.Name = "loadTicketsToolStripMenuItem";
            this.loadTicketsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.loadTicketsToolStripMenuItem.Text = "Load tickets";
            this.loadTicketsToolStripMenuItem.Click += new System.EventHandler(this.loadTicketsToolStripMenuItem_Click);
            // 
            // flight_menu_strip
            // 
            this.flight_menu_strip.Dock = System.Windows.Forms.DockStyle.None;
            this.flight_menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.flight_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_item_flight_TSM,
            this.reports_item_flight_TSM});
            this.flight_menu_strip.Location = new System.Drawing.Point(9, 9);
            this.flight_menu_strip.Name = "flight_menu_strip";
            this.flight_menu_strip.Size = new System.Drawing.Size(307, 28);
            this.flight_menu_strip.TabIndex = 7;
            this.flight_menu_strip.Text = "menuStrip1";
            // 
            // date_search_cbox
            // 
            this.date_search_cbox.AutoSize = true;
            this.date_search_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_search_cbox.Location = new System.Drawing.Point(422, 151);
            this.date_search_cbox.Name = "date_search_cbox";
            this.date_search_cbox.Size = new System.Drawing.Size(152, 24);
            this.date_search_cbox.TabIndex = 14;
            this.date_search_cbox.Text = "Search by dates";
            this.date_search_cbox.UseVisualStyleBackColor = true;
            this.date_search_cbox.CheckedChanged += new System.EventHandler(this.date_search_cbox_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(590, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(812, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // reserve_ticket_btn
            // 
            this.reserve_ticket_btn.Location = new System.Drawing.Point(442, 50);
            this.reserve_ticket_btn.Name = "reserve_ticket_btn";
            this.reserve_ticket_btn.Size = new System.Drawing.Size(120, 35);
            this.reserve_ticket_btn.TabIndex = 17;
            this.reserve_ticket_btn.Text = "Reserve a ticket";
            this.reserve_ticket_btn.UseVisualStyleBackColor = true;
            this.reserve_ticket_btn.Click += new System.EventHandler(this.reserve_ticket_btn_Click);
            // 
            // listOfAirplanesToolStripMenuItem
            // 
            this.listOfAirplanesToolStripMenuItem.Name = "listOfAirplanesToolStripMenuItem";
            this.listOfAirplanesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listOfAirplanesToolStripMenuItem.Text = "List of airplanes";
            this.listOfAirplanesToolStripMenuItem.Click += new System.EventHandler(this.listOfAirplanesToolStripMenuItem_Click);
            // 
            // listOfFlightsToolStripMenuItem
            // 
            this.listOfFlightsToolStripMenuItem.Name = "listOfFlightsToolStripMenuItem";
            this.listOfFlightsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listOfFlightsToolStripMenuItem.Text = "List of flights";
            this.listOfFlightsToolStripMenuItem.Click += new System.EventHandler(this.listOfFlightsToolStripMenuItem_Click);
            // 
            // FormFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 502);
            this.Controls.Add(this.reserve_ticket_btn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date_search_cbox);
            this.Controls.Add(this.del_flight_btn);
            this.Controls.Add(this.flight_DGV);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.edit_flight_btn);
            this.Controls.Add(this.flight_lbl);
            this.Controls.Add(this.add_flight_btn);
            this.Controls.Add(this.flight_menu_strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFlights";
            this.Text = "FormFlights";
            ((System.ComponentModel.ISupportInitialize)(this.flight_DGV)).EndInit();
            this.flight_menu_strip.ResumeLayout(false);
            this.flight_menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_flight_btn;
        private System.Windows.Forms.DataGridView flight_DGV;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button edit_flight_btn;
        private System.Windows.Forms.Label flight_lbl;
        private System.Windows.Forms.Button add_flight_btn;
        private System.Windows.Forms.ToolStripMenuItem reports_item_flight_TSM;
        private System.Windows.Forms.ToolStripMenuItem options_item_flight_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_airplane_options_TSM;
        private System.Windows.Forms.MenuStrip flight_menu_strip;
        private System.Windows.Forms.CheckBox date_search_cbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStripMenuItem load_route_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_city_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_manager_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_pilot_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
        private System.Windows.Forms.Button reserve_ticket_btn;
        private System.Windows.Forms.ToolStripMenuItem listOfPilotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAirplanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfFlightsToolStripMenuItem;
    }
}