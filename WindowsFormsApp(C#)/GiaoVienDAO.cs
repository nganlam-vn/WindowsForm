using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_C__
{
    internal class GiaoVienDAO : PersonDAO
    {
        public GiaoVienDAO() 
        {
            type = "GiaoVien";
        }
        
    }
}

