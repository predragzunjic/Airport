namespace Airport
{
    partial class FormCity
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
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.city_lbl = new System.Windows.Forms.Label();
            this.add_city_btn = new System.Windows.Forms.Button();
            this.airplane_menu_strip = new System.Windows.Forms.MenuStrip();
            this.options_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_flight_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_airplane_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_route_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_manager_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_pilot_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.city_DGV = new System.Windows.Forms.DataGridView();
            this.airplane_menu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.city_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(9, 127);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(205, 22);
            this.search_textbox.TabIndex = 29;
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lbl.Location = new System.Drawing.Point(132, 92);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(93, 32);
            this.city_lbl.TabIndex = 28;
            this.city_lbl.Text = "Cities";
            // 
            // add_city_btn
            // 
            this.add_city_btn.Location = new System.Drawing.Point(12, 48);
            this.add_city_btn.Name = "add_city_btn";
            this.add_city_btn.Size = new System.Drawing.Size(120, 30);
            this.add_city_btn.TabIndex = 25;
            this.add_city_btn.Text = "Add a city";
            this.add_city_btn.UseVisualStyleBackColor = true;
            this.add_city_btn.Click += new System.EventHandler(this.add_city_btn_Click);
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
            this.airplane_menu_strip.TabIndex = 24;
            this.airplane_menu_strip.Text = "menuStrip1";
            // 
            // options_item_airplane_TSM
            // 
            this.options_item_airplane_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_flight_options_TSM,
            this.load_airplane_options_TSM,
            this.load_route_options_TSM,
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
            this.load_flight_options_TSM.Size = new System.Drawing.Size(189, 26);
            this.load_flight_options_TSM.Text = "Load flights";
            this.load_flight_options_TSM.Click += new System.EventHandler(this.load_flight_options_TSM_Click);
            // 
            // load_airplane_options_TSM
            // 
            this.load_airplane_options_TSM.Name = "load_airplane_options_TSM";
            this.load_airplane_options_TSM.Size = new System.Drawing.Size(189, 26);
            this.load_airplane_options_TSM.Text = "Load airplanes";
            this.load_airplane_options_TSM.Click += new System.EventHandler(this.load_airplane_options_TSM_Click);
            // 
            // load_route_options_TSM
            // 
            this.load_route_options_TSM.Name = "load_route_options_TSM";
            this.load_route_options_TSM.Size = new System.Drawing.Size(189, 26);
            this.load_route_options_TSM.Text = "Load routes";
            this.load_route_options_TSM.Click += new System.EventHandler(this.load_route_options_TSM_Click);
            // 
            // load_manager_options_TSM
            // 
            this.load_manager_options_TSM.Name = "load_manager_options_TSM";
            this.load_manager_options_TSM.Size = new System.Drawing.Size(189, 26);
            this.load_manager_options_TSM.Text = "Load manager";
            this.load_manager_options_TSM.Click += new System.EventHandler(this.load_manager_options_TSM_Click);
            // 
            // load_pilot_options_TSM
            // 
            this.load_pilot_options_TSM.Name = "load_pilot_options_TSM";
            this.load_pilot_options_TSM.Size = new System.Drawing.Size(189, 26);
            this.load_pilot_options_TSM.Text = "Load pilots";
            this.load_pilot_options_TSM.Click += new System.EventHandler(this.load_pilot_options_TSM_Click);
            // 
            // loadTicketsToolStripMenuItem
            // 
            this.loadTicketsToolStripMenuItem.Name = "loadTicketsToolStripMenuItem";
            this.loadTicketsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.loadTicketsToolStripMenuItem.Text = "Load tickets";
            this.loadTicketsToolStripMenuItem.Click += new System.EventHandler(this.loadTicketsToolStripMenuItem_Click);
            // 
            // reports_item_airplane_TSM
            // 
            this.reports_item_airplane_TSM.Name = "reports_item_airplane_TSM";
            this.reports_item_airplane_TSM.Size = new System.Drawing.Size(74, 24);
            this.reports_item_airplane_TSM.Text = "Reports";
            // 
            // city_DGV
            // 
            this.city_DGV.AllowUserToAddRows = false;
            this.city_DGV.AllowUserToDeleteRows = false;
            this.city_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.city_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.city_DGV.Location = new System.Drawing.Point(47, 155);
            this.city_DGV.Name = "city_DGV";
            this.city_DGV.ReadOnly = true;
            this.city_DGV.RowHeadersWidth = 51;
            this.city_DGV.RowTemplate.Height = 24;
            this.city_DGV.Size = new System.Drawing.Size(294, 292);
            this.city_DGV.TabIndex = 23;
            this.city_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.city_DGV_CellClick);
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 500);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.add_city_btn);
            this.Controls.Add(this.airplane_menu_strip);
            this.Controls.Add(this.city_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCity";
            this.Text = "City";
            this.airplane_menu_strip.ResumeLayout(false);
            this.airplane_menu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.city_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.Button add_city_btn;
        private System.Windows.Forms.MenuStrip airplane_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem options_item_airplane_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_flight_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_airplane_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem reports_item_airplane_TSM;
        private System.Windows.Forms.DataGridView city_DGV;
        private System.Windows.Forms.ToolStripMenuItem load_route_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_manager_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_pilot_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
    }
}