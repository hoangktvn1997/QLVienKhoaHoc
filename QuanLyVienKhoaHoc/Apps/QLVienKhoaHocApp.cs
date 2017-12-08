using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enties;

namespace QuanLyVienKhoaHoc.Apps
{
    class QLVienKhoaHocApp
    {
        //Định dạng list đối tượng
        List<NhanVien> nhanViens = new List<NhanVien>();
        
        //Nhập list
        public void NhapList()
        {
            int soLuongNhanVien;
            int loaiNhanVien;
            //Nhập số lượng
            Console.Write("Nhập số lượng nhân viên: ");
            soLuongNhanVien = int.Parse(Console.ReadLine());
            //Nhập nhân viên
            for (int i = 0; i < soLuongNhanVien; i++)
            {
                Console.WriteLine("\tThông tin nhân viên thứ {0}:", i + 1);
                //Chọn loại nhân viên
                Console.WriteLine("Chọn loại nhân viên cần nhập: ");
                Console.WriteLine("\t1. Nhà khoa học");
                Console.WriteLine("\t2. Nhà quản lý");
                Console.WriteLine("\t3. Nhân viên phòng thí nghiệm");
                Console.Write("\tChọn loại nhân viên: ");
                //Lấy giá trị lựa chọn
                loaiNhanVien = int.Parse(Console.ReadLine());
                switch (loaiNhanVien)
                {
                    case 1;
                        NhanVien = 
                    default:
                        break;
                }
            }
            
        }

        //Xuất list
        //Tính tổng lương
    }
}
