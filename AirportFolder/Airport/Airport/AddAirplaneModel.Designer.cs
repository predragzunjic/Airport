namespace Airport
{
    partial class AddAirplaneModel
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
            this.new_model_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_model_lbl = new System.Windows.Forms.Label();
            this.name_cbox = new System.Windows.Forms.ComboBox();
            this.model_lbl = new System.Windows.Forms.Label();
            this.add_edit_model_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_model_txt
            // 
            this.new_model_txt.Location = new System.Drawing.Point(174, 142);
            this.new_model_txt.Margin = new System.Windows.Forms.Padding(4);
            this.new_model_txt.Name = "new_model_txt";
            this.new_model_txt.Size = new System.Drawing.Size(164, 22);
            this.new_model_txt.TabIndex = 23;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(111, 213);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 62);
            this.save_btn.TabIndex = 22;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_model_lbl
            // 
            this.add_model_lbl.AutoSize = true;
            this.add_model_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_model_lbl.Location = new System.Drawing.Point(13, 135);
            this.add_model_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_model_lbl.Name = "add_model_lbl";
            this.add_model_lbl.Size = new System.Drawing.Size(141, 26);
            this.add_model_lbl.TabIndex = 21;
            this.add_model_lbl.Text = "Add a model:";
            // 
            // name_cbox
            // 
            this.name_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_cbox.FormattingEnabled = true;
            this.name_cbox.Location = new System.Drawing.Point(174, 79);
            this.name_cbox.Name = "name_cbox";
            this.name_cbox.Size = new System.Drawing.Size(164, 30);
            this.name_cbox.TabIndex = 25;
            // 
            // model_lbl
            // 
            this.model_lbl.AutoSize = true;
            this.model_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_lbl.Location = new System.Drawing.Point(13, 84);
            this.model_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.model_lbl.Name = "model_lbl";
            this.model_lbl.Size = new System.Drawing.Size(88, 26);
            this.model_lbl.TabIndex = 24;
            this.model_lbl.Text = "Models:";
            // 
            // add_edit_model_lbl
            // 
            this.add_edit_model_lbl.AutoSize = true;
            this.add_edit_model_lbl.Enabled = false;
            this.add_edit_model_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_edit_model_lbl.Location = new System.Drawing.Point(12, 20);
            this.add_edit_model_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_edit_model_lbl.Name = "add_edit_model_lbl";
            this.add_edit_model_lbl.Size = new System.Drawing.Size(333, 32);
            this.add_edit_model_lbl.TabIndex = 26;
            this.add_edit_model_lbl.Text = "Add/Edit airplane models";
            // 
            // AddAirplaneModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 288);
            this.Controls.Add(this.add_edit_model_lbl);
            this.Controls.Add(this.name_cbox);
            this.Controls.Add(this.model_lbl);
            this.Controls.Add(this.new_model_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_model_lbl);
            this.Name = "AddAirplaneModel";
            this.Text = "AddAirplaneModel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_model_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label add_model_lbl;
        private System.Windows.Forms.ComboBox name_cbox;
        private System.Windows.Forms.Label model_lbl;
        private System.Windows.Forms.Label add_edit_model_lbl;
    }
}