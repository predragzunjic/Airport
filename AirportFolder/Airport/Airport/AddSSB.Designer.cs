namespace Airport
{
    partial class AddSSB
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
            this.add_edit_ssb_lbl = new System.Windows.Forms.Label();
            this.name_cbox = new System.Windows.Forms.ComboBox();
            this.ssb_lbl = new System.Windows.Forms.Label();
            this.new_ssb_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_model_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_edit_ssb_lbl
            // 
            this.add_edit_ssb_lbl.AutoSize = true;
            this.add_edit_ssb_lbl.Enabled = false;
            this.add_edit_ssb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_edit_ssb_lbl.Location = new System.Drawing.Point(94, 53);
            this.add_edit_ssb_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_edit_ssb_lbl.Name = "add_edit_ssb_lbl";
            this.add_edit_ssb_lbl.Size = new System.Drawing.Size(212, 32);
            this.add_edit_ssb_lbl.TabIndex = 32;
            this.add_edit_ssb_lbl.Text = "Add/Edit S.S.B.";
            // 
            // name_cbox
            // 
            this.name_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_cbox.FormattingEnabled = true;
            this.name_cbox.Location = new System.Drawing.Point(202, 109);
            this.name_cbox.Name = "name_cbox";
            this.name_cbox.Size = new System.Drawing.Size(164, 30);
            this.name_cbox.TabIndex = 31;
            // 
            // ssb_lbl
            // 
            this.ssb_lbl.AutoSize = true;
            this.ssb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssb_lbl.Location = new System.Drawing.Point(27, 109);
            this.ssb_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ssb_lbl.Name = "ssb_lbl";
            this.ssb_lbl.Size = new System.Drawing.Size(75, 26);
            this.ssb_lbl.TabIndex = 30;
            this.ssb_lbl.Text = "S.S.B:";
            // 
            // new_ssb_txt
            // 
            this.new_ssb_txt.Location = new System.Drawing.Point(202, 172);
            this.new_ssb_txt.Margin = new System.Windows.Forms.Padding(4);
            this.new_ssb_txt.Name = "new_ssb_txt";
            this.new_ssb_txt.Size = new System.Drawing.Size(164, 22);
            this.new_ssb_txt.TabIndex = 29;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(139, 243);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 62);
            this.save_btn.TabIndex = 28;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_model_lbl
            // 
            this.add_model_lbl.AutoSize = true;
            this.add_model_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_model_lbl.Location = new System.Drawing.Point(27, 167);
            this.add_model_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_model_lbl.Name = "add_model_lbl";
            this.add_model_lbl.Size = new System.Drawing.Size(138, 26);
            this.add_model_lbl.TabIndex = 27;
            this.add_model_lbl.Text = "Add a S.S.B:";
            // 
            // AddSSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 317);
            this.Controls.Add(this.add_edit_ssb_lbl);
            this.Controls.Add(this.name_cbox);
            this.Controls.Add(this.ssb_lbl);
            this.Controls.Add(this.new_ssb_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_model_lbl);
            this.Name = "AddSSB";
            this.Text = "AddSSB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_edit_ssb_lbl;
        private System.Windows.Forms.ComboBox name_cbox;
        private System.Windows.Forms.Label ssb_lbl;
        private System.Windows.Forms.TextBox new_ssb_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label add_model_lbl;
    }
}