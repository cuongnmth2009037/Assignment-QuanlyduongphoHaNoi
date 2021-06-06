using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QuanLyDuongPho.entity;
using QuanLyDuongPho.helper;


namespace QuanLyDuongPho.model
{
    public class StreetModel
    {
        private List<Street> _listStreet = new List<Street>();

        public bool Save(Street street)
        {
            var Connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = Connection.CreateCommand();
            mySqlCommand.CommandText =
                $"insert into duongpho (`Ma`, `Ten`, `MoTa`, `NgaySuDung`, `LichSu`, `TenQuan`, `TrangThai`) values " +
                $"('{street.Ma}', '{street.Ten}', '{street.MoTa}','{street.NgaySuDung}', '{street.LichSu}', '{street.TenQuan}', {street.TrangThai})";
            var result = mySqlCommand.ExecuteNonQuery();
            Connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public List<Street> FindAll()
        {
            List<Street> listStreet = new List<Street>();
            var Connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = Connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongpho";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string ma = mySqlDataReader.GetString("Ma");
                string ten = mySqlDataReader.GetString("Ten");
                string mota = mySqlDataReader.GetString("MoTa");
                string ngaysudung = mySqlDataReader.GetString("NgaySuDung");
                string lichsu = mySqlDataReader.GetString("LichSu");
                string tenquan = mySqlDataReader.GetString("TenQuan");
                int trangthai = mySqlDataReader.GetInt32("TrangThai");
                Street street = new Street();
                street.Ma = ma;
                street.Ten = ten;
                street.MoTa = mota;
                street.NgaySuDung = ngaysudung;
                street.LichSu = lichsu;
                street.TenQuan = tenquan;
                street.TrangThai = trangthai;
                listStreet.Add(street);
            }
            mySqlDataReader.Close();
            return listStreet;
        }

        public Street FindById(string id)
        {
            Street street = null;
            var Connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = Connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongpho where Ma = '{id}'";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string ma = mySqlDataReader.GetString("Ma");
                string ten = mySqlDataReader.GetString("Ten");
                string mota = mySqlDataReader.GetString("MoTa");
                string ngaysudung = mySqlDataReader.GetString("NgaySuDung");
                string lichsu = mySqlDataReader.GetString("LichSu");
                string tenquan = mySqlDataReader.GetString("TenQuan");
                int trangthai = mySqlDataReader.GetInt32("TrangThai");
                street = new Street();
                street.Ma = ma;
                street.Ten = ten;
                street.MoTa = mota;
                street.NgaySuDung = ngaysudung;
                street.LichSu = lichsu;
                street.TenQuan = tenquan;
                street.TrangThai = trangthai;
            }
            mySqlDataReader.Close();
            return street;
        }

        public bool Update(string id, Street updateStreet)
        {
            var st = FindById(id);
            if (st == null)
            {
                return false;
            }
            st.Ten = updateStreet.Ten;
            st.MoTa = updateStreet.MoTa;
            st.NgaySuDung = updateStreet.NgaySuDung;
            st.LichSu = updateStreet.LichSu;
            st.TenQuan = updateStreet.TenQuan;
            st.TrangThai = updateStreet.TrangThai;
            var Connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = Connection.CreateCommand();
            mySqlCommand.CommandText =
                $"update duongpho set Ten = '{st.Ten}', MoTa = '{st.MoTa}', NgaySuDung = '{st.NgaySuDung}', LichSu = '{st.LichSu}', TenQUan = '{st.TenQuan}', TrangThai = {st.TrangThai} where Ma = '{id}'";
            var result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public bool Delete(string id)
        {
            var st = FindById(id);
            if (st == null)
            {
                return false;
            }

            var Connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = Connection.CreateCommand();
            mySqlCommand.CommandText = $"delete from duongpho where Ma = '{id}'";
            var result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }

            return false;
        }
    }
}
    
