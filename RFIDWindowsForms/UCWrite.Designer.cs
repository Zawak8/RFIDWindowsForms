namespace RFIDWindowsForms
{
    partial class UCWrite
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_write = new System.Windows.Forms.DataGridView();
            this.lblAdd_secondName = new System.Windows.Forms.Label();
            this.lblAdd_name = new System.Windows.Forms.Label();
            this.lblAdd_rfid = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_sirName_write = new System.Windows.Forms.TextBox();
            this.txt_name_write = new System.Windows.Forms.TextBox();
            this.txt_rfid_write = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdd_thirdName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_write)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_write
            // 
            this.dataGridView_write.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_write.Location = new System.Drawing.Point(11, 241);
            this.dataGridView_write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_write.Name = "dataGridView_write";
            this.dataGridView_write.RowHeadersWidth = 62;
            this.dataGridView_write.RowTemplate.Height = 28;
            this.dataGridView_write.Size = new System.Drawing.Size(649, 78);
            this.dataGridView_write.TabIndex = 34;
            // 
            // lblAdd_secondName
            // 
            this.lblAdd_secondName.AutoSize = true;
            this.lblAdd_secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_secondName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdd_secondName.Location = new System.Drawing.Point(18, 123);
            this.lblAdd_secondName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAdd_secondName.Name = "lblAdd_secondName";
            this.lblAdd_secondName.Size = new System.Drawing.Size(132, 29);
            this.lblAdd_secondName.TabIndex = 33;
            this.lblAdd_secondName.Text = "Презиме:";
            // 
            // lblAdd_name
            // 
            this.lblAdd_name.AutoSize = true;
            this.lblAdd_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdd_name.Location = new System.Drawing.Point(77, 89);
            this.lblAdd_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAdd_name.Name = "lblAdd_name";
            this.lblAdd_name.Size = new System.Drawing.Size(73, 29);
            this.lblAdd_name.TabIndex = 32;
            this.lblAdd_name.Text = "Име:";
            // 
            // lblAdd_rfid
            // 
            this.lblAdd_rfid.AutoSize = true;
            this.lblAdd_rfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_rfid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdd_rfid.Location = new System.Drawing.Point(8, 52);
            this.lblAdd_rfid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAdd_rfid.Name = "lblAdd_rfid";
            this.lblAdd_rfid.Size = new System.Drawing.Size(143, 29);
            this.lblAdd_rfid.TabIndex = 31;
            this.lblAdd_rfid.Text = "RFID-ЧИП:";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(268, 203);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(122, 33);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "ЗАПИШИ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_sirName_write
            // 
            this.txt_sirName_write.Location = new System.Drawing.Point(156, 130);
            this.txt_sirName_write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sirName_write.Name = "txt_sirName_write";
            this.txt_sirName_write.Size = new System.Drawing.Size(234, 22);
            this.txt_sirName_write.TabIndex = 29;
            // 
            // txt_name_write
            // 
            this.txt_name_write.Location = new System.Drawing.Point(156, 94);
            this.txt_name_write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name_write.Name = "txt_name_write";
            this.txt_name_write.Size = new System.Drawing.Size(234, 22);
            this.txt_name_write.TabIndex = 28;
            // 
            // txt_rfid_write
            // 
            this.txt_rfid_write.Location = new System.Drawing.Point(156, 58);
            this.txt_rfid_write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_rfid_write.Name = "txt_rfid_write";
            this.txt_rfid_write.Size = new System.Drawing.Size(234, 22);
            this.txt_rfid_write.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(203, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "ДОБАВИ ЧИП";
            // 
            // lblAdd_thirdName
            // 
            this.lblAdd_thirdName.AutoSize = true;
            this.lblAdd_thirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_thirdName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdd_thirdName.Location = new System.Drawing.Point(14, 161);
            this.lblAdd_thirdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAdd_thirdName.Name = "lblAdd_thirdName";
            this.lblAdd_thirdName.Size = new System.Drawing.Size(137, 29);
            this.lblAdd_thirdName.TabIndex = 37;
            this.lblAdd_thirdName.Text = "Фамилия:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 166);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDWindowsForms.Properties.Resources.logoX;
            this.pictureBox1.Location = new System.Drawing.Point(433, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // UCWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.lblAdd_thirdName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_write);
            this.Controls.Add(this.lblAdd_secondName);
            this.Controls.Add(this.lblAdd_name);
            this.Controls.Add(this.lblAdd_rfid);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_sirName_write);
            this.Controls.Add(this.txt_name_write);
            this.Controls.Add(this.txt_rfid_write);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCWrite";
            this.Size = new System.Drawing.Size(671, 328);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_write)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_write;
        private System.Windows.Forms.Label lblAdd_secondName;
        private System.Windows.Forms.Label lblAdd_name;
        private System.Windows.Forms.Label lblAdd_rfid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_sirName_write;
        private System.Windows.Forms.TextBox txt_name_write;
        private System.Windows.Forms.TextBox txt_rfid_write;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdd_thirdName;
        private System.Windows.Forms.TextBox textBox1;
    }
}
