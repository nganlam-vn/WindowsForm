using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp_C__
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private object textBox2;
        HocSinh hocSinh = new HocSinh();
        HocSinhDAO hocSinhDAO = new HocSinhDAO();

        public FHocSinh()
        {
            InitializeComponent();
            ucThongTin1.btnThem.Click += btnThem_Click;
            ucThongTin1.btnXoa.Click += btnXoa_Click;
            ucThongTin1.btnSua.Click += btnSua_Click;

        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtID.Text, ucThongTin1.dtDOB.Value, ucThongTin1.txtEmail.Text, ucThongTin1.txtSDT.Text);
            hocSinhDAO.them(hocSinh);
            Load_data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtID.Text, ucThongTin1.dtDOB.Value, ucThongTin1.txtEmail.Text, ucThongTin1.txtSDT.Text);
            hocSinhDAO.xoa(hocSinh);
            Load_data();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtID.Text, ucThongTin1.dtDOB.Value, ucThongTin1.txtEmail.Text, ucThongTin1.txtSDT.Text);
            hocSinhDAO.capNhat(hocSinh);
            Load_data();
        }
        private void btnSwitchGV_Click(object sender, EventArgs e)
        {
            FGiaoVien f = new FGiaoVien();
            f.ShowDialog();
            return;
        }
        private void Load_data()
        {
            ucThongTin1.gvThongTin.DataSource = hocSinhDAO.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_data();

        }
        private void ucThongTin1_Load(object sender, EventArgs e)
        {

        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
