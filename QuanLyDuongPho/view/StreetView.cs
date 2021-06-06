using System;
using System.Collections.Generic;
using QuanLyDuongPho.controller;
using QuanLyDuongPho.entity;

namespace QuanLyDuongPho.view
{
    public class StreetView
    {
        private StreetController _streetController = new StreetController();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Quản lý thông tin đường phố.");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Tạo mới đường.");
                Console.WriteLine("2. Hiển thị danh sách đường.");
                Console.WriteLine("3. Sửa thông tin đường.");
                Console.WriteLine("4. Xóa thông tin đường.");
                Console.WriteLine("5. Thoát.");
                var choice =Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _streetController.TaoMoiDuong();
                        break;
                    case 2:
                        _streetController.HienThiDanhSachDuong();
                        break;
                    case 3:
                        _streetController.SuaThongTinDuong();
                        break;
                    case 4:
                        _streetController.XoaThongTinDuong();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai, vui lòng chọn lại.");
                        break;
                }
                Console.ReadLine();
                if (choice == 5)
                {
                    Console.WriteLine("Tạm biệt, hẹn gặp lại !");
                }

            }
        }
    }
}