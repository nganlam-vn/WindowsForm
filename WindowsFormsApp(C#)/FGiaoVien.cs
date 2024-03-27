using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp_C__
{
    public partial class FGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private object textBox2;
        GiaoVien giaoVien = new GiaoVien();
        GiaoVienDAO gvDAO = new GiaoVienDAO();
       
        public FGiaoVien()
        {
            InitializeComponent();
            ucThongTin1.btnThem.Click += btnThem_Click;
            ucThongTin1.btnXoa.Click += btnXoa_Click; 
            ucThongTin1.btnSua.Click += btnSua_Click;
        }
        private void Load_data()
        {
            ucThongTin1.gvThongTin.DataSource = gvDAO.Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text , ucThongTin1.txtAddress.Text, ucThongTin1.txtID.Text, ucThongTin1.dtDOB.Value, ucThongTin1.txtEmail.Text, ucThongTin1.txtSDT.Text);
            gvDAO.xoa(giaoVien);
            Load_data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtID.Text, ucThongTin1.dtDOB.Value, ucThongTin1.txtEmail.Text, ucThongTin1.txtSDT.Text);
            gvDAO.them(giaoVien);
            Load_data();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtID.Text, ucThongTin1.dtDOB.Value, ucThongTin1.txtEmail.Text, ucThongTin1.txtSDT.Text);
            gvDAO.capNhat(giaoVien);
            Load_data();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void gvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ucThongTin1_Load(object sender, EventArgs e)
        {

        }
    }
}
