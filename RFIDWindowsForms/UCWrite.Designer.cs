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
            this.lbl_sirName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_rfid = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_secondName_write = new System.Windows.Forms.TextBox();
            this.txt_firstName_write = new System.Windows.Forms.TextBox();
            this.txt_rfid_write = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lastName_write = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info_write = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_write)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_write
            // 
            this.dataGridView_write.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_write.Location = new System.Drawing.Point(5, 301);
            this.dataGridView_write.Name = "dataGridView_write";
            this.dataGridView_write.RowHeadersWidth = 62;
            this.dataGridView_write.RowTemplate.Height = 28;
            this.dataGridView_write.Size = new System.Drawing.Size(852, 271);
            this.dataGridView_write.TabIndex = 34;
            // 
            // lbl_sirName
            // 
            this.lbl_sirName.AutoSize = true;
            this.lbl_sirName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sirName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sirName.Location = new System.Drawing.Point(40, 155);
            this.lbl_sirName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_sirName.Name = "lbl_sirName";
            this.lbl_sirName.Size = new System.Drawing.Size(148, 32);
            this.lbl_sirName.TabIndex = 33;
            this.lbl_sirName.Text = "Презиме:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(106, 110);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 32);
            this.lbl_name.TabIndex = 32;
            this.lbl_name.Text = "Име:";
            // 
            // lbl_rfid
            // 
            this.lbl_rfid.AutoSize = true;
            this.lbl_rfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_rfid.Location = new System.Drawing.Point(98, 66);
            this.lbl_rfid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_rfid.Name = "lbl_rfid";
            this.lbl_rfid.Size = new System.Drawing.Size(91, 32);
            this.lbl_rfid.TabIndex = 31;
            this.lbl_rfid.Text = "RFID:";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(321, 254);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 41);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "ЗАПИШИ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_secondName_write
            // 
            this.txt_secondName_write.Location = new System.Drawing.Point(195, 162);
            this.txt_secondName_write.Name = "txt_secondName_write";
            this.txt_secondName_write.Size = new System.Drawing.Size(263, 26);
            this.txt_secondName_write.TabIndex = 29;
            // 
            // txt_firstName_write
            // 
            this.txt_firstName_write.Location = new System.Drawing.Point(195, 117);
            this.txt_firstName_write.Name = "txt_firstName_write";
            this.txt_firstName_write.Size = new System.Drawing.Size(263, 26);
            this.txt_firstName_write.TabIndex = 28;
            // 
            // txt_rfid_write
            // 
            this.txt_rfid_write.Location = new System.Drawing.Point(195, 73);
            this.txt_rfid_write.Name = "txt_rfid_write";
            this.txt_rfid_write.Size = new System.Drawing.Size(263, 26);
            this.txt_rfid_write.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(248, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "ДОБАВИ ЧИП";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Фамилия:";
            // 
            // txt_lastName_write
            // 
            this.txt_lastName_write.Location = new System.Drawing.Point(195, 208);
            this.txt_lastName_write.Name = "txt_lastName_write";
            this.txt_lastName_write.Size = new System.Drawing.Size(263, 26);
            this.txt_lastName_write.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDWindowsForms.Properties.Resources.logoX;
            this.pictureBox1.Location = new System.Drawing.Point(507, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btn_info_write
            // 
            this.btn_info_write.BackgroundImage = global::RFIDWindowsForms.Properties.Resources._299086_info_sign_icon;
            this.btn_info_write.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_write.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_info_write.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_write.Location = new System.Drawing.Point(3, 3);
            this.btn_info_write.Name = "btn_info_write";
            this.btn_info_write.Size = new System.Drawing.Size(45, 44);
            this.btn_info_write.TabIndex = 38;
            this.btn_info_write.UseVisualStyleBackColor = true;
            // 
            // UCWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.btn_info_write);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lastName_write);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_write);
            this.Controls.Add(this.lbl_sirName);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_rfid);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_secondName_write);
            this.Controls.Add(this.txt_firstName_write);
            this.Controls.Add(this.txt_rfid_write);
            this.Controls.Add(this.label2);
            this.Name = "UCWrite";
            this.Size = new System.Drawing.Size(860, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_write)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_write;
        private System.Windows.Forms.Label lbl_sirName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_rfid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_secondName_write;
        private System.Windows.Forms.TextBox txt_firstName_write;
        private System.Windows.Forms.TextBox txt_rfid_write;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lastName_write;
        private System.Windows.Forms.Button btn_info_write;
    }
}
