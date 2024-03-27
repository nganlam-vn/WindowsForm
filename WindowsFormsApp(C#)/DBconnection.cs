using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_C__
{
    internal class DBconnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        Person person = new Person();
        public DataTable Load(string tableName)
        {
            DataTable dtPerson = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM " + tableName);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtPerson);
               
            
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtPerson;
        }
        public void ThucThi(string str, string tacVu)
        {
            try
            {
                // Ket noi
                conn.Open();

                string sqlStr = string.Format(str);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(tacVu + "Thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(tacVu + "Thất bại! " + ex);
            }
            finally
            {
                conn.Close();
            }

        }
        

    }
}
