namespace Airport
{
    partial class FormAirplane
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
            this.airplane_DGV = new System.Windows.Forms.DataGridView();
            this.airplane_lbl = new System.Windows.Forms.Label();
            this.airplane_menu_strip = new System.Windows.Forms.MenuStrip();
            this.options_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_flight_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_route_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_city_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_manager_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_pilot_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.del_airplane_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.edit_airplane_btn = new System.Windows.Forms.Button();
            this.add_airplane_btn = new System.Windows.Forms.Button();
            this.add_model_btn = new System.Windows.Forms.Button();
            this.del_model_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airplane_DGV)).BeginInit();
            this.airplane_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // airplane_DGV
            // 
            this.airplane_DGV.AllowUserToAddRows = false;
            this.airplane_DGV.AllowUserToDeleteRows = false;
            this.airplane_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.airplane_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplane_DGV.Location = new System.Drawing.Point(25, 195);
            this.airplane_DGV.Name = "airplane_DGV";
            this.airplane_DGV.ReadOnly = true;
            this.airplane_DGV.RowHeadersWidth = 51;
            this.airplane_DGV.RowTemplate.Height = 24;
            this.airplane_DGV.Size = new System.Drawing.Size(753, 243);
            this.airplane_DGV.TabIndex = 12;
            this.airplane_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airplane_DGV_CellClick);
            // 
            // airplane_lbl
            // 
            this.airplane_lbl.AutoSize = true;
            this.airplane_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplane_lbl.Location = new System.Drawing.Point(300, 107);
            this.airplane_lbl.Name = "airplane_lbl";
            this.airplane_lbl.Size = new System.Drawing.Size(188, 44);
            this.airplane_lbl.TabIndex = 13;
            this.airplane_lbl.Text = "Airplanes";
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
            this.airplane_menu_strip.TabIndex = 14;
            this.airplane_menu_strip.Text = "menuStrip1";
            // 
            // options_item_airplane_TSM
            // 
            this.options_item_airplane_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_flight_options_TSM,
            this.load_route_options_TSM,
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
            // reports_item_airplane_TSM
            // 
            this.reports_item_airplane_TSM.Name = "reports_item_airplane_TSM";
            this.reports_item_airplane_TSM.Size = new System.Drawing.Size(74, 24);
            this.reports_item_airplane_TSM.Text = "Reports";
            // 
            // del_airplane_btn
            // 
            this.del_airplane_btn.Location = new System.Drawing.Point(319, 56);
            this.del_airplane_btn.Name = "del_airplane_btn";
            this.del_airplane_btn.Size = new System.Drawing.Size(130, 48);
            this.del_airplane_btn.TabIndex = 16;
            this.del_airplane_btn.Text = "Delete an airplane";
            this.del_airplane_btn.UseVisualStyleBackColor = true;
            this.del_airplane_btn.Click += new System.EventHandler(this.del_airplane_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(25, 163);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(373, 22);
            this.search_textbox.TabIndex = 18;
            // 
            // edit_airplane_btn
            // 
            this.edit_airplane_btn.Location = new System.Drawing.Point(173, 56);
            this.edit_airplane_btn.Name = "edit_airplane_btn";
            this.edit_airplane_btn.Size = new System.Drawing.Size(130, 35);
            this.edit_airplane_btn.TabIndex = 17;
            this.edit_airplane_btn.Text = "Edit an airplane";
            this.edit_airplane_btn.UseVisualStyleBackColor = true;
            this.edit_airplane_btn.Click += new System.EventHandler(this.edit_airplane_btn_Click);
            // 
            // add_airplane_btn
            // 
            this.add_airplane_btn.Location = new System.Drawing.Point(25, 56);
            this.add_airplane_btn.Name = "add_airplane_btn";
            this.add_airplane_btn.Size = new System.Drawing.Size(130, 35);
            this.add_airplane_btn.TabIndex = 15;
            this.add_airplane_btn.Text = "Add an airplane";
            this.add_airplane_btn.UseVisualStyleBackColor = true;
            this.add_airplane_btn.Click += new System.EventHandler(this.add_airplane_btn_Click);
            // 
            // add_model_btn
            // 
            this.add_model_btn.Location = new System.Drawing.Point(465, 56);
            this.add_model_btn.Name = "add_model_btn";
            this.add_model_btn.Size = new System.Drawing.Size(130, 35);
            this.add_model_btn.TabIndex = 19;
            this.add_model_btn.Text = "Add a model";
            this.add_model_btn.UseVisualStyleBackColor = true;
            this.add_model_btn.Click += new System.EventHandler(this.add_model_btn_Click);
            // 
            // del_model_btn
            // 
            this.del_model_btn.Location = new System.Drawing.Point(612, 56);
            this.del_model_btn.Name = "del_model_btn";
            this.del_model_btn.Size = new System.Drawing.Size(130, 35);
            this.del_model_btn.TabIndex = 20;
            this.del_model_btn.Text = "Delete a model";
            this.del_model_btn.UseVisualStyleBackColor = true;
            this.del_model_btn.Click += new System.EventHandler(this.del_model_btn_Click);
            // 
            // FormAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 500);
            this.Controls.Add(this.del_model_btn);
            this.Controls.Add(this.add_model_btn);
            this.Controls.Add(this.del_airplane_btn);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.edit_airplane_btn);
            this.Controls.Add(this.add_airplane_btn);
            this.Controls.Add(this.airplane_menu_strip);
            this.Controls.Add(this.airplane_lbl);
            this.Controls.Add(this.airplane_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAirplane";
            this.Text = "FormAirplane";
            ((System.ComponentModel.ISupportInitialize)(this.airplane_DGV)).EndInit();
            this.airplane_menu_strip.ResumeLayout(false);
            this.airplane_menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView airplane_DGV;
        private System.Windows.Forms.Label airplane_lbl;
        private System.Windows.Forms.MenuStrip airplane_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem options_item_airplane_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_flight_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem reports_item_airplane_TSM;
        private System.Windows.Forms.Button del_airplane_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button edit_airplane_btn;
        private System.Windows.Forms.Button add_airplane_btn;
        private System.Windows.Forms.ToolStripMenuItem load_route_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_city_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_manager_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_pilot_options_TSM;
        private System.Windows.Forms.Button add_model_btn;
        private System.Windows.Forms.Button del_model_btn;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
    }
}