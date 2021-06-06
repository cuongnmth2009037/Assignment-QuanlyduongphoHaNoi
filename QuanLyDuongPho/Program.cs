using System;
using System.Text;
using QuanLyDuongPho.helper;
using QuanLyDuongPho.model;
using QuanLyDuongPho.view;

namespace QuanLyDuongPho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StreetView streetView = new StreetView();
            streetView.ShowMenu();
        }
    }
}