namespace DeTai12_PTTKTT
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTuanToi = new System.Windows.Forms.Button();
            this.btnTuanTruoc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCuocHop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToday = new System.Windows.Forms.DateTimePicker();
            this.btnTuanNay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTuanToi);
            this.panel1.Controls.Add(this.btnTuanTruoc);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateToday);
            this.panel1.Controls.Add(this.btnTuanNay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 533);
            this.panel1.TabIndex = 0;
            // 
            // btnTuanToi
            // 
            this.btnTuanToi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTuanToi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuanToi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuanToi.Location = new System.Drawing.Point(979, 49);
            this.btnTuanToi.Name = "btnTuanToi";
            this.btnTuanToi.Size = new System.Drawing.Size(122, 42);
            this.btnTuanToi.TabIndex = 42;
            this.btnTuanToi.Text = "Tuần tới";
            this.btnTuanToi.UseVisualStyleBackColor = false;
            this.btnTuanToi.Click += new System.EventHandler(this.btnTuanToi_Click);
            // 
            // btnTuanTruoc
            // 
            this.btnTuanTruoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTuanTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuanTruoc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuanTruoc.Location = new System.Drawing.Point(723, 49);
            this.btnTuanTruoc.Name = "btnTuanTruoc";
            this.btnTuanTruoc.Size = new System.Drawing.Size(122, 42);
            this.btnTuanTruoc.TabIndex = 41;
            this.btnTuanTruoc.Text = "Tuần trước";
            this.btnTuanTruoc.UseVisualStyleBackColor = false;
            this.btnTuanTruoc.Click += new System.EventHandler(this.btnTuanTruoc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenCuocHop,
            this.TimeStart,
            this.TimeEnd,
            this.UuTien});
            this.dataGridView1.Location = new System.Drawing.Point(8, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1093, 424);
            this.dataGridView1.TabIndex = 37;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenCuocHop
            // 
            this.TenCuocHop.DataPropertyName = "TenCuocHop";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCuocHop.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenCuocHop.HeaderText = "Tên cuộc họp";
            this.TenCuocHop.Name = "TenCuocHop";
            this.TenCuocHop.Width = 400;
            // 
            // TimeStart
            // 
            this.TimeStart.DataPropertyName = "TimeStart";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "dd/MM/yy   |    HH:mm";
            this.TimeStart.DefaultCellStyle = dataGridViewCellStyle3;
            this.TimeStart.HeaderText = "Thời gian bắt đầu";
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Width = 200;
            // 
            // TimeEnd
            // 
            this.TimeEnd.DataPropertyName = "TimeEnd";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "dd/MM/yy   |    HH:mm";
            this.TimeEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.TimeEnd.HeaderText = "Thời gian kết thúc";
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Width = 200;
            // 
            // UuTien
            // 
            this.UuTien.DataPropertyName = "UuTien";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UuTien.DefaultCellStyle = dataGridViewCellStyle5;
            this.UuTien.HeaderText = "Mức độ ưu tiên";
            this.UuTien.Name = "UuTien";
            this.UuTien.Width = 150;
            // 
            // dateToday
            // 
            this.dateToday.CustomFormat = "dd/MM/yyyy | HH:mm";
            this.dateToday.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToday.Location = new System.Drawing.Point(8, 55);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(188, 28);
            this.dateToday.TabIndex = 40;
            // 
            // btnTuanNay
            // 
            this.btnTuanNay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTuanNay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuanNay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuanNay.Location = new System.Drawing.Point(851, 49);
            this.btnTuanNay.Name = "btnTuanNay";
            this.btnTuanNay.Size = new System.Drawing.Size(122, 42);
            this.btnTuanNay.TabIndex = 39;
            this.btnTuanNay.Text = "Tuần này";
            this.btnTuanNay.UseVisualStyleBackColor = false;
            this.btnTuanNay.Click += new System.EventHandler(this.btnTuanNay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label1.Size = new System.Drawing.Size(452, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "DANH SÁCH CÁC CUỘC HỌP ĐƯỢC CHỌN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 548);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCuocHop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UuTien;
        private System.Windows.Forms.DateTimePicker dateToday;
        private System.Windows.Forms.Button btnTuanNay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTuanToi;
        private System.Windows.Forms.Button btnTuanTruoc;
    }
}