namespace Airport
{
    partial class FormTicket
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
            this.del_ticket_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.airplane_menu_strip = new System.Windows.Forms.MenuStrip();
            this.options_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_flight_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_airplane_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_route_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_city_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_pilot_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_manager_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ticket_lbl = new System.Windows.Forms.Label();
            this.ticket_DGV = new System.Windows.Forms.DataGridView();
            this.airplane_menu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // del_ticket_btn
            // 
            this.del_ticket_btn.Location = new System.Drawing.Point(16, 69);
            this.del_ticket_btn.Name = "del_ticket_btn";
            this.del_ticket_btn.Size = new System.Drawing.Size(130, 35);
            this.del_ticket_btn.TabIndex = 31;
            this.del_ticket_btn.Text = "Delete a ticket";
            this.del_ticket_btn.UseVisualStyleBackColor = true;
            this.del_ticket_btn.Click += new System.EventHandler(this.del_ticket_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(16, 167);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(187, 22);
            this.search_textbox.TabIndex = 33;
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
            this.airplane_menu_strip.TabIndex = 29;
            this.airplane_menu_strip.Text = "menuStrip1";
            // 
            // options_item_airplane_TSM
            // 
            this.options_item_airplane_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_flight_options_TSM,
            this.load_airplane_options_TSM,
            this.load_route_options_TSM,
            this.load_city_options_TSM,
            this.load_pilot_options_TSM,
            this.load_manager_options_TSM});
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
            // load_pilot_options_TSM
            // 
            this.load_pilot_options_TSM.Name = "load_pilot_options_TSM";
            this.load_pilot_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_pilot_options_TSM.Text = "Load pilots";
            this.load_pilot_options_TSM.Click += new System.EventHandler(this.load_pilot_options_TSM_Click);
            // 
            // load_manager_options_TSM
            // 
            this.load_manager_options_TSM.Name = "load_manager_options_TSM";
            this.load_manager_options_TSM.Size = new System.Drawing.Size(194, 26);
            this.load_manager_options_TSM.Text = "Load managers";
            this.load_manager_options_TSM.Click += new System.EventHandler(this.load_manager_options_TSM_Click_1);
            // 
            // reports_item_airplane_TSM
            // 
            this.reports_item_airplane_TSM.Name = "reports_item_airplane_TSM";
            this.reports_item_airplane_TSM.Size = new System.Drawing.Size(74, 24);
            this.reports_item_airplane_TSM.Text = "Reports";
            // 
            // ticket_lbl
            // 
            this.ticket_lbl.AutoSize = true;
            this.ticket_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_lbl.Location = new System.Drawing.Point(153, 107);
            this.ticket_lbl.Name = "ticket_lbl";
            this.ticket_lbl.Size = new System.Drawing.Size(148, 44);
            this.ticket_lbl.TabIndex = 28;
            this.ticket_lbl.Text = "Tickets";
            // 
            // ticket_DGV
            // 
            this.ticket_DGV.AllowUserToAddRows = false;
            this.ticket_DGV.AllowUserToDeleteRows = false;
            this.ticket_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ticket_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticket_DGV.Location = new System.Drawing.Point(16, 195);
            this.ticket_DGV.Name = "ticket_DGV";
            this.ticket_DGV.ReadOnly = true;
            this.ticket_DGV.RowHeadersWidth = 51;
            this.ticket_DGV.RowTemplate.Height = 24;
            this.ticket_DGV.Size = new System.Drawing.Size(404, 243);
            this.ticket_DGV.TabIndex = 27;
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 495);
            this.ControlBox = false;
            this.Controls.Add(this.del_ticket_btn);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.airplane_menu_strip);
            this.Controls.Add(this.ticket_lbl);
            this.Controls.Add(this.ticket_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTicket";
            this.Text = "FormCard";
            this.airplane_menu_strip.ResumeLayout(false);
            this.airplane_menu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button del_ticket_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.MenuStrip airplane_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem options_item_airplane_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_flight_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_airplane_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_route_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_city_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_pilot_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem reports_item_airplane_TSM;
        private System.Windows.Forms.Label ticket_lbl;
        private System.Windows.Forms.DataGridView ticket_DGV;
        private System.Windows.Forms.ToolStripMenuItem load_manager_options_TSM;
    }
}