using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace DeTai12_PTTKTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && dateStart.Text != "" && dateEnd.Text != "" && doUuTien.Text != "")
            {
                if (dateStart.Value < dateEnd.Value)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txtName.Text &&
                            DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)dateStart.Value) == 0 &&
                            DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)dateEnd.Value) == 0 &&
                            dataGridView1.Rows[i].Cells[4].Value.ToString() == doUuTien.Text)
                        {
                            MessageBox.Show("Cuộc họp này đã tồn tại trong danh sach!");
                            return;
                        }
                    }

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[1].Value = txtName.Text;
                    row.Cells[2].Value = dateStart.Value;
                    row.Cells[3].Value = dateEnd.Value;
                    row.Cells[4].Value = doUuTien.Text;
                    dataGridView1.Rows.Add(row);
                    //Sắp xếp theo thời gian kết thúc
                    sapXepTheoThoiGianKetThuc();
                    //Đánh lại số thứ tự
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                else
                {
                    MessageBox.Show("Thời gian bắt đầu phải trước thời gian kết thúc!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đủ dữ liệu đầu vào!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            //Đánh lại số thứ tự
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public void hoanDoi(ref DataGridViewRow a, ref DataGridViewRow b)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row = a;
            a = b;
            b = row;
        }    

        

        private int quyDoiDiemUuTien(string s)
        {
            if (s == "Bắt buộc")
                return 1000;
            else if (s == "Bình thường")
                return 0;
            int x = int.Parse(s);
            for (int i = 1, j = 100; i <= 10; i++, j -= 10)
            {
                if (x == i)
                {
                    x += j;
                    break;
                }
            }    
            return x;
        }    

        private int soSanhMucDoUuTien(string s1, string s2)
        {
            if (quyDoiDiemUuTien(s1) == quyDoiDiemUuTien(s2))
                return 0;
            else if (quyDoiDiemUuTien(s1) > quyDoiDiemUuTien(s2))
                return 1;
            return -1;
        }

        private void sapXepTheoThoiGianKetThuc()
        {
            //Sắp xếp theo thời gian kết thúc kết hợp mức độ ưu tiên khi thời gian kết thúc trùng nhau
            for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
            {
                for (int j = i + 1; j < dataGridView1.Rows.Count - 1; j++)
                {
                    if(DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)dataGridView1.Rows[j].Cells[3].Value) > 0)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;

                        dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[j].Cells[0].Value;
                        dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells[1].Value;
                        dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells[2].Value;
                        dataGridView1.Rows[i].Cells[3].Value = dataGridView1.Rows[j].Cells[3].Value;
                        dataGridView1.Rows[i].Cells[4].Value = dataGridView1.Rows[j].Cells[4].Value;

                        dataGridView1.Rows[j].Cells[0].Value = row.Cells[0].Value;
                        dataGridView1.Rows[j].Cells[1].Value = row.Cells[1].Value;
                        dataGridView1.Rows[j].Cells[2].Value = row.Cells[2].Value;
                        dataGridView1.Rows[j].Cells[3].Value = row.Cells[3].Value;
                        dataGridView1.Rows[j].Cells[4].Value = row.Cells[4].Value;
                    }
                    else if (DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)dataGridView1.Rows[j].Cells[3].Value) == 0)
                    {
                        if(soSanhMucDoUuTien(dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[j].Cells[4].Value.ToString()) < 0)
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                            row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                            row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                            row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                            row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                            row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;

                            dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[j].Cells[0].Value;
                            dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells[1].Value;
                            dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells[2].Value;
                            dataGridView1.Rows[i].Cells[3].Value = dataGridView1.Rows[j].Cells[3].Value;
                            dataGridView1.Rows[i].Cells[4].Value = dataGridView1.Rows[j].Cells[4].Value;

                            dataGridView1.Rows[j].Cells[0].Value = row.Cells[0].Value;
                            dataGridView1.Rows[j].Cells[1].Value = row.Cells[1].Value;
                            dataGridView1.Rows[j].Cells[2].Value = row.Cells[2].Value;
                            dataGridView1.Rows[j].Cells[3].Value = row.Cells[3].Value;
                            dataGridView1.Rows[j].Cells[4].Value = row.Cells[4].Value;
                        }
                    }    
                }
            }
        }

        private void sapXepTheoDoUuTien()
        {
            //Sắp xếp theo độ ưu tiên
            for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
            {
                for (int j = i + 1; j < dataGridView1.Rows.Count - 1; j++)
                {
                    if (soSanhMucDoUuTien(dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[j].Cells[4].Value.ToString()) < 0)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;

                        dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[j].Cells[0].Value;
                        dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells[1].Value;
                        dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells[2].Value;
                        dataGridView1.Rows[i].Cells[3].Value = dataGridView1.Rows[j].Cells[3].Value;
                        dataGridView1.Rows[i].Cells[4].Value = dataGridView1.Rows[j].Cells[4].Value;

                        dataGridView1.Rows[j].Cells[0].Value = row.Cells[0].Value;
                        dataGridView1.Rows[j].Cells[1].Value = row.Cells[1].Value;
                        dataGridView1.Rows[j].Cells[2].Value = row.Cells[2].Value;
                        dataGridView1.Rows[j].Cells[3].Value = row.Cells[3].Value;
                        dataGridView1.Rows[j].Cells[4].Value = row.Cells[4].Value;
                    }
                    else if (soSanhMucDoUuTien(dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[j].Cells[4].Value.ToString()) == 0)
                    {
                        if (DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)dataGridView1.Rows[j].Cells[3].Value) > 0)
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                            row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                            row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                            row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                            row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                            row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;

                            dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[j].Cells[0].Value;
                            dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[j].Cells[1].Value;
                            dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[j].Cells[2].Value;
                            dataGridView1.Rows[i].Cells[3].Value = dataGridView1.Rows[j].Cells[3].Value;
                            dataGridView1.Rows[i].Cells[4].Value = dataGridView1.Rows[j].Cells[4].Value;

                            dataGridView1.Rows[j].Cells[0].Value = row.Cells[0].Value;
                            dataGridView1.Rows[j].Cells[1].Value = row.Cells[1].Value;
                            dataGridView1.Rows[j].Cells[2].Value = row.Cells[2].Value;
                            dataGridView1.Rows[j].Cells[3].Value = row.Cells[3].Value;
                            dataGridView1.Rows[j].Cells[4].Value = row.Cells[4].Value;
                        }    
                    }    
                }
            }
        }    

        private void chonHoatDongBatBuoc(Form2 f)
        {
            //Đưa cuộc họp bắt buộc vào
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Bắt buộc")
                {
                    bool flag = false;   //Không đụng độ thời gian
                    for (int j = 0; j < f.dataGridView1.Rows.Count - 1; j++)
                    {
                        if (DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)f.dataGridView1.Rows[j].Cells[2].Value) < 0 &&
                                DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)f.dataGridView1.Rows[j].Cells[2].Value) < 0 ||
                                DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)f.dataGridView1.Rows[j].Cells[3].Value) > 0 &&
                                DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)f.dataGridView1.Rows[j].Cells[3].Value) > 0) continue;
                        else
                        {
                            flag = true;    //Bị đụng độ thời gian
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        f.dataGridView1.Rows.Add(row);
                    }
                }
            }
        }    

        private void chonHoatDongUuTien(Form2 f)
        {
            //Đưa các cuộc họp được ưu tiên vào
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (IsNumber(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    bool flag = false;   //Không đụng độ thời gian
                    for (int j = 0; j < f.dataGridView1.Rows.Count - 1; j++)
                    {
                        if (DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)f.dataGridView1.Rows[j].Cells[2].Value) < 0 &&
                                DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)f.dataGridView1.Rows[j].Cells[2].Value) < 0 ||
                                DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)f.dataGridView1.Rows[j].Cells[3].Value) > 0 &&
                                DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)f.dataGridView1.Rows[j].Cells[3].Value) > 0) continue;
                        else
                        {
                            flag = true;    //Bị đụng độ thời gian
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                        row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                        row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                        row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                        f.dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void chonHoatDongThuong(Form2 f)
        {
            //Chọn cuộc họp thường vào
            this.dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool flag = false;   //Không đụng độ thời gian
                for (int j = 0; j < f.dataGridView1.Rows.Count - 1; j++)
                {
                    if (DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)f.dataGridView1.Rows[j].Cells[2].Value) < 0 &&
                            DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)f.dataGridView1.Rows[j].Cells[2].Value) < 0 ||
                            DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[2].Value, (DateTime)f.dataGridView1.Rows[j].Cells[3].Value) > 0 &&
                            DateTime.Compare((DateTime)dataGridView1.Rows[i].Cells[3].Value, (DateTime)f.dataGridView1.Rows[j].Cells[3].Value) > 0) continue;
                    else
                    {
                        flag = true;    //Bị đụng độ thời gian
                        break;
                    }
                }
                if (flag == false)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                    row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                    row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                    row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                    row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                    f.dataGridView1.Rows.Add(row);
                }
            }
        }    

        private void btnLuaChon_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            sapXepTheoThoiGianKetThuc();
            chonHoatDongBatBuoc(f);

            sapXepTheoDoUuTien();
            chonHoatDongUuTien(f);

            sapXepTheoThoiGianKetThuc();
            chonHoatDongThuong(f);

            f.ShowDialog();
        }    

        private void ImportExcel(string path)
        {
            string fileName = path;

            try
            {
                OleDbConnection connection = new OleDbConnection();

                connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + fileName);
                string excelQuery = @"Select [STT],[TenCuocHop],[ThoiGianBatDau],[ThoiGianKetThuc],[DoUuTien] FROM [Sheet1$]";

                connection.Open();
                OleDbCommand cmd = new OleDbCommand(excelQuery, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = dt.Rows[i].ItemArray[0];
                    row.Cells[1].Value = dt.Rows[i].ItemArray[1];
                    row.Cells[2].Value = (DateTime)dt.Rows[i].ItemArray[2];
                    row.Cells[3].Value = (DateTime)dt.Rows[i].ItemArray[3];
                    row.Cells[4].Value = dt.Rows[i].ItemArray[4];
                    dataGridView1.Rows.Add(row);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng mở File!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    sapXepTheoThoiGianKetThuc();
                    //Đánh lại số thứ tự
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Đọc File không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
