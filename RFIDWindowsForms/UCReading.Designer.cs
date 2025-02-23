namespace RFIDWindowsForms
{
    partial class UCReading
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_reader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_info_read = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_read = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_read)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_reader
            // 
            this.txt_reader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reader.Location = new System.Drawing.Point(137, 155);
            this.txt_reader.Name = "txt_reader";
            this.txt_reader.Size = new System.Drawing.Size(246, 34);
            this.txt_reader.TabIndex = 0;
            this.txt_reader.TextChanged += new System.EventHandler(this.txt_reader_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "ЧЕТЕНЕ НА RFID ЧИП";
            // 
            // btn_info_read
            // 
            this.btn_info_read.BackgroundImage = global::RFIDWindowsForms.Properties.Resources._299086_info_sign_icon;
            this.btn_info_read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_read.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_info_read.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_info_read.FlatAppearance.BorderSize = 0;
            this.btn_info_read.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_read.Location = new System.Drawing.Point(3, 3);
            this.btn_info_read.Name = "btn_info_read";
            this.btn_info_read.Size = new System.Drawing.Size(45, 44);
            this.btn_info_read.TabIndex = 33;
            this.btn_info_read.UseVisualStyleBackColor = true;
            this.btn_info_read.Click += new System.EventHandler(this.btn_info_read_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDWindowsForms.Properties.Resources.logoX;
            this.pictureBox1.Location = new System.Drawing.Point(550, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_read
            // 
            this.dataGridView_read.AllowUserToAddRows = false;
            this.dataGridView_read.AllowUserToDeleteRows = false;
            this.dataGridView_read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_read.Location = new System.Drawing.Point(5, 301);
            this.dataGridView_read.Name = "dataGridView_read";
            this.dataGridView_read.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_read.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_read.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_read.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_read.RowTemplate.Height = 28;
            this.dataGridView_read.Size = new System.Drawing.Size(852, 271);
            this.dataGridView_read.TabIndex = 49;
            // 
            // UCReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(135)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.dataGridView_read);
            this.Controls.Add(this.btn_info_read);
            this.Controls.Add(this.txt_reader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCReading";
            this.Size = new System.Drawing.Size(860, 575);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_read)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_info_read;
        private System.Windows.Forms.DataGridView dataGridView_read;
        public System.Windows.Forms.TextBox txt_reader;
    }
}
