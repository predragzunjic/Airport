namespace Airport
{
    partial class AddTicket
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.surname_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.add_ticket_lbl = new System.Windows.Forms.Label();
            this.jmbg_lbl = new System.Windows.Forms.Label();
            this.jmbg_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(197, 143);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(164, 22);
            this.name_txt.TabIndex = 47;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(120, 257);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 62);
            this.save_btn.TabIndex = 43;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(197, 189);
            this.surname_txt.Margin = new System.Windows.Forms.Padding(4);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(164, 22);
            this.surname_txt.TabIndex = 42;
            // 
            // surname_lbl
            // 
            this.surname_lbl.AutoSize = true;
            this.surname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_lbl.Location = new System.Drawing.Point(36, 187);
            this.surname_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname_lbl.Name = "surname_lbl";
            this.surname_lbl.Size = new System.Drawing.Size(98, 25);
            this.surname_lbl.TabIndex = 39;
            this.surname_lbl.Text = "Surname:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(36, 143);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(70, 25);
            this.name_lbl.TabIndex = 38;
            this.name_lbl.Text = "Name:";
            // 
            // add_ticket_lbl
            // 
            this.add_ticket_lbl.AutoSize = true;
            this.add_ticket_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ticket_lbl.Location = new System.Drawing.Point(96, 21);
            this.add_ticket_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_ticket_lbl.Name = "add_ticket_lbl";
            this.add_ticket_lbl.Size = new System.Drawing.Size(201, 42);
            this.add_ticket_lbl.TabIndex = 36;
            this.add_ticket_lbl.Text = "Add tickets";
            // 
            // jmbg_lbl
            // 
            this.jmbg_lbl.AutoSize = true;
            this.jmbg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbg_lbl.Location = new System.Drawing.Point(36, 99);
            this.jmbg_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jmbg_lbl.Name = "jmbg_lbl";
            this.jmbg_lbl.Size = new System.Drawing.Size(79, 25);
            this.jmbg_lbl.TabIndex = 37;
            this.jmbg_lbl.Text = "JMBG: ";
            // 
            // jmbg_txt
            // 
            this.jmbg_txt.Location = new System.Drawing.Point(197, 101);
            this.jmbg_txt.Margin = new System.Windows.Forms.Padding(4);
            this.jmbg_txt.Name = "jmbg_txt";
            this.jmbg_txt.Size = new System.Drawing.Size(164, 22);
            this.jmbg_txt.TabIndex = 41;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 337);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.jmbg_txt);
            this.Controls.Add(this.surname_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.jmbg_lbl);
            this.Controls.Add(this.add_ticket_lbl);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label surname_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label add_ticket_lbl;
        private System.Windows.Forms.Label jmbg_lbl;
        private System.Windows.Forms.TextBox jmbg_txt;
    }
}