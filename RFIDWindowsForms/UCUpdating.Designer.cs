namespace RFIDWindowsForms
{
    partial class UCUpdating
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
            this.lbl_rfid = new System.Windows.Forms.Label();
            this.txt_rfid_update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lastName_update = new System.Windows.Forms.TextBox();
            this.lbl_sirName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_secondName_update = new System.Windows.Forms.TextBox();
            this.txt_firstName_update = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info_update = new System.Windows.Forms.Button();
            this.dataGridView_read = new System.Windows.Forms.DataGridView();
            this.btn_showAll_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_read)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rfid
            // 
            this.lbl_rfid.AutoSize = true;
            this.lbl_rfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_rfid.Location = new System.Drawing.Point(99, 66);
            this.lbl_rfid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_rfid.Name = "lbl_rfid";
            this.lbl_rfid.Size = new System.Drawing.Size(91, 32);
            this.lbl_rfid.TabIndex = 39;
            this.lbl_rfid.Text = "RFID:";
            // 
            // txt_rfid_update
            // 
            this.txt_rfid_update.Location = new System.Drawing.Point(195, 73);
            this.txt_rfid_update.Name = "txt_rfid_update";
            this.txt_rfid_update.Size = new System.Drawing.Size(310, 26);
            this.txt_rfid_update.TabIndex = 38;
            this.txt_rfid_update.TextChanged += new System.EventHandler(this.txt_rfid_update_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(149, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "ПРОМЕНИ ТИТУЛЯР";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Фамилия:";
            // 
            // txt_lastName_update
            // 
            this.txt_lastName_update.Location = new System.Drawing.Point(196, 209);
            this.txt_lastName_update.Name = "txt_lastName_update";
            this.txt_lastName_update.Size = new System.Drawing.Size(310, 26);
            this.txt_lastName_update.TabIndex = 42;
            // 
            // lbl_sirName
            // 
            this.lbl_sirName.AutoSize = true;
            this.lbl_sirName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sirName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sirName.Location = new System.Drawing.Point(42, 156);
            this.lbl_sirName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_sirName.Name = "lbl_sirName";
            this.lbl_sirName.Size = new System.Drawing.Size(148, 32);
            this.lbl_sirName.TabIndex = 45;
            this.lbl_sirName.Text = "Презиме:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(108, 111);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 32);
            this.lbl_name.TabIndex = 44;
            this.lbl_name.Text = "Име:";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(340, 254);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(166, 41);
            this.btn_update.TabIndex = 43;
            this.btn_update.Text = "ПРОМЕНИ";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_secondName_update
            // 
            this.txt_secondName_update.Location = new System.Drawing.Point(196, 163);
            this.txt_secondName_update.Name = "txt_secondName_update";
            this.txt_secondName_update.Size = new System.Drawing.Size(310, 26);
            this.txt_secondName_update.TabIndex = 41;
            // 
            // txt_firstName_update
            // 
            this.txt_firstName_update.Location = new System.Drawing.Point(196, 118);
            this.txt_firstName_update.Name = "txt_firstName_update";
            this.txt_firstName_update.Size = new System.Drawing.Size(310, 26);
            this.txt_firstName_update.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDWindowsForms.Properties.Resources.logoX;
            this.pictureBox1.Location = new System.Drawing.Point(550, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btn_info_update
            // 
            this.btn_info_update.BackgroundImage = global::RFIDWindowsForms.Properties.Resources._299086_info_sign_icon;
            this.btn_info_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_update.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_info_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_update.Location = new System.Drawing.Point(3, 3);
            this.btn_info_update.Name = "btn_info_update";
            this.btn_info_update.Size = new System.Drawing.Size(45, 44);
            this.btn_info_update.TabIndex = 47;
            this.btn_info_update.UseVisualStyleBackColor = true;
            this.btn_info_update.Click += new System.EventHandler(this.btn_info_update_Click);
            // 
            // dataGridView_read
            // 
            this.dataGridView_read.AllowUserToAddRows = false;
            this.dataGridView_read.AllowUserToDeleteRows = false;
            this.dataGridView_read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_read.Location = new System.Drawing.Point(5, 301);
            this.dataGridView_read.Name = "dataGridView_read";
            this.dataGridView_read.ReadOnly = true;
            this.dataGridView_read.RowHeadersWidth = 62;
            this.dataGridView_read.RowTemplate.Height = 28;
            this.dataGridView_read.Size = new System.Drawing.Size(852, 271);
            this.dataGridView_read.TabIndex = 48;
            // 
            // btn_showAll_update
            // 
            this.btn_showAll_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll_update.Location = new System.Drawing.Point(43, 254);
            this.btn_showAll_update.Name = "btn_showAll_update";
            this.btn_showAll_update.Size = new System.Drawing.Size(272, 41);
            this.btn_showAll_update.TabIndex = 49;
            this.btn_showAll_update.Text = "ПОКАЖИ ВСИЧКИ";
            this.btn_showAll_update.UseVisualStyleBackColor = true;
            this.btn_showAll_update.Click += new System.EventHandler(this.btn_showAll_update_Click);
            // 
            // UCUpdating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.btn_showAll_update);
            this.Controls.Add(this.dataGridView_read);
            this.Controls.Add(this.btn_info_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lastName_update);
            this.Controls.Add(this.lbl_sirName);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_secondName_update);
            this.Controls.Add(this.txt_firstName_update);
            this.Controls.Add(this.lbl_rfid);
            this.Controls.Add(this.txt_rfid_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCUpdating";
            this.Size = new System.Drawing.Size(860, 575);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_read)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_rfid;
        private System.Windows.Forms.TextBox txt_rfid_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lastName_update;
        private System.Windows.Forms.Label lbl_sirName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_secondName_update;
        private System.Windows.Forms.TextBox txt_firstName_update;
        private System.Windows.Forms.Button btn_info_update;
        private System.Windows.Forms.DataGridView dataGridView_read;
        private System.Windows.Forms.Button btn_showAll_update;
    }
}
