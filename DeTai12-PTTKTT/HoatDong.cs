using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel.Attributes;

namespace DeTai12_PTTKTT
{
    [Serializable]
    internal class HoatDong
    {
        //[ExcelColumn("Tên cuộc họp")]
        public string TenHoatDong { get; set; }

        //[ExcelColumn("Thời gian bắt đầu")]
        public DateTime ThoiGianBatDau { get; set; }

        //[ExcelColumn("Thời gian kết thúc")]
        public DateTime ThoiGianKetThuc { get; set; }

        //[ExcelColumn("Độ ưu tiên")]
        public string DoUuTien { get; set; }
    }
}
