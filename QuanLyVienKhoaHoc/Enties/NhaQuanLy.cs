using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enum;

namespace QuanLyVienKhoaHoc.Enties
{
    class NhaQuanLy : NhanVien
    {
        public ChucVu ChucVu { get; set; }

        public int SoNgayCong { get; set; }

        public double BacLuong { get; set; }
    }
}
