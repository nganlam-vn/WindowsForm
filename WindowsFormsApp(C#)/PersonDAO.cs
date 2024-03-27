using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_C__
{
    internal class PersonDAO
    {
        Person person = new Person();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBconnection dt = new DBconnection();
        public string type;
        public DataTable Load()
        {
            return dt.Load(type);
        }
        public void ThucThi(string str, string tacVu)
        {
            dt.ThucThi(str, tacVu);

        }
        public void them(Person person)
        {
            string sqlStr = string.Format("INSERT INTO {0}(Ten, GioiTinh, Diachi, Cmnd, NgaySinh, Email, SoDienThoai) VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}' )", type, person.HoVaTen, person.GioiTinh, person.DiaChi, person.Cmnd, new DateTime(person.NgaySinh.Year, person.NgaySinh.Month, person.NgaySinh.Day), person.Email, person.SoDienThoai);
            KiemTraDieuKien(person, sqlStr, "Thêm ");
        }

        public void xoa(Person person)
        {
            string SQL = string.Format("DELETE FROM {0} WHERE Cmnd = '{1}'", type, person.Cmnd);
            ThucThi(SQL, "Xóa ");
        }

        public void capNhat(Person person)
        {
            string SQL = string.Format("UPDATE {0} SET Ten = '{1}', GioiTinh = '{2}', DiaChi = '{3}', NgaySinh = '{4}', Email = '{5}', SoDienThoai = '{6}' WHERE Cmnd = '{7}'",type , person.HoVaTen, person.GioiTinh, person.DiaChi, new DateTime(person.NgaySinh.Year, person.NgaySinh.Month, person.NgaySinh.Day), person.Email, person.SoDienThoai, person.Cmnd);
            ThucThi(SQL, "Cập nhật ");
        }

        public void KiemTraDieuKien(Person person, string SQL, string tacVu)
        {
            if(ThongTinHopLe(person))
            {
                ThucThi(SQL, tacVu);
            }

        }
        public bool ThongTinHopLe(Person person)
        {
            bool emailHopLe = EmailHopLe(person.Email);
            bool soDienThoaiHopLe = SoDienThoaiHopLe(person.SoDienThoai);
            bool tuoiHopLe = TuoiHopLe(person.NgaySinh.Year);

            if(person.HoVaTen =="" || person.GioiTinh =="" || person.DiaChi =="" || person.Cmnd =="" 
                || person.SoDienThoai =="" || person.Email =="" )
            {
                MessageBox.Show("Không được để trống thông tin!");
            }
                
            if (tuoiHopLe == false)
            {
                MessageBox.Show("Tuổi không hợp lệ!");
                return false;   
            }
            if (emailHopLe == false)
            {
                MessageBox.Show("Email không hợp lệ!");
                return false;
            }
                
            if (soDienThoaiHopLe == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return false;
            }
            return true;
                
        }

        public bool TuoiHopLe(int namSinh)
        {
            //kiem tra tuoi tu 17 tro len tinh den nam 2024
            if(namSinh <= 2007)
                return true;
            else
                return false;
        }
        public bool EmailHopLe(string email)
        {
            //email hop le co the duoi dang @gmail.com, @outlook.com, @yahoo.com...
            if (email.Contains('@') && email.Contains('.'))
                return true;
            else return false;
        }

        public bool SoDienThoaiHopLe(String sdt)
        {
            //so dien thoai co do dai la 10, va khong am
            if (sdt.Length != 10) return false;
            for (int i = 0; i < sdt.Length; i++)
            {
                if (sdt[i] < '0'|| sdt[i] > '9') return false;
            }
            return true;
        }
        
    }
}
