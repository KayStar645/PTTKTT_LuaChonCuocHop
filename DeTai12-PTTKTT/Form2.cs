using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai12_PTTKTT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void hoatDongTrongTuan(Form3 f, DateTime today)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                row.Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                row.Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                row.Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value;
                row.Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value;
                f.dataGridView1.Rows.Add(row);
            }

            string[] thu = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dau = 0, cuoi = 6;

            for (int i = 0; i < thu.Length; i++)
            {
                if (today.DayOfWeek.ToString() == thu[i])
                {
                    dau -= i;
                    cuoi -= i;
                    break;
                }
            }

            DateTime dauTuan = today.AddDays(dau);
            dauTuan = dauTuan.AddHours(-dauTuan.Hour);
            dauTuan = dauTuan.AddMinutes(-dauTuan.Minute);
            dauTuan = dauTuan.AddSeconds(-dauTuan.Second);

            DateTime cuoiTuan = today.AddDays(cuoi + 1);
            cuoiTuan = cuoiTuan.AddHours(-cuoiTuan.Hour);
            cuoiTuan = cuoiTuan.AddMinutes(-cuoiTuan.Minute);
            cuoiTuan = cuoiTuan.AddSeconds(-cuoiTuan.Second - 1);

            for (int i = 0; i < f.dataGridView1.Rows.Count - 1; i++)
            {
                if (DateTime.Compare((DateTime)f.dataGridView1.Rows[i].Cells[2].Value, dauTuan) >= 0 &&
                    DateTime.Compare((DateTime)f.dataGridView1.Rows[i].Cells[2].Value, cuoiTuan) <= 0) continue;
                else
                {
                    f.dataGridView1.Rows.RemoveAt(f.dataGridView1.Rows[i].Index);
                    i--;
                }
            }
        }

        private void btnTuanNay_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            DateTime today = dateToday.Value;
            hoatDongTrongTuan(f, today);
            f.ShowDialog();
        }


        private void btnTuanTruoc_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            DateTime today = dateToday.Value.AddDays(-7);
            dateToday.Value = today;
            hoatDongTrongTuan(f, today);
            f.ShowDialog();
        }

        private void btnTuanToi_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            DateTime today = dateToday.Value.AddDays(+7);
            dateToday.Value = today;
            hoatDongTrongTuan(f, today);
            f.ShowDialog();
        }
    }
}
