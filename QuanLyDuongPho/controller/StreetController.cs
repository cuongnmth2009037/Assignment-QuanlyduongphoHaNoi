using System;
using System.Collections.Generic;
using QuanLyDuongPho.entity;
using QuanLyDuongPho.model;
using QuanLyDuongPho.model;

namespace QuanLyDuongPho.controller
{
    public class StreetController
    {
        private StreetModel _streetModel = new StreetModel();
        public void TaoMoiDuong()
        {
            Street street = new Street();
            Console.WriteLine("Vui lòng nhập thông tin đường: ");
            Console.WriteLine("Vui lòng nhập mã đường: ");
            var maduong = Console.ReadLine();
            street.Ma = maduong;
            Console.WriteLine("Vui lòng nhập tên đường: ");
            var tenduong = Console.ReadLine();
            street.Ten = tenduong;
            Console.WriteLine("Vui lòng nhập mô tả: ");
            var mota = Console.ReadLine();
            street.MoTa = mota;
            Console.WriteLine("Vui lòng nhập ngày sử dụng: ");
            var ngaysudung = Console.ReadLine();
            street.NgaySuDung = ngaysudung;
            Console.WriteLine("Vui lòng nhập lịch sử: ");
            var lichsu = Console.ReadLine();
            street.LichSu = lichsu;
            Console.WriteLine("Vui lòng nhập tên quận: ");
            var tenquan = Console.ReadLine();
            street.TenQuan = tenquan;
            Console.WriteLine("Vui lòng nhập trạng thái : ");
            var trangthai = Console.ReadLine();
            street.TrangThai = Convert.ToInt32(trangthai);
            bool result = _streetModel.Save(street);
            if (result )
            {
                Console.WriteLine("Tạo tên đường thành công.");
            }
            else
            {
                Console.WriteLine("Tạo tên đường không thành công.");
            }
        }

        public void HienThiDanhSachDuong()
        {
            List<Street> listStreet = _streetModel.FindAll();
            Console.WriteLine("Danh sách tên đường phố: ");
            for (int i = 0; i < listStreet.Count; i++)
            {
                var st = listStreet[i];
                Console.WriteLine($"Ma: {st.Ma}. Ten: {st.Ten}. MoTa: {st.MoTa}. LichSu: {st.LichSu}. NgaySuDung: {st.NgaySuDung}. LichSu: {st.LichSu}. TenQuan: {st.TenQuan}. TrangThai: {st.TrangThai}");
            }
        }

        public void SuaThongTinDuong()
        {
            Console.WriteLine("Vui lòng nhập mã đường cần sửa: ");
            var maduong = Console.ReadLine();
            var st = _streetModel.FindById(maduong);
            if (st == null)
            {
                Console.WriteLine("Không tìm thấy mã đường cần sửa.");
            }

            Console.WriteLine("Vui lòng nhập tên đường: ");
            var tenduong = Console.ReadLine();
            st.Ten = tenduong;
            Console.WriteLine("Vui lòng hập mô tả: ");
            var mota = Console.ReadLine();
            st.MoTa = mota;
            Console.WriteLine("Vui lòng nhập ngày sửa dụng: ");
            var ngay = Console.ReadLine();
            st.NgaySuDung = ngay;
            Console.WriteLine("Vui lòng nhập lịch sử: ");
            var lichsu = Console.ReadLine();
            st.LichSu = lichsu;
            Console.WriteLine("Vui lòng nhập tên quận: ");
            var tenquan = Console.ReadLine();
            st.TenQuan = tenquan;
            Console.WriteLine("Vui lòng nhập trạng thái: ");
            var trangthai = Console.ReadLine();
            st.TrangThai = Convert.ToInt32( trangthai);
            bool result = _streetModel.Update(maduong,st);
            if (result)
            {
                Console.WriteLine("Sửa thông tin thành công.");
            }
            else
            {
                Console.WriteLine("Sửa thông tin thất bại.");
            }
        }

        public void XoaThongTinDuong()
        {
            Console.WriteLine("Vui lòng nhập mã đường cần xóa: ");
            var maduong = Console.ReadLine();
            var st = _streetModel.FindById(maduong);
            if (st == null)
            {
                Console.WriteLine("Không tìm thấy mã đường .");
            }

            Console.WriteLine($"Tìm thấy thông tin đường có Mã: {st.Ma}, Tên: {st.Ten}");
            Console.WriteLine("Bạn có chắc chắn muốn xóa đường này không (C/K) ?");
            var choice = Console.ReadLine();
            if (choice.ToLower().Equals("c"))
            {
                bool result = _streetModel.Delete(maduong);
                if (result)
                {
                    Console.WriteLine("Xóa thông tin thành công.");
                }
                else
                {
                    Console.WriteLine("Xóa thông tin thất bại, vui lòng thử lại.");
                }
            }
        }
    }
}