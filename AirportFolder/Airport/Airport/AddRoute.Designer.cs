namespace Airport
{
    partial class AddRoute
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
            this.left_cbox = new System.Windows.Forms.ComboBox();
            this.right_cbox = new System.Windows.Forms.ComboBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_route_lbl = new System.Windows.Forms.Label();
            this.side_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // left_cbox
            // 
            this.left_cbox.FormattingEnabled = true;
            this.left_cbox.Location = new System.Drawing.Point(12, 112);
            this.left_cbox.Name = "left_cbox";
            this.left_cbox.Size = new System.Drawing.Size(121, 24);
            this.left_cbox.TabIndex = 0;
            // 
            // right_cbox
            // 
            this.right_cbox.FormattingEnabled = true;
            this.right_cbox.Location = new System.Drawing.Point(168, 112);
            this.right_cbox.Name = "right_cbox";
            this.right_cbox.Size = new System.Drawing.Size(121, 24);
            this.right_cbox.TabIndex = 1;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(79, 177);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 62);
            this.save_btn.TabIndex = 31;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_route_lbl
            // 
            this.add_route_lbl.AutoSize = true;
            this.add_route_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_route_lbl.Location = new System.Drawing.Point(59, 18);
            this.add_route_lbl.Name = "add_route_lbl";
            this.add_route_lbl.Size = new System.Drawing.Size(172, 32);
            this.add_route_lbl.TabIndex = 32;
            this.add_route_lbl.Text = "Add a route";
            // 
            // side_lbl
            // 
            this.side_lbl.AutoSize = true;
            this.side_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side_lbl.Location = new System.Drawing.Point(74, 59);
            this.side_lbl.Name = "side_lbl";
            this.side_lbl.Size = new System.Drawing.Size(140, 29);
            this.side_lbl.TabIndex = 33;
            this.side_lbl.Text = "(both sides)";
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 252);
            this.Controls.Add(this.side_lbl);
            this.Controls.Add(this.add_route_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.right_cbox);
            this.Controls.Add(this.left_cbox);
            this.Name = "AddRoute";
            this.Text = "AddEditRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox left_cbox;
        private System.Windows.Forms.ComboBox right_cbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label add_route_lbl;
        private System.Windows.Forms.Label side_lbl;
    }
}