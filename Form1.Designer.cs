namespace DeTai12_PTTKTT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuaChon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCuocHop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.btnDel = new System.Windows.Forms.Button();
            this.doUuTien = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLuaChon);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.doUuTien);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 639);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 148);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 31;
            this.button1.Text = "Đọc File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuaChon
            // 
            this.btnLuaChon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuaChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuaChon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuaChon.Location = new System.Drawing.Point(981, 154);
            this.btnLuaChon.Name = "btnLuaChon";
            this.btnLuaChon.Size = new System.Drawing.Size(122, 42);
            this.btnLuaChon.TabIndex = 30;
            this.btnLuaChon.Text = "Lựa chọn";
            this.btnLuaChon.UseVisualStyleBackColor = false;
            this.btnLuaChon.Click += new System.EventHandler(this.btnLuaChon_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1093, 423);
            this.dataGridView1.TabIndex = 25;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.DefaultCellStyle = dataGridViewCellStyle6;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.STT.Width = 60;
            // 
            // TenCuocHop
            // 
            this.TenCuocHop.DataPropertyName = "TenCuocHop";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCuocHop.DefaultCellStyle = dataGridViewCellStyle7;
            this.TenCuocHop.HeaderText = "Tên cuộc họp";
            this.TenCuocHop.Name = "TenCuocHop";
            this.TenCuocHop.Width = 464;
            // 
            // TimeStart
            // 
            this.TimeStart.DataPropertyName = "TimeStart";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "dd/MM/yy   |    HH:mm";
            this.TimeStart.DefaultCellStyle = dataGridViewCellStyle8;
            this.TimeStart.HeaderText = "Thời gian bắt đầu";
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ReadOnly = true;
            this.TimeStart.Width = 188;
            // 
            // TimeEnd
            // 
            this.TimeEnd.DataPropertyName = "TimeEnd";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "dd/MM/yy   |    HH:mm";
            this.TimeEnd.DefaultCellStyle = dataGridViewCellStyle9;
            this.TimeEnd.HeaderText = "Thời gian kết thúc";
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.ReadOnly = true;
            this.TimeEnd.Width = 188;
            // 
            // UuTien
            // 
            this.UuTien.DataPropertyName = "UuTien";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UuTien.DefaultCellStyle = dataGridViewCellStyle10;
            this.UuTien.HeaderText = "Mức độ ưu tiên";
            this.UuTien.Name = "UuTien";
            this.UuTien.Width = 150;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd/MM/yy   |    HH:mm";
            this.dateEnd.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(551, 111);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(188, 28);
            this.dateEnd.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 66);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.label4.Size = new System.Drawing.Size(192, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thời gian kết thúc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "dd/MM/yy   |    HH:mm";
            this.dateStart.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(319, 111);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(188, 28);
            this.dateStart.TabIndex = 24;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(1000, 105);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 42);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // doUuTien
            // 
            this.doUuTien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.doUuTien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doUuTien.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doUuTien.FormattingEnabled = true;
            this.doUuTien.Items.AddRange(new object[] {
            "Bắt buộc",
            "Bình thường",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.doUuTien.Location = new System.Drawing.Point(776, 107);
            this.doUuTien.Name = "doUuTien";
            this.doUuTien.Size = new System.Drawing.Size(145, 29);
            this.doUuTien.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1000, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 42);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(10, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 28);
            this.txtName.TabIndex = 7;
            this.txtName.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 67);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(149, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mức độ ưu tiên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 66);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thời gian bắt đầu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(258, 0);
            this.label2.MinimumSize = new System.Drawing.Size(258, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(258, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên cuộc họp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(439, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15);
            this.label1.Size = new System.Drawing.Size(273, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỰA CHỌN HOẠT ĐỘNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 645);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLuaChon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.ComboBox doUuTien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCuocHop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UuTien;
    }
}

