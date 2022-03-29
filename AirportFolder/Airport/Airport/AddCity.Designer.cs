namespace Airport
{
    partial class AddCity
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
            this.add_edit_city_lbl = new System.Windows.Forms.Label();
            this.city_cbox = new System.Windows.Forms.ComboBox();
            this.city_lbl = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_city_lbl = new System.Windows.Forms.Label();
            this.city_id_txt = new System.Windows.Forms.TextBox();
            this.city_id_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_edit_city_lbl
            // 
            this.add_edit_city_lbl.AutoSize = true;
            this.add_edit_city_lbl.Enabled = false;
            this.add_edit_city_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_edit_city_lbl.Location = new System.Drawing.Point(104, 29);
            this.add_edit_city_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_edit_city_lbl.Name = "add_edit_city_lbl";
            this.add_edit_city_lbl.Size = new System.Drawing.Size(212, 32);
            this.add_edit_city_lbl.TabIndex = 32;
            this.add_edit_city_lbl.Text = "Add/Edit cities";
            // 
            // city_cbox
            // 
            this.city_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_cbox.FormattingEnabled = true;
            this.city_cbox.Location = new System.Drawing.Point(192, 89);
            this.city_cbox.Name = "city_cbox";
            this.city_cbox.Size = new System.Drawing.Size(164, 30);
            this.city_cbox.TabIndex = 31;
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_lbl.Location = new System.Drawing.Point(31, 94);
            this.city_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(73, 26);
            this.city_lbl.TabIndex = 30;
            this.city_lbl.Text = "Cities:";
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(192, 186);
            this.city_txt.Margin = new System.Windows.Forms.Padding(4);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(164, 22);
            this.city_txt.TabIndex = 29;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(129, 228);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 62);
            this.save_btn.TabIndex = 28;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_city_lbl
            // 
            this.add_city_lbl.AutoSize = true;
            this.add_city_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_city_lbl.Location = new System.Drawing.Point(31, 179);
            this.add_city_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_city_lbl.Name = "add_city_lbl";
            this.add_city_lbl.Size = new System.Drawing.Size(114, 26);
            this.add_city_lbl.TabIndex = 27;
            this.add_city_lbl.Text = "Add a city:";
            // 
            // city_id_txt
            // 
            this.city_id_txt.Location = new System.Drawing.Point(192, 144);
            this.city_id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.city_id_txt.Name = "city_id_txt";
            this.city_id_txt.Size = new System.Drawing.Size(164, 22);
            this.city_id_txt.TabIndex = 34;
            // 
            // city_id_lbl
            // 
            this.city_id_lbl.AutoSize = true;
            this.city_id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_id_lbl.Location = new System.Drawing.Point(31, 137);
            this.city_id_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city_id_lbl.Name = "city_id_lbl";
            this.city_id_lbl.Size = new System.Drawing.Size(142, 26);
            this.city_id_lbl.TabIndex = 33;
            this.city_id_lbl.Text = "Add a city ID:";
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 303);
            this.Controls.Add(this.city_id_txt);
            this.Controls.Add(this.city_id_lbl);
            this.Controls.Add(this.add_edit_city_lbl);
            this.Controls.Add(this.city_cbox);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_city_lbl);
            this.Name = "AddCity";
            this.Text = "AddEditCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_edit_city_lbl;
        private System.Windows.Forms.ComboBox city_cbox;
        private System.Windows.Forms.Label city_lbl;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label add_city_lbl;
        private System.Windows.Forms.TextBox city_id_txt;
        private System.Windows.Forms.Label city_id_lbl;
    }
}