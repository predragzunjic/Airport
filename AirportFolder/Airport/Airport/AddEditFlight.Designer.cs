namespace Airport
{
    partial class AddEditFlight
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
            this.pilot_lbl = new System.Windows.Forms.Label();
            this.add_edit_flight_lbl = new System.Windows.Forms.Label();
            this.airplane_lbl = new System.Windows.Forms.Label();
            this.flight_date_lbl = new System.Windows.Forms.Label();
            this.flight_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.route_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.pilot_cbox = new System.Windows.Forms.ComboBox();
            this.airplane_cbox = new System.Windows.Forms.ComboBox();
            this.route_cbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pilot_lbl
            // 
            this.pilot_lbl.AutoSize = true;
            this.pilot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilot_lbl.Location = new System.Drawing.Point(40, 130);
            this.pilot_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pilot_lbl.Name = "pilot_lbl";
            this.pilot_lbl.Size = new System.Drawing.Size(55, 25);
            this.pilot_lbl.TabIndex = 30;
            this.pilot_lbl.Text = "Pilot:";
            // 
            // add_edit_flight_lbl
            // 
            this.add_edit_flight_lbl.AutoSize = true;
            this.add_edit_flight_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_edit_flight_lbl.Location = new System.Drawing.Point(113, 33);
            this.add_edit_flight_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_edit_flight_lbl.Name = "add_edit_flight_lbl";
            this.add_edit_flight_lbl.Size = new System.Drawing.Size(266, 42);
            this.add_edit_flight_lbl.TabIndex = 29;
            this.add_edit_flight_lbl.Text = "Add/Edit flights";
            // 
            // airplane_lbl
            // 
            this.airplane_lbl.AutoSize = true;
            this.airplane_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplane_lbl.Location = new System.Drawing.Point(40, 182);
            this.airplane_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.airplane_lbl.Name = "airplane_lbl";
            this.airplane_lbl.Size = new System.Drawing.Size(90, 25);
            this.airplane_lbl.TabIndex = 32;
            this.airplane_lbl.Text = "Airplane:";
            // 
            // flight_date_lbl
            // 
            this.flight_date_lbl.AutoSize = true;
            this.flight_date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight_date_lbl.Location = new System.Drawing.Point(40, 234);
            this.flight_date_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flight_date_lbl.Name = "flight_date_lbl";
            this.flight_date_lbl.Size = new System.Drawing.Size(108, 25);
            this.flight_date_lbl.TabIndex = 34;
            this.flight_date_lbl.Text = "Flight date:";
            // 
            // flight_date_dtp
            // 
            this.flight_date_dtp.Location = new System.Drawing.Point(201, 237);
            this.flight_date_dtp.Name = "flight_date_dtp";
            this.flight_date_dtp.Size = new System.Drawing.Size(266, 22);
            this.flight_date_dtp.TabIndex = 36;
            // 
            // route_lbl
            // 
            this.route_lbl.AutoSize = true;
            this.route_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.route_lbl.Location = new System.Drawing.Point(40, 288);
            this.route_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.route_lbl.Name = "route_lbl";
            this.route_lbl.Size = new System.Drawing.Size(69, 25);
            this.route_lbl.TabIndex = 37;
            this.route_lbl.Text = "Route:";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(177, 357);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 62);
            this.save_btn.TabIndex = 39;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // pilot_cbox
            // 
            this.pilot_cbox.FormattingEnabled = true;
            this.pilot_cbox.Location = new System.Drawing.Point(201, 130);
            this.pilot_cbox.Name = "pilot_cbox";
            this.pilot_cbox.Size = new System.Drawing.Size(266, 24);
            this.pilot_cbox.TabIndex = 40;
            // 
            // airplane_cbox
            // 
            this.airplane_cbox.FormattingEnabled = true;
            this.airplane_cbox.Location = new System.Drawing.Point(201, 182);
            this.airplane_cbox.Name = "airplane_cbox";
            this.airplane_cbox.Size = new System.Drawing.Size(266, 24);
            this.airplane_cbox.TabIndex = 41;
            // 
            // route_cbox
            // 
            this.route_cbox.FormattingEnabled = true;
            this.route_cbox.Location = new System.Drawing.Point(201, 288);
            this.route_cbox.Name = "route_cbox";
            this.route_cbox.Size = new System.Drawing.Size(266, 24);
            this.route_cbox.TabIndex = 42;
            // 
            // AddEditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 446);
            this.Controls.Add(this.route_cbox);
            this.Controls.Add(this.airplane_cbox);
            this.Controls.Add(this.pilot_cbox);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.route_lbl);
            this.Controls.Add(this.flight_date_dtp);
            this.Controls.Add(this.flight_date_lbl);
            this.Controls.Add(this.airplane_lbl);
            this.Controls.Add(this.pilot_lbl);
            this.Controls.Add(this.add_edit_flight_lbl);
            this.Name = "AddEditFlight";
            this.Text = "AddEditFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pilot_lbl;
        private System.Windows.Forms.Label add_edit_flight_lbl;
        private System.Windows.Forms.Label airplane_lbl;
        private System.Windows.Forms.Label flight_date_lbl;
        private System.Windows.Forms.DateTimePicker flight_date_dtp;
        private System.Windows.Forms.Label route_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox pilot_cbox;
        private System.Windows.Forms.ComboBox airplane_cbox;
        private System.Windows.Forms.ComboBox route_cbox;
    }
}