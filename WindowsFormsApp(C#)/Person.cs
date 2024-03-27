using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_C__
{
    internal class Person
    {
        private String hoVaTen;
        private String gioiTinh;
        private String diaChi;
        private String CMND;
        private DateTime ngaySinh;
        private String email;
        private String soDienThoai;

        public Person(String hoVaTen, String gioiTinh, String diaChi, String CMND, DateTime ngaySinh, string email, string soDienThoai)
        {
            this.hoVaTen = hoVaTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.CMND = CMND;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.soDienThoai = soDienThoai;
        }
        public Person()
        {

        }
        public String HoVaTen
        {
            get { return hoVaTen; }
            set { hoVaTen = value; }
        }
        
        public String GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        } 

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String Cmnd
        {
            get { return CMND; }
            set { CMND = value; }
        }


        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
    }
}

