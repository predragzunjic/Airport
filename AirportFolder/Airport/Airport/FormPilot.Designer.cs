namespace Airport
{
    partial class FormPilot
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
            this.del_pilot_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.edit_pilot_btn = new System.Windows.Forms.Button();
            this.add_pilot_btn = new System.Windows.Forms.Button();
            this.airplane_menu_strip = new System.Windows.Forms.MenuStrip();
            this.options_item_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_flight_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_airplane_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_route_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_city_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_manager_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.pilot_lbl = new System.Windows.Forms.Label();
            this.pilot_DGV = new System.Windows.Forms.DataGridView();
            this.airplane_menu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilot_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // del_pilot_btn
            // 
            this.del_pilot_btn.Location = new System.Drawing.Point(326, 58);
            this.del_pilot_btn.Name = "del_pilot_btn";
            this.del_pilot_btn.Size = new System.Drawing.Size(130, 35);
            this.del_pilot_btn.TabIndex = 30;
            this.del_pilot_btn.Text = "Delete a pilot";
            this.del_pilot_btn.UseVisualStyleBackColor = true;
            this.del_pilot_btn.Click += new System.EventHandler(this.del_pilot_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(32, 165);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(373, 22);
            this.search_textbox.TabIndex = 32;
            // 
            // edit_pilot_btn
            // 
            this.edit_pilot_btn.Location = new System.Drawing.Point(180, 58);
            this.edit_pilot_btn.Name = "edit_pilot_btn";
            this.edit_pilot_btn.Size = new System.Drawing.Size(130, 35);
            this.edit_pilot_btn.TabIndex = 31;
            this.edit_pilot_btn.Text = "Edit a pilot";
            this.edit_pilot_btn.UseVisualStyleBackColor = true;
            this.edit_pilot_btn.Click += new System.EventHandler(this.edit_pilot_btn_Click);
            // 
            // add_pilot_btn
            // 
            this.add_pilot_btn.Location = new System.Drawing.Point(32, 58);
            this.add_pilot_btn.Name = "add_pilot_btn";
            this.add_pilot_btn.Size = new System.Drawing.Size(130, 35);
            this.add_pilot_btn.TabIndex = 29;
            this.add_pilot_btn.Text = "Add a pilot";
            this.add_pilot_btn.UseVisualStyleBackColor = true;
            this.add_pilot_btn.Click += new System.EventHandler(this.add_pilot_btn_Click);
            // 
            // airplane_menu_strip
            // 
            this.airplane_menu_strip.Dock = System.Windows.Forms.DockStyle.None;
            this.airplane_menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.airplane_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_item_TSM,
            this.reports_item_airplane_TSM});
            this.airplane_menu_strip.Location = new System.Drawing.Point(16, 11);
            this.airplane_menu_strip.Name = "airplane_menu_strip";
            this.airplane_menu_strip.Size = new System.Drawing.Size(157, 28);
            this.airplane_menu_strip.TabIndex = 28;
            this.airplane_menu_strip.Text = "menuStrip1";
            // 
            // options_item_TSM
            // 
            this.options_item_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_flight_options_TSM,
            this.load_airplane_options_TSM,
            this.load_route_options_TSM,
            this.load_city_options_TSM,
            this.load_manager_options_TSM,
            this.loadTicketsToolStripMenuItem});
            this.options_item_TSM.Name = "options_item_TSM";
            this.options_item_TSM.Size = new System.Drawing.Size(75, 24);
            this.options_item_TSM.Text = "Options";
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
            // pilot_lbl
            // 
            this.pilot_lbl.AutoSize = true;
            this.pilot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilot_lbl.Location = new System.Drawing.Point(327, 107);
            this.pilot_lbl.Name = "pilot_lbl";
            this.pilot_lbl.Size = new System.Drawing.Size(120, 44);
            this.pilot_lbl.TabIndex = 27;
            this.pilot_lbl.Text = "Pilots";
            // 
            // pilot_DGV
            // 
            this.pilot_DGV.AllowUserToAddRows = false;
            this.pilot_DGV.AllowUserToDeleteRows = false;
            this.pilot_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pilot_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilot_DGV.Location = new System.Drawing.Point(32, 197);
            this.pilot_DGV.Name = "pilot_DGV";
            this.pilot_DGV.ReadOnly = true;
            this.pilot_DGV.RowHeadersWidth = 51;
            this.pilot_DGV.RowTemplate.Height = 24;
            this.pilot_DGV.Size = new System.Drawing.Size(753, 243);
            this.pilot_DGV.TabIndex = 26;
            this.pilot_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilot_DGV_CellClick);
            // 
            // FormPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 497);
            this.Controls.Add(this.del_pilot_btn);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.edit_pilot_btn);
            this.Controls.Add(this.add_pilot_btn);
            this.Controls.Add(this.airplane_menu_strip);
            this.Controls.Add(this.pilot_lbl);
            this.Controls.Add(this.pilot_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPilot";
            this.Text = "FormPilot";
            this.airplane_menu_strip.ResumeLayout(false);
            this.airplane_menu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilot_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_pilot_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button edit_pilot_btn;
        private System.Windows.Forms.Button add_pilot_btn;
        private System.Windows.Forms.MenuStrip airplane_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem options_item_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_flight_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_airplane_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_route_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_city_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem reports_item_airplane_TSM;
        private System.Windows.Forms.Label pilot_lbl;
        private System.Windows.Forms.DataGridView pilot_DGV;
        private System.Windows.Forms.ToolStripMenuItem load_manager_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
    }
}