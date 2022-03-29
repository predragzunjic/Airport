namespace Airport
{
    partial class FormRoute
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
            this.route_DGV = new System.Windows.Forms.DataGridView();
            this.airplane_menu_strip = new System.Windows.Forms.MenuStrip();
            this.options_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_flight_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_airplane_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_city_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_manager_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_pilot_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.del_route_btn = new System.Windows.Forms.Button();
            this.add_route_btn = new System.Windows.Forms.Button();
            this.route_lbl = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.route_DGV)).BeginInit();
            this.airplane_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // route_DGV
            // 
            this.route_DGV.AllowUserToAddRows = false;
            this.route_DGV.AllowUserToDeleteRows = false;
            this.route_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.route_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.route_DGV.Location = new System.Drawing.Point(57, 165);
            this.route_DGV.Name = "route_DGV";
            this.route_DGV.ReadOnly = true;
            this.route_DGV.RowHeadersWidth = 51;
            this.route_DGV.RowTemplate.Height = 24;
            this.route_DGV.Size = new System.Drawing.Size(272, 292);
            this.route_DGV.TabIndex = 13;
            this.route_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.route_DGV_CellClick);
            // 
            // airplane_menu_strip
            // 
            this.airplane_menu_strip.Dock = System.Windows.Forms.DockStyle.None;
            this.airplane_menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.airplane_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_item_airplane_TSM,
            this.reports_item_airplane_TSM});
            this.airplane_menu_strip.Location = new System.Drawing.Point(9, 9);
            this.airplane_menu_strip.Name = "airplane_menu_strip";
            this.airplane_menu_strip.Size = new System.Drawing.Size(157, 28);
            this.airplane_menu_strip.TabIndex = 15;
            this.airplane_menu_strip.Text = "menuStrip1";
            // 
            // options_item_airplane_TSM
            // 
            this.options_item_airplane_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_flight_options_TSM,
            this.load_airplane_options_TSM,
            this.load_city_options_TSM,
            this.load_manager_options_TSM,
            this.load_pilot_options_TSM,
            this.loadTicketsToolStripMenuItem});
            this.options_item_airplane_TSM.Name = "options_item_airplane_TSM";
            this.options_item_airplane_TSM.Size = new System.Drawing.Size(75, 24);
            this.options_item_airplane_TSM.Text = "Options";
            // 
            // load_flight_options_TSM
            // 
            this.load_flight_options_TSM.Name = "load_flight_options_TSM";
            this.load_flight_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_flight_options_TSM.Text = "Load flights";
            this.load_flight_options_TSM.Click += new System.EventHandler(this.load_flight_options_TSM_Click);
            // 
            // load_airplane_options_TSM
            // 
            this.load_airplane_options_TSM.Name = "load_airplane_options_TSM";
            this.load_airplane_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_airplane_options_TSM.Text = "Load airplanes";
            this.load_airplane_options_TSM.Click += new System.EventHandler(this.load_airplane_options_TSM_Click);
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
            // reports_item_airplane_TSM
            // 
            this.reports_item_airplane_TSM.Name = "reports_item_airplane_TSM";
            this.reports_item_airplane_TSM.Size = new System.Drawing.Size(74, 24);
            this.reports_item_airplane_TSM.Text = "Reports";
            // 
            // del_route_btn
            // 
            this.del_route_btn.Location = new System.Drawing.Point(135, 51);
            this.del_route_btn.Name = "del_route_btn";
            this.del_route_btn.Size = new System.Drawing.Size(120, 30);
            this.del_route_btn.TabIndex = 19;
            this.del_route_btn.Text = "Delete a route";
            this.del_route_btn.UseVisualStyleBackColor = true;
            this.del_route_btn.Click += new System.EventHandler(this.del_route_btn_Click);
            // 
            // add_route_btn
            // 
            this.add_route_btn.Location = new System.Drawing.Point(9, 51);
            this.add_route_btn.Name = "add_route_btn";
            this.add_route_btn.Size = new System.Drawing.Size(120, 30);
            this.add_route_btn.TabIndex = 18;
            this.add_route_btn.Text = "Add a route";
            this.add_route_btn.UseVisualStyleBackColor = true;
            this.add_route_btn.Click += new System.EventHandler(this.add_route_btn_Click);
            // 
            // route_lbl
            // 
            this.route_lbl.AutoSize = true;
            this.route_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route_lbl.Location = new System.Drawing.Point(144, 93);
            this.route_lbl.Name = "route_lbl";
            this.route_lbl.Size = new System.Drawing.Size(111, 32);
            this.route_lbl.TabIndex = 21;
            this.route_lbl.Text = "Routes";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(9, 137);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(205, 22);
            this.search_textbox.TabIndex = 22;
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 479);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.route_lbl);
            this.Controls.Add(this.del_route_btn);
            this.Controls.Add(this.add_route_btn);
            this.Controls.Add(this.airplane_menu_strip);
            this.Controls.Add(this.route_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoute";
            this.Text = "FormRoute";
            ((System.ComponentModel.ISupportInitialize)(this.route_DGV)).EndInit();
            this.airplane_menu_strip.ResumeLayout(false);
            this.airplane_menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView route_DGV;
        private System.Windows.Forms.MenuStrip airplane_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem options_item_airplane_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_flight_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_airplane_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem reports_item_airplane_TSM;
        private System.Windows.Forms.Button del_route_btn;
        private System.Windows.Forms.Button add_route_btn;
        private System.Windows.Forms.Label route_lbl;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.ToolStripMenuItem load_city_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_manager_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_pilot_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
    }
}