﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_C__
{
    internal class GiaoVien : Person
    {
        public GiaoVien(String hoVaTen, String gioiTinh, String diaChi, String CMND, DateTime ngaySinh, string email, string soDienThoai)
        : base(hoVaTen, gioiTinh, diaChi, CMND, ngaySinh, email, soDienThoai)
        {

        }
        public GiaoVien()
        {

        }

    }
}