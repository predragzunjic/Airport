namespace Airport
{
    partial class FormManager
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
            this.del_manager_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.edit_manager_btn = new System.Windows.Forms.Button();
            this.add_manager_btn = new System.Windows.Forms.Button();
            this.airplane_menu_strip = new System.Windows.Forms.MenuStrip();
            this.options_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_flight_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_airplane_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_route_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_city_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.load_pilot_options_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_item_airplane_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.manager_lbl = new System.Windows.Forms.Label();
            this.manager_DGV = new System.Windows.Forms.DataGridView();
            this.add_ssb_btn = new System.Windows.Forms.Button();
            this.airplane_menu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // del_manager_btn
            // 
            this.del_manager_btn.Location = new System.Drawing.Point(326, 58);
            this.del_manager_btn.Name = "del_manager_btn";
            this.del_manager_btn.Size = new System.Drawing.Size(130, 35);
            this.del_manager_btn.TabIndex = 23;
            this.del_manager_btn.Text = "Delete a manager";
            this.del_manager_btn.UseVisualStyleBackColor = true;
            this.del_manager_btn.Click += new System.EventHandler(this.del_manager_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(32, 165);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(373, 22);
            this.search_textbox.TabIndex = 25;
            // 
            // edit_manager_btn
            // 
            this.edit_manager_btn.Location = new System.Drawing.Point(180, 58);
            this.edit_manager_btn.Name = "edit_manager_btn";
            this.edit_manager_btn.Size = new System.Drawing.Size(130, 35);
            this.edit_manager_btn.TabIndex = 24;
            this.edit_manager_btn.Text = "Edit a manager";
            this.edit_manager_btn.UseVisualStyleBackColor = true;
            this.edit_manager_btn.Click += new System.EventHandler(this.edit_airplane_btn_Click);
            // 
            // add_manager_btn
            // 
            this.add_manager_btn.Location = new System.Drawing.Point(32, 58);
            this.add_manager_btn.Name = "add_manager_btn";
            this.add_manager_btn.Size = new System.Drawing.Size(130, 35);
            this.add_manager_btn.TabIndex = 22;
            this.add_manager_btn.Text = "Add a manager";
            this.add_manager_btn.UseVisualStyleBackColor = true;
            this.add_manager_btn.Click += new System.EventHandler(this.add_manager_btn_Click);
            // 
            // airplane_menu_strip
            // 
            this.airplane_menu_strip.Dock = System.Windows.Forms.DockStyle.None;
            this.airplane_menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.airplane_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options_item_airplane_TSM,
            this.reports_item_airplane_TSM});
            this.airplane_menu_strip.Location = new System.Drawing.Point(16, 11);
            this.airplane_menu_strip.Name = "airplane_menu_strip";
            this.airplane_menu_strip.Size = new System.Drawing.Size(157, 28);
            this.airplane_menu_strip.TabIndex = 21;
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
            // load_city_options_TSM
            // 
            this.load_city_options_TSM.Name = "load_city_options_TSM";
            this.load_city_options_TSM.Size = new System.Drawing.Size(189, 26);
            this.load_city_options_TSM.Text = "Load cities";
            this.load_city_options_TSM.Click += new System.EventHandler(this.load_city_options_TSM_Click);
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
            // manager_lbl
            // 
            this.manager_lbl.AutoSize = true;
            this.manager_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_lbl.Location = new System.Drawing.Point(307, 109);
            this.manager_lbl.Name = "manager_lbl";
            this.manager_lbl.Size = new System.Drawing.Size(197, 44);
            this.manager_lbl.TabIndex = 20;
            this.manager_lbl.Text = "Managers";
            // 
            // manager_DGV
            // 
            this.manager_DGV.AllowUserToAddRows = false;
            this.manager_DGV.AllowUserToDeleteRows = false;
            this.manager_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.manager_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manager_DGV.Location = new System.Drawing.Point(32, 197);
            this.manager_DGV.Name = "manager_DGV";
            this.manager_DGV.ReadOnly = true;
            this.manager_DGV.RowHeadersWidth = 51;
            this.manager_DGV.RowTemplate.Height = 24;
            this.manager_DGV.Size = new System.Drawing.Size(753, 243);
            this.manager_DGV.TabIndex = 19;
            this.manager_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manager_DGV_CellClick);
            // 
            // add_ssb_btn
            // 
            this.add_ssb_btn.Location = new System.Drawing.Point(476, 58);
            this.add_ssb_btn.Name = "add_ssb_btn";
            this.add_ssb_btn.Size = new System.Drawing.Size(130, 35);
            this.add_ssb_btn.TabIndex = 26;
            this.add_ssb_btn.Text = "Add S.S.B";
            this.add_ssb_btn.UseVisualStyleBackColor = true;
            this.add_ssb_btn.Click += new System.EventHandler(this.add_ssb_btn_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.add_ssb_btn);
            this.Controls.Add(this.del_manager_btn);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.edit_manager_btn);
            this.Controls.Add(this.add_manager_btn);
            this.Controls.Add(this.airplane_menu_strip);
            this.Controls.Add(this.manager_lbl);
            this.Controls.Add(this.manager_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.airplane_menu_strip.ResumeLayout(false);
            this.airplane_menu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manager_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_manager_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button edit_manager_btn;
        private System.Windows.Forms.Button add_manager_btn;
        private System.Windows.Forms.MenuStrip airplane_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem options_item_airplane_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_flight_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_route_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_city_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem reports_item_airplane_TSM;
        private System.Windows.Forms.Label manager_lbl;
        private System.Windows.Forms.DataGridView manager_DGV;
        private System.Windows.Forms.ToolStripMenuItem load_airplane_options_TSM;
        private System.Windows.Forms.ToolStripMenuItem load_pilot_options_TSM;
        private System.Windows.Forms.Button add_ssb_btn;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
    }
}