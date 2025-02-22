namespace RFIDWindowsForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_writing = new System.Windows.Forms.Button();
            this.btn_reading = new System.Windows.Forms.Button();
            this.ucReading = new RFIDWindowsForms.UCReading();
            this.ucWrite = new RFIDWindowsForms.UCWrite();
            this.ucUpdating = new RFIDWindowsForms.UCUpdating();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(190)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_writing);
            this.panel1.Controls.Add(this.btn_reading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 90);
            this.panel1.TabIndex = 14;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(572, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(274, 65);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "ПРОМЯНА";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_writing
            // 
            this.btn_writing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_writing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_writing.FlatAppearance.BorderSize = 0;
            this.btn_writing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_writing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_writing.Location = new System.Drawing.Point(292, 12);
            this.btn_writing.Name = "btn_writing";
            this.btn_writing.Size = new System.Drawing.Size(274, 65);
            this.btn_writing.TabIndex = 1;
            this.btn_writing.Text = "ВМЪКВАНЕ";
            this.btn_writing.UseVisualStyleBackColor = false;
            this.btn_writing.Click += new System.EventHandler(this.btn_writing_Click);
            // 
            // btn_reading
            // 
            this.btn_reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.btn_reading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reading.FlatAppearance.BorderSize = 0;
            this.btn_reading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reading.Location = new System.Drawing.Point(12, 12);
            this.btn_reading.Name = "btn_reading";
            this.btn_reading.Size = new System.Drawing.Size(274, 65);
            this.btn_reading.TabIndex = 0;
            this.btn_reading.Text = "ЧЕТЕНЕ";
            this.btn_reading.UseVisualStyleBackColor = false;
            this.btn_reading.Click += new System.EventHandler(this.btn_reading_Click);
            // 
            // ucReading
            // 
            this.ucReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(135)))), ((int)(((byte)(117)))));
            this.ucReading.Location = new System.Drawing.Point(0, 90);
            this.ucReading.Name = "ucReading";
            this.ucReading.Size = new System.Drawing.Size(860, 575);
            this.ucReading.TabIndex = 18;
            // 
            // ucWrite
            // 
            this.ucWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(106)))));
            this.ucWrite.Location = new System.Drawing.Point(0, 90);
            this.ucWrite.Name = "ucWrite";
            this.ucWrite.Size = new System.Drawing.Size(860, 575);
            this.ucWrite.TabIndex = 15;
            // 
            // ucUpdating
            // 
            this.ucUpdating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.ucUpdating.Location = new System.Drawing.Point(0, 90);
            this.ucUpdating.Name = "ucUpdating";
            this.ucUpdating.Size = new System.Drawing.Size(860, 575);
            this.ucUpdating.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 664);
            this.Controls.Add(this.ucReading);
            this.Controls.Add(this.ucWrite);
            this.Controls.Add(this.ucUpdating);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X SCHOOL ATENDENCE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_writing;
        private System.Windows.Forms.Button btn_reading;
        private System.Windows.Forms.Button btn_update;
        private UCWrite ucWrite;
        private UCReading ucReading;
        private UCUpdating ucUpdating;
    }
}

